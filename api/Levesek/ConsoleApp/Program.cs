using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis(); //adatbázis constructor-át meghívjuk
        static List<Leves> levesek = new List<Leves>(); //lista létrehozása az adatok felvételéhez --> inicializálás
        static void Main(string[] args)
        {
            beolvasas();
            feladat1();
            feladat2();
            Console.WriteLine("\nProgram vége");
            Console.ReadLine();
        }

        private static void feladat2()
        {
            Console.WriteLine("2. feladat:");
            Leves maxKaloria = levesek.Find(a => a.kaloria == levesek.Max(b => b.kaloria));
            Console.WriteLine($"\t A legmagasabb kalória tartalmú leves neve: {maxKaloria.megnevezes} {maxKaloria.kaloria} kalória");
        }

        private static void feladat1()
        {
            Console.WriteLine("1. feladat: ");
            Console.WriteLine($"\tLevesek száma: {levesek.Count}");
        }

        private static void beolvasas()
        {
            levesek.Clear();
            levesek=db.getLevesek();
        }
    }
}
