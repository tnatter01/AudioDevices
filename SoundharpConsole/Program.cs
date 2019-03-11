using AudioDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maak een track aan
            Track t1 = new Track();
            // Maak een time aan
            Time time1 = new Time(400);
            // Voeg de tijd toe aan de track
            t1.Length = time1;
            // Stel de stijl in
            t1.Type = Category.Hardcore;
            // Voeg nog 3 tracks toe met behulp van verschillende
            // constructors
            Track t2 = new Track(2);
            Track t3 = new Track(3, "Yellow");
            Track t4 = new Track(4, "Draait om", "Boef");

            TrackList tl1 = new TrackList();
            tl1.Add(t1);
            tl1.Add(t2);
            tl1.Add(t3);
            tl1.Add(t4);
            List<Track> shuffled = tl1.Shuffle();
            Console.WriteLine("De tracklist telt {0} nummers en duurt {1}",
                tl1.Count, tl1.TotalTime.ToString());
            Console.ReadKey();
        }
    }
}
