﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        public class cliente
        {
            string nomb;
            int Total;
            public cliente(string n, int t)
            {
                nomb = n;
                Total = t;
            }

        }
        static void Main(string[] args)
        {
            int A = 0, x = 0, B = 0, C = 0;
            cliente Juan = new cliente("Juan", 5000);
            cliente Maria = new cliente("Maria", 9000);
            cliente Alberto = new cliente("Alberto", 10000);

            //Cliente 1

            Console.WriteLine("El cliente Juan tiene 5000 dolares en el banco\n");
            Console.WriteLine("Que desea hacer\n");
            Console.WriteLine("Depositar (1)");
            Console.WriteLine("Retirar (2)");
            Console.WriteLine("Pasar al siguiente cliente (0)\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("\nCuanto desea depositar\n");
                A = Convert.ToInt32(Console.ReadLine());
                B += A;
            }
            if (x == 2)
            {
                Console.WriteLine("\nCuanto desea retirar");
                Console.WriteLine("(El valor de retiro debe ser inferior a 5000)\n"); 
                A = Convert.ToInt32(Console.ReadLine());
                C += A;

            }
            Console.Clear();

            //Cliente 2

            Console.WriteLine("El cliente Maria tiene 9000 dolares en el banco\n");
            Console.WriteLine("Que desea hacer\n");
            Console.WriteLine("Depositar (1)");
            Console.WriteLine("Retirar (2)");
            Console.WriteLine("Pasar al siguiente cliente (0)\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("\nCuanto desea depositar\n");
                A = Convert.ToInt32(Console.ReadLine());
                B += A;
            }
            if (x == 2)
            {
                Console.WriteLine("\nCuanto desea retirar");
                Console.WriteLine("(El valor de retiro debe ser inferior a 9000)\n");
                A = Convert.ToInt32(Console.ReadLine());
                C += A;
            }
            Console.Clear();

            //Cliente 3

            Console.WriteLine("El cliente Alberto tiene 10000 dolares en el banco\n");
            Console.WriteLine("Que desea hacer\n");
            Console.WriteLine("Depositar (1)");
            Console.WriteLine("Retirar (2)\n");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("\nCuanto desea depositar\n");
                A = Convert.ToInt32(Console.ReadLine());
                B += A;
            }
            if (x == 2)
            {
                Console.WriteLine("\nCuanto desea retirar");
                Console.WriteLine("(El valor de retiro debe ser inferior a 10000)\n");
                A = Convert.ToInt32(Console.ReadLine());
                C += A;
            }
            Console.Clear();

            Console.WriteLine("Se ha depositado " +B+ " dolares del banco\n");
            Console.WriteLine("Se ha retirado " + C + " dolares del banco");
        }
    }
}
