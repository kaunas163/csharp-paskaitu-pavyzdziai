﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var kiekis = 0;
            var suma = 0;

            while (kiekis <= 10)
            {
                var skaicius = rand.Next(1, 100);
                Console.Write(skaicius);

                if (skaicius % 2 == 0)
                {
                    suma += skaicius;
                    Console.Write(" lyginis");
                }

                Console.WriteLine();
                kiekis++;
            }

            Console.WriteLine("lyginiu skaiciu suma: " + suma);
        }
    }
}
