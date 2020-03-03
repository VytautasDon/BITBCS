using System;
using System.Collections.Generic;
using System.Text;

namespace BITBCS
{
    public class ImonesRepository
    {
        private static List<Imone> _imones = new List<Imone>();
        
        public static void IdetiNauja(Imone imone)
        {  
            if (_imones.Exists(x => x.Pavadinimas == imone.Pavadinimas))
            {
                throw new Exception("Tokia imone siuo pavadinimu jau egzistuoja");
            }

            _imones.Add(imone);
        }

        public static List<Imone> GetImoniuKatalogas()
        {
            return _imones;
        }

        public static List<string> getImoniuPavadinimus()
        {
            List<string> pavadinimuSarasas = new List<string>();
            foreach (var element in _imones)
            {
                pavadinimuSarasas.Add(element.Pavadinimas);
            }
            return pavadinimuSarasas;
        }
    }
}
