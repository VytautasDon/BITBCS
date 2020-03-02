using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBCS
{
    public static class PrekiuOperacijos
    {
        public static void PrekesPirkimas(Preke naujaPreke)
        {
            //issaugome duomenu bazeje
            naujaPreke.UnikalusNumeris = Guid.NewGuid();
            PrekesRepository.IdetiNauja(naujaPreke);

        }

        public static List<Preke> PrekiuKatalogas()
        {
            //pasiimame is DB
            return PrekesRepository.GetPrekesKatalogas();
        }

    }
}

