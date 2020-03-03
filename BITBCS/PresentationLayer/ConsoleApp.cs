using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BITBCS
{
    public class ConsoleApp
    {
        private bool isStarted = false;
        public ConsoleApp()
        {
            if (isStarted)
            {
                throw new Exception("Programa jau paleista");
            }
            isStarted = true;
        }

        public void Start()
        {
            Console.CursorVisible = false;
            meniuSarasai navSarasai = new meniuSarasai();
            Imone test1 = new Imone();
            Imone test2 = new Imone();
            test1.Pavadinimas = "Testine Imone1";
            test2.Pavadinimas = "Testine Imone2";
            ImonesRepository.IdetiNauja(test1);
            ImonesRepository.IdetiNauja(test2);
            MenuDraw meniu = new MenuDraw();
            int pasirinkimas = 0;
            while (true)
            {
                do
                {
                    pasirinkimas = meniu.DrawMenuV(navSarasai.GetMainList(), "_____PAGRINDINIS MENIU_____");
                } while (pasirinkimas < 0);

                switch (pasirinkimas)
                {
                    case 0:
                        PrekesIvedimas();
                        break;
                    case 1:
                        //pirkimas
                        break;
                    case 2:
                        //pardavimas
                        break;
                    case 3:
                        Console.Clear();
                        PrekiuOperacijos.prekesPaieska();
                        break;
                    case 4:
                        PrekiuKatalogas();
                        break;
                    case 5:
                        while (true)
                        {
                        pasirinkimas = meniu.DrawMenuV(navSarasai.GetImoniuMeniu(), "_____IMONIU MENIU_____");
                            if (pasirinkimas ==-10)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private void PrekesIvedimas()
        {
            var naujaPreke = new Preke();
            PrekiuOperacijos.PrekesPridejimas(naujaPreke);
        }
        private void imoniuMeniu()
        {
            var naujaPreke = new Preke();
            PrekiuOperacijos.PrekesPridejimas(naujaPreke);
        }

        private void PrekiuKatalogas()
        {
            Console.Clear();
            Console.WriteLine("-------Prekiu Katalogas----------");
            foreach (var preke in PrekiuOperacijos.PrekiuKatalogas())
            {

                var pType = preke.GetType();
                var props = pType.GetProperties();
                foreach (PropertyInfo prp in props)
                {
                    string propertyName = prp.Name;
                    string propertyValue = prp.GetValue(preke, new object[] { }).ToString();
                    Console.Write(propertyName + ": " + propertyValue + ";  ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine(" Atgal ");
            Console.ReadLine();
        }


    }
}



