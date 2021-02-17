using System;

namespace ChainOFResponsibility_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // The other part of the client code constructs the actual chain.
            var tesla = new TeslaHandler();
            var raket = new RocketHandler();
            var ångbåt = new SteamboatHandler();

            tesla.SetNext(raket).SetNext(ångbåt);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Kedja: Tesla > Raket > ångbåt\n");
            Client.ClientCode(tesla);
            Console.WriteLine();

            Console.WriteLine("Kedja: Raket > Ångbåt\n");
            Client.ClientCode(raket);

            Console.ReadKey();
        }
    }
}
