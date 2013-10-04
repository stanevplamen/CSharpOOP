using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TimerEventsPublish
{
    class Timer
    {
        private static Stopwatch sw = new Stopwatch();

        // Declare the event using EventHandler<T> 
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void CallTimer(int timeInterval)
        {
            sw.Start();
            while (true)
            {
                if (sw.Elapsed.Seconds >= timeInterval)
                {
                    sw.Restart();
                    OnRaiseCustomEvent(new CustomEventArgs("called - the function has been executed"));
                }
                Thread.Sleep(100);
            }
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            if (handler != null)
            {
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                handler(this, e);
            }
        }
    }
}
