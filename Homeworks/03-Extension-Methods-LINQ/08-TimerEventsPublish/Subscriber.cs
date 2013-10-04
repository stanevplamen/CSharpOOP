using System;
using System.Collections.Generic;

namespace TimerEventsPublish
{
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Timer pub)
        {
            id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
        }
    }
}
