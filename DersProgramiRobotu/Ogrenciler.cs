using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiRobotu
{
    public class Ogrenciler
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }
        public string Sehir { get; set; }
        public double AnneTelefon { get; set; }
        public double BabaTelefon { get; set; }
        public string Modul { get; set; }
        public string OgretmenTercihi { get; set; }
        public string GunTercihi { get; set; }
        public int SaatTercihi { get; set; }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Adı : " +  Ad + "\nSoyadı : "+ Soyad + "\nCinsiyeti : " + Cinsiyet
                + "\nYaşı : " + Yas + "\nŞehir : " + Sehir + "\nAnne Tel : " + AnneTelefon + 
                "\nBaba Tel : " + BabaTelefon + "\nModül : " + Modul + "\nÖğretmen Tercihi : "
                + OgretmenTercihi + "\nGün Tercihi : " + GunTercihi + "\nSaat Tercihi : "
                + SaatTercihi);
        }

    }
}
