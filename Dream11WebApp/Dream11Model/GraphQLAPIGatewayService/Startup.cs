using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQLAPIGatewayService.GraphQLModel;
using GraphQLAPIGatewayService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GraphQLAPIGatewayService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IDream11MatchService, Dream11MatchService>();
            services.AddTransient<IDream11PlayerService, Dream11PlayerService>();
            services.AddTransient<IDream11TeamService, Dream11TeamService>();
            services.AddTransient<IDream11ContestService, Dream11ContestService>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<Dream11Query>();
            services.AddSingleton<PlayerQuery>();
            services.AddSingleton<MatchQuery>();
            services.AddSingleton<TeamQuery>();
            services.AddSingleton<ContestQuery>();
            services.AddSingleton<Dream11Mutation>();
            services.AddSingleton<MatchInputType>();
            services.AddSingleton<MatchType>();
            services.AddSingleton<TeamType>();
            services.AddSingleton<ContestType>();
            services.AddSingleton<PlayerType>();

            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new Dream11Schema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            app.UseMvc();
        }
    }
}
