﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = 0; 
            int C = 0; 
            int R = 0;
            int S = 0;
            int bank = 0;
            do
            {
                
                Console.WriteLine("\nBuenas bienvenido al cajero del banco FDP INVERSMENTS");
                Console.WriteLine("\nDe que banco desea retirar dinero");
                Console.WriteLine("\nEscriba 1 si desea retirar del banco FDP INVERSMENTS");
                Console.WriteLine("\nEscriba 2 si desea retirar dinero de otro banco");
                Console.WriteLine("\nEscriba 0 si desea Salir");
                bank = Convert.ToInt32(Console.ReadLine());
                if (bank == 1)
                {
                    Console.WriteLine("\nUsted puesde transferir hasta 20,000");
                    Console.WriteLine("\nEscriba cuanto quiere Retirar");
                    R = Convert.ToInt32(Console.ReadLine());
                    if (R <= 20000 && R > 0)
                    {
                        if (R / 10000 == 2)
                        {
                            Console.WriteLine("\nEl cajero dispensa");
                            Console.WriteLine("\n18 billetes de mil");
                            Console.WriteLine("\n2 billetes de quinientos");
                            break;
                        }
                        if (R / 10000 >= 1)
                        {
                            Console.WriteLine("\nEl cajero dispensa");
                            Console.WriteLine("\n10 billetes de mil");
                            if (R % 10000 != 0)
                            S = R;
                            R -= 10000;
                            R /= 1000;
                            Q = R * 2;
                            R = S;
                            if (R % 1000 != 0 && R != 19000)
                            {
                                R -= 10000;
                                if (R % 200 == 0)
                                {
                                    C = R / 200;
                                    Console.WriteLine("\n" + C + " billetes de Docientos");
                                }
                                else
                                {
                                    C = R / 100;
                                    Console.WriteLine("\n" + C + " billetes de cien");
                                }

                            }
                            if (Q != 0)
                            {
                                Console.WriteLine("\n" + Q + " billetes de quinientos");

                            }
                            
                            if (S > 19000)
                            {
                                R = S;
                                Console.WriteLine(R);
                                R -= 19000;
                                C = R / 100;
                                Console.WriteLine("\n" + C + " billetes de cien");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo se puede retiara esa cantidad");
                        Console.WriteLine("\nintente de nuevo");
                    }

                }
                if (bank == 2)
                {
                    Console.WriteLine("\nUsted puesde transferir hasta 10,000");
                    Console.WriteLine("\nEscriba cuanto quiere Retirar");
                    R = Convert.ToInt32(Console.ReadLine());
                    if (R == 10000)
                    {
                        Console.WriteLine("\nEl cajero dispensa");
                        Console.WriteLine("\n10 billetes de mil");
                    }
                    else if (R > 9999 )
                    {
                        S = R;
                        R /= 1000;
                        Console.WriteLine("\nEl cajero dispensa");
                        Console.WriteLine("\n" + R + " billetes de mil");
                        if (S % 1000 != 0)
                        {
                            R = S;
                            R %= 1000;
                            if (R % 200 == 0)
                            {
                                C = R / 200;
                                Console.WriteLine("\n" + C + " billetes de Docientos");
                            }
                            else
                            {
                                C = R / 100;
                                Console.WriteLine("\n" + C + " billetes de cien");
                            }
                        }
                    }
                    else if (R < 1000 && R > 99)
                    {
                        if (R % 200 == 0)
                        {
                            C = R / 200;
                            Console.WriteLine("\n" + C + " billetes de Docientos");
                        }
                        else
                        {
                            C = R / 100;
                            Console.WriteLine("\n" + C + " billetes de cien");
                        }
                    }
                    else if (R == 0)
                    {
                        Console.WriteLine("\nNo se puede retiara esa cantidad");
                        Console.WriteLine("\nintente de nuevo");
                    }
                    else if (R != 10000)
                    {
                        Console.WriteLine("\nNo se puede retiara esa cantidad");
                        Console.WriteLine("\nintente de nuevo");
                    }
                } 
            } while (bank != 0);
            

        }
    }
}
