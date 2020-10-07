using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajlev_oraim1007
{
    class Program
    {
        static Random rnd = new Random();
        static int[] tomb = new int[100];
        
        static void Main(string[] args)
        {


            feltolt();
            kiir();
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < 100; i++)
            {
                RandomHelyreIr();
            }
             Console.WriteLine();
           

            Console.ReadKey();
            Console.Clear();
        }
        
        //1 2 3 feladat
        static void feltolt(){
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(10, 100);
            }

        }

        static void kiir() {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
                if ((i + 1) % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
        }



        //4.feladat??
        static void RandomHelyreIr() {
            Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight)
                ) ;
            Console.Write("*");
        }
        




    }
}
