using System;
using System.Timers;

namespace SpaceShuttle
{
    class Program
    {
        public static int i = 10;
        public static Timer timer = new Timer();

        static void Main(string[] args)
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            Console.WriteLine("Запускаем");
            timer.Start();

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(i);
            if(i == 0)
            {
                timer.Stop();
                Console.WriteLine("ПОЛЕТЕЛИИИИИИИИИИИИИИИИИИИ!!!!!!!!!!!!!!");
                Console.Beep(500, 10000);
            }

            i--;
        }
    }
}
