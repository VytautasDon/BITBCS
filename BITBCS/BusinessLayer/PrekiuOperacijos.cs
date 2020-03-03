using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBCS
{
    public static class PrekiuOperacijos
    {
        public static void PrekesPridejimas(Preke naujaPreke)
        {
            MenuDraw menu = new MenuDraw();
            List<Imone> imoniuSarasas = new List<Imone>();
            //issaugome duomenu bazeje
            Console.Clear();
            Console.WriteLine("_____PREKES IVEDIMAS_____\n");
            Console.Write("Iveskite prekes pavadinima: ");
            naujaPreke.Pavadinimas = Console.ReadLine();
            Console.Write("Iveskite prekes pirkimo kaina: ");
            naujaPreke.PirkimoKaina = int.Parse(Console.ReadLine());
            Console.Write("Iveskite prekes pardavimo kaina: ");
            naujaPreke.PardavimoKaina = int.Parse(Console.ReadLine());
            Console.Write("Pasirinkite prekes tipa \nTransportoPriemone = 1, Maisto = 2, Laisvalaikio = 3, Sporto = 4 : ");
            naujaPreke.PrekesTipas = (PrekesTipasEnum) int.Parse(Console.ReadLine());
            naujaPreke.UnikalusNumeris = Guid.NewGuid();
            Console.Write("Iveskite sios prekes likuti: ");
            naujaPreke.Likutis = int.Parse(Console.ReadLine());
            imoniuSarasas = ImonesRepository.GetImoniuKatalogas();
            naujaPreke.Tiekejas = imoniuSarasas[pasirinktiTiekeja()].Pavadinimas ;
            PrekesRepository.IdetiNauja(naujaPreke);
        }

        public static List<Preke> PrekiuKatalogas()
        {
            //pasiimame is DB
            return PrekesRepository.GetPrekesKatalogas();
        }

        public static void pirktiPreke()
        {

        }

        public static void parduotiPreke()
        {

        }

        public static void prekesPaieska()
        {
            Console.Write("Iveskite prekes pavadinima ar jo dali: ");
            string fraze = Console.ReadLine();
            List<Preke> fullListas = PrekesRepository.GetPrekesKatalogas();
            foreach (var element in fullListas)
            {
                if (element.Pavadinimas.Contains(fraze))
                {
                    Console.WriteLine($"{element.Pavadinimas}, {element.PrekesTipas}, {element.Tiekejas}, {element.PirkimoKaina}, {element.PardavimoKaina}, {element.Likutis}");
                }
                else
                {
                    Console.WriteLine("Tokia preke nerasta");
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine(" Atgal ");
                Console.ReadLine();
            }
        }

        public static int pasirinktiTiekeja()
        {
            int pasirinkimas;
            MenuDraw pasirinkimai = new MenuDraw();
            do
            {
               pasirinkimas = pasirinkimai.DrawMenuV(ImonesRepository.getImoniuPavadinimus(), "_____PASIRINKITE TIEKEJA_____");
            } while (pasirinkimas <0);
            return pasirinkimas;
        }

    }
}

