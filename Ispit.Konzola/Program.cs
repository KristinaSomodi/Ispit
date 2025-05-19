using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik ucenik1 = new Ucenik()
            {
                Ime = "Luka",
                Prezime = "Lukic",
                DatumRodjenja = new DateTime(2000, 5, 23),
                Prosjek = 1.55
            };
            Ucenik ucenik2 = new Ucenik()
            {
                Ime = "Mia",
                Prezime = "Mijic",
                DatumRodjenja = new DateTime(1998, 2, 15),
                Prosjek = 3.22
            };
            Ucenik ucenik3 = new Ucenik()
            {
                Ime = "Luka",
                Prezime = "Mijic",
                DatumRodjenja = new DateTime(1995, 9, 4),
                Prosjek = 4.33
            };

            Console.WriteLine($"Ime: {ucenik1.Ime}");
            Console.WriteLine($"Prezime: {ucenik1.Prezime}");
            Console.WriteLine($"Datum rodjenja: {ucenik1.DatumRodjenja}");
            Console.WriteLine($"Prosjek: {ucenik1.Prosjek}");

            Console.WriteLine($"Ime: {ucenik2.Ime}");
            Console.WriteLine($"Prezime: {ucenik2.Prezime}");
            Console.WriteLine($"Datum rodjenja: {ucenik2.DatumRodjenja}");
            Console.WriteLine($"Prosjek: {ucenik2.Prosjek}");

            Console.WriteLine($"Ime: {ucenik3.Ime}");
            Console.WriteLine($"Prezime: {ucenik3.Prezime}");
            Console.WriteLine($"Datum rodjenja: {ucenik3.DatumRodjenja}");
            Console.WriteLine($"Prosjek: {ucenik3.Prosjek}");

            Console.ReadKey();
        }
    }
}
