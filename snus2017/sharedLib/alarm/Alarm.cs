using System;

namespace sharedLib
{
    public class Alarm
    {
        private string message;
        public string Message { get => message; }
        private DateTime dateTime;
        public DateTime DateTime { get => dateTime; }
        private string unit;
        public string Unit { get => unit; }



        public Alarm(string message, string unit, DateTime dateTime)
        {
            this.message = message;
            this.dateTime = dateTime;
            this.unit = unit;
        }
    }
}
