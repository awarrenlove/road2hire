using System;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading;

namespace bell_timer
{
    class Program
    {
        static int Interval { get; set; } = 1000;

        static int Length { get; set; } = 3;

        static void Tick(object source, ElapsedEventArgs e)
        {
            for (var i = 0;i < Length;i++)
            {
                Console.Write("\a\b");
                Thread.Sleep(150);
            }
        }

        static void Main(string[] args)
        {
            var timer = new Timer();

            timer.Elapsed += Tick;
            timer.Interval = Interval;
            timer.Enabled = true;

            Console.ReadKey();
        }
    }
}
