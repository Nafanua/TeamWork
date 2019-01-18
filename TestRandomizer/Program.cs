using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            new Randomizer().Start();
        }

        class Randomizer
        {

            public void Start()
            {
                var ThreadBuy = new Thread(Buy);
                var ThreadSell = new Thread(Sell);
                ThreadBuy.Start();
                ThreadSell.Start();


                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey();

                    if (key.Key != ConsoleKey.Escape) continue;
                    ThreadBuy.Interrupt();
                    ThreadSell.Interrupt();
                    Console.WriteLine("Stopped");
                } while (key.Key != ConsoleKey.Escape);

            }

            private static void Buy()
            {
                var rnd = new Random();
                while (true)
                {
                    Console.WriteLine("Buy");
                    Thread.Sleep(rnd.Next(15000));
                }
            }

            private static void Sell()
            {
                var rnd = new Random();
                while (true)
                {
                    Console.WriteLine("Sell");
                    Thread.Sleep(rnd.Next(15000));
                }
            }
        }
    }
}
