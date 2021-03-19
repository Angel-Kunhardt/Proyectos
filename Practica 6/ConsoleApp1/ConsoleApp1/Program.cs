using System;

namespace ConsoleApp1
{
    public class Contacto
    {
        public string nombre;
        public string apellido;
        public string telefono;
        public string direccion;

        public Contacto(string N, string A, string T, string D)
        {
            nombre = N;
            apellido = A;
            telefono = T;
            direccion = D;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola Soy " + nombre);
            Console.WriteLine("Mi apellido es {0}", apellido);
            Console.WriteLine("Mi telefono es {0}", telefono);
            Console.WriteLine("Soy de {0}", direccion);
        }
    }

    class Program
    {
        static void ProbarContacto(string N1, string N2)
        {
            Console.WriteLine("Hola mi nombe es " + N1 + " ¿Como te llamas?");
            Console.WriteLine("Yo me llamo " + N2);
        }
        static void Main(string[] args)
        {
            string A, S, D, F;
            Console.WriteLine("Ingrese un contacto\n");
            Console.WriteLine("Escriba su nombre");
            A = Console.ReadLine();
            Console.WriteLine("\nEscriba su Apellido");
            S = Console.ReadLine();
            Console.WriteLine("\nEscriba su Telefono");
            D = Console.ReadLine();
            Console.WriteLine("\nEscriba su Direccion");
            F = Console.ReadLine();
            Contacto C1 = new Contacto(A, S, D, F);
            Console.Clear();

            Console.WriteLine("Ingrese otro contacto\n");
            Console.WriteLine("Escriba su nombre");
            A = Console.ReadLine();
            Console.WriteLine("\nEscriba su Apellido");
            S = Console.ReadLine();
            Console.WriteLine("\nEscriba su Telefono");
            D = Console.ReadLine();
            Console.WriteLine("\nEscriba su Direccion");
            F = Console.ReadLine();
            Contacto C2 = new Contacto(A, S, D, F);
            Console.Clear();

            ProbarContacto(C1.nombre, C2.nombre);

            Console.ReadKey();
        }
    }
}
