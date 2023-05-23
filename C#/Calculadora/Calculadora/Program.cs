using System;

namespace Calculadora // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora");

            Metodos m = new Metodos();

            Console.WriteLine("Ingrese Numero 1");
            m.setNum1(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Ingrese Numero 2");
            m.setNum2(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Seleccione operacion: ");
            Console.WriteLine("");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicacion");
            Console.WriteLine("4.- Division");
            Console.WriteLine("5- Potenciación.");
            

            int caso = Convert.ToInt32(Console.ReadLine());
            switch (caso) {
                case 1:
                   Console.WriteLine("La suma de los numeros enteros es: " + m.getSuma());
                    break;
                case 2:
                    Console.WriteLine("La resta de los numeros entero es: " + m.getResta()  );
                    break;
                case 3:
                    Console.WriteLine("La multiplicacion de los numeros entero es: " + m.getMulti());
                    break;
                case 4:
                    Console.WriteLine("La division de los numeros entero es: " + m.getDivi());
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        }
    }
}