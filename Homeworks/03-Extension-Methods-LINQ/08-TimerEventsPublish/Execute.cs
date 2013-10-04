using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerEventsPublish
{
    class Execute
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth = 100;
            Timer refresh = new Timer();
            Subscriber case1 = new Subscriber("Case 1", refresh);
            int timeInterval = 1;
            // Call the method that raises the event.
            refresh.CallTimer(timeInterval);
        }
    }
}
