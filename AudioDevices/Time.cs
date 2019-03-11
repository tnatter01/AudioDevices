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
            // Bereken het aantal uren
            this.hours = seconds / 3600;
            // Bereken aantal seconden dat overblijft
            int remainder = seconds % 3600;
            // Berken aantal minuten
            this.minutes = remainder / 60;
            // Bereken aantal seconden
            this.seconds = remainder % 60;
        }

        public Time(int minutes, int seconds) : this(minutes * 60 + seconds)
        {

        }

        //TODO: Voeg de derde constructor zelf toe

        public override string ToString()
        {
            string timeString = "";
            timeString += hours < 10 ? "0" + hours : hours.ToString();
            timeString += ":";
            timeString += minutes < 10 ? "0" + minutes : minutes.ToString();
            timeString += ":";
            timeString += seconds < 10 ? "0" + seconds : seconds.ToString();
            return timeString;
        }

        // Property die het aantal seconden terug geeft
        public int Seconds
        {
            get
            {
                return this.hours * 3600 + this.minutes * 60 + this.seconds;
            }
        }

        public int GetSeconds()
        {
            return this.hours * 3600 + this.minutes * 60 + this.seconds;

        }

    }
}