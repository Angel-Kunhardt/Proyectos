using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class producto
    {
        public string name;
        public int precio;
        public int cantidad;

        public producto(string n, int p, int c)
        {
            name = n;
            precio = p;
            cantidad = c;
        }
        public void venta()
        {
            cantidad -= 1;
        }
        public void Informe(string[] name, int [] stock)
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name[i]+" Quedan "+stock[i]+"\n");
            }
            Console.WriteLine("Precione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Crear una aplicacion que simule una maquina dispensadora de alimentos
            //Debe tener un maximo de 10 productos y solo debe aceptar monedas de (5,10,25)
            //y billetes (50,100 y 200 )
            
            int A = 0, X,Y,B=0,D;
            string[] name = { "Cocacola", "Pepsi", "PepsiMax","Sprite", "Malta", "Colareal", "Redrock", "Countryclub", "Sevenup", "Gatorade" };
            int[] stock = {10,10, 10, 10, 10, 10, 10, 10, 10, 10 };
            producto Cocacola = new producto("Cocacola", 50, 10);
            producto Pepsi = new producto("Pepsi", 25, 10);
            producto PepsiMax = new producto("PepsiMax", 100, 10);
            producto Sprite = new producto("Sprite", 25, 10);
            producto Malta = new producto("Malta", 100, 10);
            producto Colareal = new producto("Colareal", 25, 10);
            producto Redrock = new producto("Red Rock", 25, 10);
            producto Countryclub = new producto("Country Club", 25, 10);
            producto Sevenup = new producto("SevenUP", 25, 10);
            producto Gatorade = new producto("Gatorade", 200, 10);
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido que desea:\n");
                Console.WriteLine("(1) Comprar");
                Console.WriteLine("(2) Revisar el informe de ventas");
                Console.WriteLine("(0) Salir\n");
                A = Convert.ToInt32(Console.ReadLine());
                switch (A)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("****************************************************");
                        Console.WriteLine("Esta maquina solo acepta monedas de 5 ,10 y 25");
                        Console.WriteLine("Esta maquina solo acepta billetes de 50 ,100 y 200");
                        Console.WriteLine("****************************************************\n");
                        Console.WriteLine("Bienvenido que desea:\n");
                        Y = 0;
                        B = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write("(" + i + ") " + name[i] + "\n");
                        }
                        X = Convert.ToInt32(Console.ReadLine());
                        if (X == 0)
                        {
                            if (Cocacola.cantidad != 0)
                            {
                                Cocacola.venta();
                                stock[X] = Cocacola.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Cocacola.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Cocacola.precio)
                                {
                                    while (B < Cocacola.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;
                                        
                                    } 
                                    D = B - Cocacola.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                    
                                }
                                if (B >= Cocacola.precio)
                                {
                                    D = B - Cocacola.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 1)
                        {
                            if (Pepsi.cantidad != 0)
                            {
                                Pepsi.venta();
                                stock[X] = Pepsi.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Pepsi.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Pepsi.precio)
                                {
                                    while (B < Pepsi.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Pepsi.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Pepsi.precio)
                                {
                                    D = B - Pepsi.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 2)
                        {
                            if (PepsiMax.cantidad != 0)
                            {
                                PepsiMax.venta();
                                stock[X] = PepsiMax.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + PepsiMax.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != PepsiMax.precio)
                                {
                                    while (B < PepsiMax.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - PepsiMax.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= PepsiMax.precio)
                                {
                                    D = B - PepsiMax.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 3)
                        {
                            if (Sprite.cantidad != 0)
                            {
                                Sprite.venta();
                                stock[X] = Sprite.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Sprite.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Sprite.precio)
                                {
                                    while (B < Sprite.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Sprite.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Sprite.precio)
                                {
                                    D = B - Sprite.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 4)
                        {
                            if (Malta.cantidad != 0)
                            {
                                Malta.venta();
                                stock[X] = Malta.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Malta.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Malta.precio)
                                {
                                    while (B < Malta.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Malta.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Malta.precio)
                                {
                                    D = B - Malta.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 5)
                        {
                            if (Colareal.cantidad != 0)
                            {
                                Colareal.venta();
                                stock[X] = Colareal.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Colareal.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Colareal.precio)
                                {
                                    while (B < Colareal.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Colareal.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Colareal.precio)
                                {
                                    D = B - Colareal.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 6)
                        {
                            if (Redrock.cantidad != 0)
                            {
                                Redrock.venta();
                                stock[X] = Redrock.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Redrock.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Redrock.precio)
                                {
                                    while (B < Redrock.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Redrock.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Redrock.precio)
                                {
                                    D = B - Redrock.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 7)
                        {
                            if (Countryclub.cantidad != 0)
                            {
                                Countryclub.venta();
                                stock[X] = Countryclub.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Countryclub.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Countryclub.precio)
                                {
                                    while (B < Countryclub.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Countryclub.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Countryclub.precio)
                                {
                                    D = B - Countryclub.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 8)
                        {
                            if (Sevenup.cantidad != 0)
                            {
                                Sevenup.venta();
                                stock[X] = Sevenup.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Sevenup.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Sevenup.precio)
                                {
                                    while (B < Sevenup.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Sevenup.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Sevenup.precio)
                                {
                                    D = B - Sevenup.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        if (X == 9)
                        {
                            if (Gatorade.cantidad != 0)
                            {
                                Gatorade.venta();
                                stock[X] = Gatorade.cantidad;
                                Console.WriteLine("La " + name[0] + " Cuesta " + Gatorade.precio + " Introdusca las monedas o billetes");
                                Y = Convert.ToInt32(Console.ReadLine());
                                B += Y;
                                if (B != Gatorade.precio)
                                {
                                    while (B < Gatorade.precio)
                                    {
                                        Console.WriteLine("Inserte otra moneda");
                                        Y = Convert.ToInt32(Console.ReadLine());
                                        B += Y;

                                    }
                                    D = B - Gatorade.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;

                                }
                                if (B >= Gatorade.precio)
                                {
                                    D = B - Gatorade.precio;
                                    Console.WriteLine("Su cambio es " + D);
                                    Console.WriteLine("Disfrute de su bebida\n");
                                    Console.WriteLine("Precione cualquier tecla para salir");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Lo sentimos ya no queda de este producto\n");
                                Console.WriteLine("Precione cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Productos en stock\n");
                        Colareal.Informe(name, stock);

                        break;
                    case 0:
                        break;
                }
            } 
            while ( A != 0 );
            
        }

    }
}
