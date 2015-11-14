using System;
using System.Collections.Generic;

namespace TestForWork
{
    class Find
    {
        public void NajdiVse(List<List<string>> db, string qoute)
        {
            double celkem = 0;
            foreach (List<string> radek in db)
            {
                if (radek[3] == qoute)
                {
                    string b = radek[6];
                    if (b != "-0" || b != "0")
                    {
                        string c = b;
                        c = c.Replace(".", ",");
                        double a;
                        double.TryParse(c, out a);
                        celkem += a;
                    }
                }
           
            }
            Console.Write("Celková cena k úhradě:");
            Console.WriteLine(celkem + " Kč");
        }
    }
}
