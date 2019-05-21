using Microsoft.ServiceFabric.Data;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceFabric.Mocks;
using ServiceFabric.Mocks.ReplicaSet;
using System;
using System.Fabric;
using System.Threading;
using System.Threading.Tasks;

namespace Dream11StatelessServiceUnitTest
{
    [TestClass]
    public class Dream11ServiceTest
    {

        [TestMethod]
        public async Task TestServiceState_InMemoryState_PromoteActiveSecondary()
        {
            var stateManager = new MockReliableStateManager();
            //service factory to instruct how to create the service instance
            Func<StatefulServiceContext,IReliableStateManagerReplica2,UserStatefulService.UserStatefulService> serviceFactory = (StatefulServiceContext context, IReliableStateManagerReplica2 stateManager1) => new UserStatefulService.UserStatefulService(context);
                     var replicaSet = new MockStatefulServiceReplicaSet<UserStatefulService.UserStatefulService>(serviceFactory);
            await replicaSet.AddReplicaAsync(ReplicaRole.Primary, 1);
            await replicaSet.AddReplicaAsync(ReplicaRole.ActiveSecondary, 2);
            await replicaSet.AddReplicaAsync(ReplicaRole.ActiveSecondary, 3);

            const string stateName = "test";
           // var payload = new Payload(StatePayload);

            //insert data
            CancellationToken token = new CancellationToken(false);
            await replicaSet.Primary.ServiceInstance.InvokeRunAsync(token);
            //promote one of the secondaries to primary
            await replicaSet.PromoteActiveSecondaryToPrimaryAsync(2);
            //get data
        //    var payloads = (await replicaSet.Primary.ServiceInstance.Context.()).ToList();

            //data should match what was inserted against the primary
          //  Assert.IsTrue(payloads.Count == 1);
          //  Assert.IsTrue(payloads[0].Content == payload.Content);

            //verify the data was saved against the reliable dictionary
            //var dictionary = await StateManager.GetOrAddAsync<IReliableDictionary<string, Payload>>(MyStatefulService.StateManagerDictionaryKey);
            //using (var tx = StateManager.CreateTransaction())
            //{
            //    var payload = await dictionary.TryGetValue(stateName);
            //    Assert.IsTrue(payload.HasValue);
            //    Assert.IsTrue(payload.Value.Content == payload.Content);
            //}
        }
       private UserStatefulService.UserStatefulService CreateMyStatefulService(StatefulServiceContext context, IReliableStateManagerReplica2 stateManager)
        {
          return  new UserStatefulService.UserStatefulService(context);
        }
    }
}
