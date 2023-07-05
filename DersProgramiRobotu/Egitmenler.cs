using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiRobotu
{
    public class Egitmenler
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Gorevi { get; set; }
        public decimal Telefon { get; set; }
        public string EPosta { get; set; }


        public void Egitmen() 
        {
            Console.WriteLine("Adı : " +  Ad + "\nSoyadı : " + Soyad + "\nCinsiyet : " + 
                Cinsiyet + "\nGörevi : " + Gorevi + "\nTelefon : " + Telefon + 
                "\ne-Posta : " + EPosta);
        }
    }
}
