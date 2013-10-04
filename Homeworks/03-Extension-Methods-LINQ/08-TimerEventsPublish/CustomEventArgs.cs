﻿using System;

namespace TimerEventsPublish
{
    public class CustomEventArgs : EventArgs
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public CustomEventArgs(string s)
        {
            message = s;
        }
    }
}
