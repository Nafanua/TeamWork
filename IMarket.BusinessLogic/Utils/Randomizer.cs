using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace IMarket.BusinessLogic.Utils
{
    class Randomizer
    {

        public void Start()
        {
            var threadBuy = new Thread(Buy);
            var threadSell = new Thread(Sell);
            threadBuy.Start();
            threadSell.Start();

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();

                if (key.Key != ConsoleKey.Escape) continue;
                threadBuy.Interrupt();
                threadSell.Interrupt();
            } while (key.Key != ConsoleKey.Escape);

        }

        private static void Buy()
        {
            var rnd = new Random();
            while (true)
            {
                Thread.Sleep(rnd.Next(15000));
            }
        }

        private static void Sell()
        {
            var rnd = new Random();
            while (true)
            {
                Thread.Sleep(rnd.Next(15000));
            }
        }
    }
}
