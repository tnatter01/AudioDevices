using AudioDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Track t1 = new Track();
            Time time1 = new Time(400);
            t1.Length = time1;
            t1.Type = Category.HipHop;
            Track t2 = new Track(2);
            Track t3 = new Track(3, "Yellow");
            Track t4 = new Track(4, "Jargon", "Snelle");
        }
    }
}