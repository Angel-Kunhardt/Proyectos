using System;

namespace ConsoleApp1
{
    class Program
    {
        struct Ficha
        {
            public string nombre;
            public int PixAn;
            public int PixAl;
            public float Peso;
        }
        static void Main(string[] args)
        {
            int x, Ar=0;
            string nom;
            Ficha[] Img = new Ficha[700];
            do
            {
                Console.WriteLine("\nEscriba (1) si quieres añadir una ficha nueva");
                Console.WriteLine("Escriba (2) si quiere ver todas las fichas");
                Console.WriteLine("Escriba (3) si quiere buscar un ficha por nombre");
                Console.WriteLine("Escriba (0) si quiere salir\n");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        if (Ar != 699)
                        {
                            Console.WriteLine("\nEscriba el nombre de la imagen\n");
                            Img[Ar].nombre = Console.ReadLine();
                            Console.WriteLine("\nEscriba el tamaño de la imagen (Ancho de Pixeles)\n");
                            Img[Ar].PixAn = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEscriba el tamaño de la imagen (Alto de Pixeles)\n");
                            Img[Ar].PixAl = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEscriba el peso de la imagen (Peso en Kb por ejemplo 145,6)\n");
                            Img[Ar].Peso = (float)Convert.ToDecimal(Console.ReadLine()); 
                            Ar++;
                            Console.WriteLine("\nImagen registrada (Precione cualquier tecla para continuar)\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nLimite de imagenes alcanzado imagenes");
                            Console.WriteLine("Seprocedera a borrar las imagenes borrar las imagenes (Precione cualquier tecla para continuar)\n");
                            Console.ReadKey();
                            for (int i = 0; i < 700; i++)
                            {
                                Img[i].nombre = "null";
                                Img[i].PixAn = 0;
                                Img[i].PixAl = 0;
                                Img[i].Peso = 0;
                            }
                            Console.Clear();
                            Ar = 0;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n");
                        for (int i = 0; i < Ar; i++)
                        {
                            Console.WriteLine("Imagen: "+i+" Nombre: "+ Img[i].nombre);
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Escriba el nombre de la imagen que desea buscar\n");
                        nom = Console.ReadLine();
                        for (int i = 0; i < Ar; i++)
                        {
                            if (nom == Img[i].nombre)
                            {
                                Console.WriteLine("\nImagen: " + i + " Nombre: " + Img[i].nombre);
                                
                            }
                        }
                        Console.WriteLine("\nPrecione cualquier tecla para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        break;
                }
            } while (x != 0);
        }
    }
}
