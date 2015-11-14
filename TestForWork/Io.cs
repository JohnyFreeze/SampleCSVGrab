using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestForWork
{
   
    class Io
    {
        public static List<string> Kategorie = new List<string>();
        public List<List<string>> NactiVstup(string cesta)
        {
            int pocetRadku = 0;
            using (StreamReader sr = new StreamReader(cesta))
            {
               while(sr.ReadLine() != null)
                {
                    pocetRadku++;
                }        
            }
           
            using (StreamReader sr = new StreamReader(cesta))
            {
                var radek = sr.ReadLine();

                if(radek != null)
                {
                    string[] sloupce = radek.Split(';');
                    foreach(string wholeWord in sloupce)
                    {
                        string item = wholeWord; 
                        item = item.Replace("\"", "");
                        item = item.Replace(".", ",");
                        Kategorie.Add(item);
                    }
                   
                    List<List<string>> data = new List<List<string>>();
                    //can refactoring here
                    //can just one loop
                    for (int i = 0; i < pocetRadku - 1; i++)
                    {
                        radek = sr.ReadLine();
                        if(radek != null) sloupce = radek.Split(';');
                        List<string> db = sloupce.Select(item => item.Replace("\"" , "")).ToList();
                        data.Add(db);
                    }                  
                    return data;
                }
                return null;
            }
           
        }
    }
}
