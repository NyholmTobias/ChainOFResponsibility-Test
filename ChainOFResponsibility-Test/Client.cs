using System;
using System.Collections.Generic;

namespace ChainOFResponsibility_Test
{
    class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var bränsle in new List<string> { "Raketbränsle", "El", "Kol" })
            {
                Console.WriteLine($"Klient: Vem vill ha {bränsle}?");

                var result = handler.Handle(bränsle);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {bränsle}? Varför skulle någon vilja ha det?");
                }
            }
        }
    }
}
