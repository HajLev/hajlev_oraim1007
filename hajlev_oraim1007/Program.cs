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
        static char[] inf = "INFORMATIKA".ToCharArray();
        
        static void Main(string[] args)
        {

            feltolt();
            kiir();
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < 1000; i++)
            {
                RandomSin();
                RandomHelyreIr();
            }
             Console.WriteLine();
           

            Console.ReadKey();
            Console.Clear();

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(RandomChar());
            //}

            Console.WriteLine(RandomJelszo());

            Kever();
            Console.WriteLine(new String(inf));

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

        // 5. fealdat

        //enum dolgok {
        //    Szanko = 30,
        //    Mikulas = 40,
        //    Szarvas = 50,
        //}


        static void RandomSin() {

            Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

            //ConsoleColor[] szinek =
            //{
            //    ConsoleColor.Red,
            //    ConsoleColor.Yellow,
            //    ConsoleColor.Blue,
            //    ConsoleColor.Cyan,
            //    ConsoleColor.Magenta,
            //    ConsoleColor.DarkCyan,
            //    ConsoleColor.Gray,
            //    ConsoleColor.DarkGreen,
            //};
            //Console.ForegroundColor = szinek[rnd.Next(szinek.Length)];
        }

        static char RandomChar()
        {
            return (char)rnd.Next(65, 91);
        }

        static string RandomJelszo()
        {
            string pw = "";
            for (int i = 0; i < 6; i++)
            {
                pw += RandomChar();
            }
            return pw;
        }



        static void Kever()
        {
            for (int i = 0; i < inf.Length / 2; i++)
            {
                int x = rnd.Next(inf.Length);
                int y = rnd.Next(inf.Length);

                char s = inf[x];
                inf[x] = inf[y];
                inf[y] = s;
            }
        }




    }
}
