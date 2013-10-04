using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TimerDelegate
{
    public delegate void TimerCall(string param);

    public class Timer
    {
        private static Stopwatch sw = new Stopwatch();

        static void CallMethod(string param)
        {
            Console.WriteLine(param);
        }

        static void Main()
        {
            TimerCall d = new TimerCall(CallMethod);
            int timeInterval = 1;

            sw.Start();
            while (true)
            {
                if (sw.Elapsed.Seconds >= timeInterval)
                {
                    sw.Restart();
                    d("called - the function is executing");
                }
                Thread.Sleep(90);
            }
        }
    }
}
