﻿using System;

namespace Aulas {
    class Program {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            sbyte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 32443425325L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Marcelo Takayama";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
 
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
        }
    }
}
