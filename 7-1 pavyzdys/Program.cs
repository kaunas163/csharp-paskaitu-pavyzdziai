﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 2;

            if (skaicius == 1)
                Console.WriteLine("skaicius lygus 1");
            else if (skaicius == 2)
                Console.WriteLine("skaicius lygus 2");
            else if (skaicius == 3)
                Console.WriteLine("skaicius lygus 3");

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("skaicius lygus 1");
                    break;
                case 2:
                    Console.WriteLine("skaicius lygus 2");
                    break;
                case 3:
                    Console.WriteLine("skaicius lygus 3");
                    break;
            }
        }
    }
}
