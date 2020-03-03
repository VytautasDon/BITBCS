using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBCS
{
    public class meniuSarasai
    {
        
        private List<string> pagrindinisMeniu = new List<string>()
            {
                "Naujos prekes ivedimas",
                "Prekes pirkimas",
                "Prekes pardavimas",
                "Prekes paieska",
                "Prekiu katalogas",
                "Imoniu meniu",
                "Isejimas is programos"
            };
        private List<string> imoniuMeniu = new List<string>()
            {
                "Naujas tiekejas",
                "Naujas klientas",
                "Trinti tiekeja",
                "Trinti klienta",
                "Tiekeju sarasas",
                "Klientu sarasas",
                "Atgal i pagrindini"
            };
        public List<string> GetMainList()
        {
            return pagrindinisMeniu;
        }
        public List<string> GetImoniuMeniu()
        {
            return imoniuMeniu;
        }
    }
}
