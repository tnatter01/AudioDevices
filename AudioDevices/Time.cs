using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices
{
    public struct Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int seconds)
        {
            //Bereken het aantal uren
            this.hours = seconds / 3600;
            //Bereken het aantal seconden dat overblijft
            int remainder = seconds % 3600;
            //Bereken het aantal minuten
            this.minutes = remainder / 60;
            //Bereken het aantal seconden
            this.seconds = remainder % 60;
        }

        public Time(int minutes, int seconds):this(minutes  * 60 + seconds)
        {
        }
        
        public Time(int hours, int minutes, int seconds):this(hours * 3600 + minutes * 60 + seconds)
        {
        }
    }
}