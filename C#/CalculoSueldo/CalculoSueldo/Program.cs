using System;

namespace CalculoSueldo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*  Bienvenido a Electrolitos  *");
            Console.WriteLine("*******************************************");
            Console.WriteLine(" ");
            int volver = 2;
            do
            {
            Console.WriteLine("Eliga Opcion a ingresar ");
            Console.WriteLine(" ");
            Console.WriteLine("1.- Calcular sueldo de jefe de tienda.");
            Console.WriteLine("2.- Calcular sueldo de vendedor de tienda.");
            Console.WriteLine("3.- Calcular sueldo de reponedor de tienda.");
            Console.WriteLine("4.- Salir");
            Console.WriteLine(" ");
            Console.WriteLine("*******************************************");

            JefeTienda j = new JefeTienda();
            VendedorTienda v = new VendedorTienda();
            ReponedorTienda r = new ReponedorTienda();

                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("*******************************************");
                        j.Formulario();
                        Console.WriteLine("*******************************************");
                        goto case 4;
                    case 2:
                        Console.WriteLine("*******************************************");
                        v.Formulario();
                        Console.WriteLine("*******************************************");
                        goto case 4;
                    case 3:
                        Console.WriteLine("*******************************************");
                        r.Formulario();
                        Console.WriteLine("*******************************************");
                        goto case 4;
                    case 4:
                        Console.WriteLine("Desea continuar con la Apps?");
                        Console.WriteLine("1.- Si / 2.- No.");
                        Console.WriteLine("*******************************************");
                        volver = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            } while (volver != 2);
        }
    }
}