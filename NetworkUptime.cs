using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NETWORKLIST;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var manager = new NetworkListManager();
            var connectedNetworks = manager.GetNetworks(NLM_ENUM_NETWORK.NLM_ENUM_NETWORK_CONNECTED).Cast<INetwork>();
            foreach (var network in connectedNetworks)
            {
                if (network.IsConnected)
                {
                    network.GetTimeCreatedAndConnected(out uint _, out uint _, out uint
                    pdwLowDateTimeConnected, out uint pdwHighDateTimeConnected);

                    DateTime networkConnectedTime = DateTime.FromFileTimeUtc((long)
                  (((ulong)pdwHighDateTimeConnected << 32) | pdwLowDateTimeConnected));

                    TimeSpan diff = DateTime.Now.Subtract(networkConnectedTime);

                    Console.WriteLine("Network uptime:" + "\n" + "days: " + diff.Days + "\n" + "hours: " + diff.Hours + "\n" + "minutes: " + diff.Minutes + "\n" + "seconds: " + diff.Seconds + "\n");

                    Console.ReadKey();
                  
                    // Put some condition to evade. Like if X < 30 minutes - exit/terminate/sleep/noise activity...
                }
            }
        }
    }
}
