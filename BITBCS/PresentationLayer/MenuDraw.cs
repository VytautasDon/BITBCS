using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITBCS
{
    class MenuDraw
    {
        private int index = 0;


        public int DrawMenuV(List<string> meniu, string pavadinimas)
        {

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine(pavadinimas);
            Console.WriteLine();
            for (int i = 0; i < meniu.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" " + meniu[i]);
                }
                else
                {
                    Console.WriteLine(" " + meniu[i]);
                }
                Console.BackgroundColor = ConsoleColor.Gray;
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == meniu.Count - 1)
                {
                    //index = 0; //Persokimas i virsutini meniu pasirinkima
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = items.Count - 1; //Persokimas i apatini meniu pasirinkima
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                if (meniu[index] == "Isejimas is programos")
                {
                    Environment.Exit(0);
                }
                else if (meniu[index] == "Atgal i pagrindini")
                {
                    return -10;
                }
                int indextmp = index;
                index = 0;
                return indextmp;
            }
            else
            {
                return -1;
            }
            return -1;
        }
    }
}
