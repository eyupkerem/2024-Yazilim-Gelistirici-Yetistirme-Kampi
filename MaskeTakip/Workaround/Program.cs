using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{ 
    public class Program
    {

        static void Main(string[] args)
        {
            SelamVer("Engin");
            SelamVer();
            Topla();

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Selim";

            //ogrenciler = new string[4];
            //ogrenciler[3] = "Seçkin";

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //foreach (string s in ogrenciler)
            //{
            //    Console.WriteLine(s);
            //}

            List<string> yeniSehirler = new List<string> { "Ankara", "İstnabul", "Sakarya" };
            yeniSehirler.Add("İzmir");

            foreach (var sehir in yeniSehirler)
            {
                 Console.WriteLine(sehir);
            }

            Person person1=new Person();
            person1.FirstName = "A";
            person1.LastName = "B";
            person1.DateOfBirthYear = 1998;
            person1.NationalityIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "C";
            person2.LastName = "D";
            person2.DateOfBirthYear = 1999;
            person2.NationalityIdentity = 456;

            PttManager pttManager = new (new PersonManager());
            pttManager.GiveMask(person1);

        }
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1=7,int sayi2 = 5)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
