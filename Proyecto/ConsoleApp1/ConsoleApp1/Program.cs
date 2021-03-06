﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Plazo;
            double Prestamo, Tasa;

            Console.WriteLine("CALCULADORA DE PRÉSTAMOS\n");
            Console.WriteLine("Para hacer una simulacion de prestamo tiene");
            Console.WriteLine("que proporcionar la siguiente informacion:\n");

            Console.WriteLine("Monto de prestamo:\n");
            Prestamo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlaso de pago (En meses):\n");
            Plazo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTasa de interes:");
            Console.WriteLine("No escriba el numero con (%)\n");
            Tasa = Convert.ToDouble(Console.ReadLine());
            Tasa /= 100;
            Console.Clear();

            Amortizacion(Prestamo, Tasa, Plazo);

            Console.WriteLine("\nPrecione cualquier tecla para salir\n");
            Console.ReadKey();
        }

        static void Amortizacion(double Prestamo, double Tasa, int Plazo)
        {
            double Cuota, Interes, Capital, Balance;

            DateTime fecha = new DateTime(2021, 4, 20);

            Cuota = (Tasa * Prestamo) / (1 - Math.Pow(1 + Tasa, -Plazo));
            Cuota = Math.Round(Cuota, 2);

            Interes = Prestamo * Tasa;
            Interes = Math.Round(Interes, 2);

            Capital = Cuota - Interes;
            Capital = Math.Round(Capital, 2);

            Balance = Prestamo - Capital;
            Balance = Math.Round(Balance, 2);

            Console.WriteLine("Monto del prestamo en RD$:  "+ Prestamo);
            Console.WriteLine("Tasa de Interes:            "+ Tasa*100+"%");
            Console.WriteLine("Plazo de pago:              "+ Plazo+" meses\n");

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Pago");

            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Fecha de pago");

            Console.SetCursorPosition(27, 4);
            Console.WriteLine("Cuota");

            Console.SetCursorPosition(38, 4);
            Console.WriteLine("Capital");

            Console.SetCursorPosition(50, 4);
            Console.WriteLine("Interes");

            Console.SetCursorPosition(61, 4);
            Console.WriteLine("Balance");
                

            for (int i = 1; i < Plazo+1 ; i++)
            {
                if(Balance < 1)
                {
                    Balance = 0;
                }
                Console.SetCursorPosition(1, 5+i);
                Console.WriteLine(i);

                Console.SetCursorPosition(27, 5 + i);
                Console.WriteLine(Cuota);

                Console.SetCursorPosition(11, 5 + i);
                Console.WriteLine(fecha.AddMonths(i).ToString("dd-MM-yyyy"));

                Console.SetCursorPosition(38, 5 + i);
                Console.WriteLine(Capital);

                Console.SetCursorPosition(50, 5 + i);
                Console.WriteLine(Interes);

                Console.SetCursorPosition(61, 5 + i);
                Console.WriteLine(Balance);

                Interes = Balance * Tasa;
                Interes = Math.Round(Interes, 2);
                Capital = Cuota - Interes;
                Capital = Math.Round(Capital, 2);
                Balance -= Capital;
                Balance = Math.Round(Balance, 2);

            }

        }

    }
}