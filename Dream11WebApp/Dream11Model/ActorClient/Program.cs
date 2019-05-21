using MatchActorService.Interfaces;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using System;

namespace ActorClient
{
    class Program
    {
       public static string ApplicationName = "fabric:/Dream11ServiceFabrics";
        static void Main(string[] args)
        {
          var response =   ActorProxy.Create<IMatchActorService>(ActorId.CreateRandom(), ApplicationName);

          //  Console.WriteLine(response.GetLowerName("SERVICE FABRIC APPLICATION").Result);

            Console.WriteLine(response.GetUpperName().Result);

            Console.WriteLine("Hello World!");
        }
    }
}
