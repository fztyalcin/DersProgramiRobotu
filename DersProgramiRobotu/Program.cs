using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiRobotu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Egitmenler fizyoterapist1 = new Egitmenler();
            fizyoterapist1.Ad = "Yalçın";
            fizyoterapist1.Soyad = "Oruç";
            fizyoterapist1.EPosta = "fzt.yalcin@gmail.com";
            fizyoterapist1.Cinsiyet = "Erkek";
            fizyoterapist1.Gorevi = "Fizyoterapist";
            fizyoterapist1.Telefon = 05062549241;

            Console.WriteLine("Eğitmen Bilgileri\n");
            

            fizyoterapist1.Egitmen();

            Ogrenciler ogrenci1 = new Ogrenciler();
            ogrenci1.Ad = "Ahmet Tuna";
            ogrenci1.Soyad = "Bayram";
            ogrenci1.Cinsiyet = "Erkek";
            ogrenci1.Yas = 11;
            ogrenci1.Sehir = "Çorum";
            ogrenci1.AnneTelefon = 05312345678;
            ogrenci1.BabaTelefon = 05312345678;
            ogrenci1.Modul = "Bedensel";
            ogrenci1.OgretmenTercihi = "Yalçın";
            ogrenci1.GunTercihi = "Perşembe Cumartesi";
            ogrenci1.SaatTercihi = 18;

            Console.WriteLine("\n******************************\n\nÖğrenci Bilgileri\n");

            ogrenci1.OgrenciBilgileri();

            Console.WriteLine();

            Gorevler gorev1 = new Gorevler();
            gorev1.ad = "Fizyoterapist";
            gorev1.girebilecegiModul = "Bedensel";

            Console.WriteLine("\n******************************\n\nBranş Bilgileri\n");

            gorev1.Branslar();
            Console.WriteLine();

           

            Moduller modul1 = new Moduller();
            modul1.Ad = "Bedensel";
            modul1.Brans = "Fizyoterapist";

            Console.WriteLine("\n******************************\n\nModül Bilgileri\n");
            modul1.ModulYaz();
            Console.WriteLine();

            //Günleri Dizi Halinde Tanımladım
            string[] Gunler = new string[5];
            Gunler[0] = "Salı";
            Gunler[1] = "Çarşamba";
            Gunler[2] = "Perşembe";
            Gunler[3] = "Cuma";
            Gunler[4] = "Cumartesi";

            Console.WriteLine("******************************\n\nÇalışma Günleri\n");
            foreach (string g in Gunler)
            {
                Console.WriteLine(g);
                
            }
            Console.WriteLine();

            //Saatleri Dizi Halinde Tanımladım
            int[] Saatler = new int[8];
            Saatler[0] = 10;
            Saatler[1] = 11;
            Saatler[2] = 12;
            Saatler[3] = 14;
            Saatler[4] = 15;
            Saatler[5] = 16;
            Saatler[6] = 17;
            Saatler[7] = 18;

            Console.WriteLine("******************************\n\nÇalışma Saatleri\n");
            foreach (int s in Saatler)
            {
                Console.WriteLine("Saat "+ s + " Seansı");
            }
         
            Console.ReadLine();


        }
    }
}
