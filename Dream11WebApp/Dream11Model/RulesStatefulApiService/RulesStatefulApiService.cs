using System;
using System.Collections.Generic;
using System.Fabric;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.ServiceFabric.Services.Communication.AspNetCore;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Microsoft.ServiceFabric.Data;
using RulesStatefulServiceApiService.Model;
using Newtonsoft.Json;
using Microsoft.ServiceFabric.Data.Collections;
using System.Net.Http;

namespace RulesStatefulApiService
{
    /// <summary>
    /// The FabricRuntime creates an instance of this class for each service type instance. 
    /// </summary>
    internal sealed class RulesStatefulApiService : StatefulService
    {
        public RulesStatefulApiService(StatefulServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (like tcp, http) for this service instance.
        /// </summary>
        /// <returns>The collection of listeners.</returns>
        protected override IEnumerable<ServiceReplicaListener> CreateServiceReplicaListeners()
        {
            return new ServiceReplicaListener[]
            {
                new ServiceReplicaListener(serviceContext =>
                    new KestrelCommunicationListener(serviceContext, (url, listener) =>
                    {
                        ServiceEventSource.Current.ServiceMessage(serviceContext, $"Starting Kestrel on {url}");

                        return new WebHostBuilder()
                                    .UseKestrel()
                                    .ConfigureServices(
                                        services => services
                                            .AddSingleton<StatefulServiceContext>(serviceContext)
                                            .AddSingleton<IReliableStateManager>(this.StateManager))
                                    .UseContentRoot(Directory.GetCurrentDirectory())
                                    .UseStartup<Startup>()
                                    .UseServiceFabricIntegration(listener, ServiceFabricIntegrationOptions.UseUniqueServiceUrl)
                                    .UseUrls(url)
                                    .Build();
                    }))
            };
        }
        protected override async Task RunAsync(CancellationToken cancellationToken)
        {
            // TODO: Replace the following sample code with your own logic 
            //       or remove this RunAsync override if it's not needed in your service.
            if (cancellationToken.IsCancellationRequested)
            {

            }
            var playerMatchStatisticsDictionary = await this.StateManager.GetOrAddAsync<IReliableDictionary<int, int>>("PlayerMatchStatisticsDictionary");

            //while (true)
            //{
            //    cancellationToken.ThrowIfCancellationRequested();

            //    using (var tx = this.StateManager.CreateTransaction())
            //    {
            //        var result = await myDictionary.TryGetValueAsync(tx, "Counter");

            //        ServiceEventSource.Current.ServiceMessage(this.Context, "Current Counter Value: {0}",
            //            result.HasValue ? result.Value.ToString() : "Value does not exist.");

            //        await myDictionary.AddOrUpdateAsync(tx, "Counter", 0, (key, value) => ++value);

            //        // If an exception is thrown before calling CommitAsync, the transaction aborts, all changes are 
            //        // discarded, and nothing is saved to the secondary replicas.
            //        await tx.CommitAsync();
            //    }

            //    await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            //}
            while (true)
            {
                List<PlayerMatchStatistics> stats;
                stats = new List<PlayerMatchStatistics>();

                CancellationToken ct = new CancellationToken();

                List<PlayerMatchStatistics> result = new List<PlayerMatchStatistics>();
                using (var tx = this.StateManager.CreateTransaction())
                {
                    var playerlist = await playerMatchStatisticsDictionary.CreateEnumerableAsync(tx);
                    Microsoft.ServiceFabric.Data.IAsyncEnumerator<KeyValuePair<int, int>> enumerator = playerlist.GetAsyncEnumerator();

                    while (await enumerator.MoveNextAsync(ct))
                    {
                        stats.Add(new PlayerMatchStatistics { PlayerId = enumerator.Current.Key, PlayerPoints = enumerator.Current.Value });
                    }
                }
                ////get it from RD this returns instance of PlayerMatchStatistics
                //PlayerMatchStatistics playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 1;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 2;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 3;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 4;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 5;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 6;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 7;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);
                //playerMatchStatistics = new PlayerMatchStatistics();
                //playerMatchStatistics.PlayerId = 8;
                //playerMatchStatistics.PlayerPoints = 100;
                //stats.Add(playerMatchStatistics);

                //Apply rules to the entries from the DB


                var json = "[{'matchPlayerPerformaId':1,'userId':1,'playerId':1,'matchId':1,'strike':4,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':false,'isRunOut':false,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':2,'userId':1,'playerId':8,'matchId':1,'strike':0,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':false,'isRunOut':true,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':3,'userId':1,'playerId':2,'matchId':1,'strike':0,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':true,'isRunOut':false,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':4,'userId':1,'playerId':3,'matchId':1,'strike':0,'isCaughtAndBowled':true,'hasWicketTaken':true,'isStumped':false,'isRunOut':false,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':5,'userId':1,'playerId':4,'matchId':1,'strike':6,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':false,'isRunOut':false,'isHalfCentury':true,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':6,'userId':1,'playerId':5,'matchId':1,'strike':0,'isCaughtAndBowled':false,'hasWicketTaken':true,'isStumped':false,'isRunOut':false,'isHalfCentury':false,'isCentury':false,'isFourWickets':true,'isEightWickets':false,'isMaidenOver':true,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':7,'userId':1,'playerId':6,'matchId':1,'strike':0,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':false,'isRunOut':true,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':false,'totalRun':0,'totalWicket':0,'over':0.00},{'matchPlayerPerformaId':8,'userId':1,'playerId':7,'matchId':1,'strike':0,'isCaughtAndBowled':false,'hasWicketTaken':false,'isStumped':false,'isRunOut':false,'isHalfCentury':false,'isCentury':false,'isFourWickets':false,'isEightWickets':false,'isMaidenOver':false,'isDismissalOnDuck':true,'totalRun':0,'totalWicket':0,'over':0.00}]";
                //using (var httpClient = new HttpClient())
                //{
                  

                //   json = httpClient.GetStringAsync(new Uri("http://idtp376.synerzipune.local:8562/api/PlayerPerfoma/")).Result;

                   
                //}
                ValidationContext context = new ValidationContext();
                var playerStatistics = JsonConvert.DeserializeObject<List<PlayerStatistics>>(json);
                foreach (var point in playerStatistics)
                {
                    //   var point = new PlayerStatistics { Strike = 3 };
                    var wicketpoints = Rule.Create(point,
                                                         entity => entity.Strike > 0 ?
                                                      CalculatePoints.CalculateStrikePoints(point, stats) :
                                                      CalculatePoints.FillEmptyPoints(point));

                    //  point = new PlayerStatistics { HasWicketTaken = true };
                    var strikePoints = Rule.Create(point,
                                                 entity => entity.HasWicketTaken == true ?
                                                 CalculatePoints.CalculateWicketsPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));

                    //   point = new PlayerStatistics { IsCaughtAndBowled = true };
                    var caughtandBowled = Rule.Create(point,
                                                 entity => entity.IsCaughtAndBowled == true ?
                                                CalculatePoints.CalculateCaughtAndBowledPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));



                    //   point = new PlayerStatistics { IsRunout = false };
                    var runoutPoints = Rule.Create(point,
                                                 entity => entity.IsRunout == true ?
                                                CalculatePoints.CalculateRunoutPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    //  point = new PlayerStatistics { IsStumped = false };
                    var stumpOutPoints = Rule.Create(point,
                                                 entity => entity.IsStumped == true ?
                                                CalculatePoints.CalculateStumpedPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    var maidenOverPoints = Rule.Create(point,
                                                 entity => entity.IsMaidenOver == true ?
                                                CalculatePoints.CalculateMaidenOverPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));



                    var eightWicketsPoints = Rule.Create(point,
                                                 entity => entity.IsEightWickets == true ?
                                                CalculatePoints.CalculateEightWicketsPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    var fourWicketsPoints = Rule.Create(point,
                                                 entity => entity.IsFourWickets == true ?
                                                CalculatePoints.CalculateFourWicketsPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    var halfCenturyWicketsPoints = Rule.Create(point,
                                                 entity => entity.IsHalfCentury == true ?
                                                CalculatePoints.CalculateHalfCenturyPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    var centurysPoints = Rule.Create(point,
                                                 entity => entity.IsCentury == true ?
                                                CalculatePoints.CalculateCenturyPoints(entity, stats) :
                                                      CalculatePoints.FillEmptyPoints(entity));


                    var dismissalOnDuckPoints = Rule.Create(point,
                                              entity => entity.IsDismissalOnDuck == true ?
                                             CalculatePoints.CalculateDissmisalOnDuckPoints(entity, stats) :
                                                   CalculatePoints.FillEmptyPoints(entity));
                    context = new ValidationContext(wicketpoints, strikePoints, caughtandBowled, runoutPoints, stumpOutPoints, maidenOverPoints, eightWicketsPoints, fourWicketsPoints, halfCenturyWicketsPoints, centurysPoints, dismissalOnDuckPoints);

                    var totalPoints = context.GetResults();

                    totalPoints.Where(x => x.PlayerId > 0).ToList().ForEach(x => result.Add(new PlayerMatchStatistics { PlayerId = x.PlayerId, PlayerPoints = x.PlayerPoints }));

                }
                var res = result.GroupBy(x => x.PlayerId, (key, group) => group.First()).ToList();

                foreach (var player in res)
                {
                    using (var tx = this.StateManager.CreateTransaction())
                    {
                        var playerdetail = await playerMatchStatisticsDictionary.TryGetValueAsync(tx, player.PlayerId);

                        ServiceEventSource.Current.ServiceMessage(this.Context, "Current Counter Value: {0}",
                            playerdetail.HasValue ? playerdetail.Value.ToString() : "Value does not exist.");

                        await playerMatchStatisticsDictionary.AddOrUpdateAsync(tx, player.PlayerId, player.PlayerPoints, (key, value) => player.PlayerPoints);

                        // If an exception is thrown before calling CommitAsync, the transaction aborts, all changes are 
                        // discarded, and nothing is saved to the secondary replicas.
                        await tx.CommitAsync();
                    }
                }
                await Task.Delay(TimeSpan.FromMinutes(1));
            }
        }
    }
}
