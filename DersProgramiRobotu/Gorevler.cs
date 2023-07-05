using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiRobotu
{
    public class Gorevler
    {
        public int ID { get; set; }
        public string ad {get; set; }
        public string girebilecegiModul { get; set; }

        public void Branslar()
        {
            Console.WriteLine("Branş : " + ad + "\nGirebileceği Modüller : " +  girebilecegiModul);
        }
    }
}
