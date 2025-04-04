using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kalapacsvetes
{
    public class Sportolo
    {
        public string Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Neve { get; set; }
        public string Orszag { get; set; }
        public string Helyszin { get; set; }
        public string Datum { get; set; }
        public Sportolo(string sor)
        {
            string[] darabok = sor.Split(';');
            Helyezes = darabok[0];
            Eredmeny = Convert.ToDouble(darabok[1]);
            Neve = darabok[2];
            Orszag = darabok[3];
            Helyszin = darabok[4];
            Datum = darabok[5];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> lista = new List<Sportolo>();
            StreamReader sr = new StreamReader("kalapacsvetes.txt");
            string elsosor = Console.ReadLine();
            while (!sr.EndOfStream)
            {
                Sportolo sor = new Sportolo(sr.ReadLine());
                lista.Add(sor);
            }
            sr.Close();

            //4. feladat:
            Console.WriteLine($"!.feladat:{lista.Count()} dobas eredmenye talalhato.");
            Console.Read();
        }
    }
}
