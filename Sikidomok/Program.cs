using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "A:1";
            Console.WriteLine(a.ToLower());
            //string alak = Console.ReadLine();
            //switch (alak.ToLower())
            //{
            //    case "kör":
            //        Kor kor = new Kor();
            //        Console.Write("Kérem a kör sugarát: ");
            //        kor.Sugar = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"\nKör területe: {kor.Terulet():N2}\nA kör területe: {kor.Terulet():N2}\nKör átmérője: {kor.Atmero:N2}");
            //        break;

            //    case "téglalap":
            //        Teglalap teglalap = new Teglalap();
            //        Console.Write($"Add meg a téglalap egyik oldalát: ");
            //        teglalap.OldalA = double.Parse(Console.ReadLine());
            //        Console.Write($"Add meg a téglalap másik oldalát: ");
            //        teglalap.OldalB = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"\nA téglalp kerülete {teglalap.Kerulet():N2}\nA téglalap területe: {teglalap.Terulet():N2}");
            //        break;   

            //    case "háromszög":
            //        break;
            //    case "paraleogramma":
            //        break;
            //    case "deltoid":
            //        Deltoid deltoid = new Deltoid();
            //        Console.Write("Deltoid egyik oldala: ");
            //        deltoid.OldalA = double.Parse(Console.ReadLine());
            //        Console.Write("Deltoid másik oldala: oldala: ");
            //        deltoid.OldalB = double.Parse(Console.ReadLine());
            //        Console.Write("A két oldal közbezárt szöge: ");
            //        deltoid.KozbezartSzog = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"\nA deltoid kerülete: {deltoid.Kerulet():N2}\nA deltoid területe: {deltoid.Terulet():N2}");
            //        break;
            //    case "rombusz":
            //        Rombusz rombusz = new Rombusz();
            //        Console.Write("A rombusz oldala: ");
            //        rombusz.OldalA = double.Parse(Console.ReadLine());
            //        Console.Write("A rombusz magassága: ");
            //        rombusz.Magassag = double.Parse(Console.ReadLine());
            //        Console.WriteLine($"A rombusz kerülete: {rombusz.Kerulet()}\nA tombusz területe: {rombusz.Terulte()}");
            //        break;
            //    default:
            //        Console.WriteLine("Hibás alak!");
            //        break;
            //}

            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }
    }
}
