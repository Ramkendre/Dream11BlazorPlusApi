using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIGatewayService.GraphQLModel
{
    public  class Dream11Schema :Schema
    {
        public Dream11Schema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<Dream11Query>();
        }

    }
}
