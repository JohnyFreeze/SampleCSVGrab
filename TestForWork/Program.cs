using System;
using System.Collections.Generic;

namespace TestForWork
{
    class Program
    {
        //basic program for extracting data from .csv files
        static void Main(string[] args)
        {
            string adresa = @"C:\Users\Johny\Downloads\txt.csv";
            List<List<string>> db = new List<List<string>>(); 
            Io io = new Io();
            Find find = new Find();
            db = io.NactiVstup(adresa);
            string TelCislo;
            do
            {
              Console.WriteLine("Zadejte telefonní číslo:");
              TelCislo = Console.ReadLine();
              find.NajdiVse(db, TelCislo);
            }while(TelCislo != null);
           

            Console.ReadKey();
        }
    }
}
