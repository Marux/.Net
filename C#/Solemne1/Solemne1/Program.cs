using System;

namespace Solemne1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Productos p = new Productos();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Que producto desea comprar?");
            Console.WriteLine("1 litro leche: 3000");
            Console.WriteLine("2 kilo pan: 1000");
            Console.WriteLine("1 queso: 1000");

            p.setLeche(3000);
            p.setPan(1000);
            p.setQueso(1000);

            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu) {

                case 1:
                    Console.WriteLine("Cuanta leche desea comprar?");
                    int leche = Convert.ToInt32(Console.ReadLine());
                    int lIva = (int)(p.getLeche() * .19);
                    int lTotal = leche * p.getLeche() + lIva;
                    Console.WriteLine("A comprado: " + leche + " Leches. Por un total: " + lTotal);
                    break;
                case 2:
                    Console.WriteLine("Cuantos kilos de pan desea comprar?");
                    int pan = Convert.ToInt32(Console.ReadLine());
                    int pIva = (int)(p.getPan() * .19);
                    int pTotal = pan * p.getPan() + pIva;
                    Console.WriteLine("A comprado: " + pan + " Kilos de pan. Por un total de: " + pTotal);
                    break;
                case 3:
                    Console.WriteLine("Cuanto Queso desea Comprar?");
                    int queso = Convert.ToInt32(Console.ReadLine());
                    int qIva = (int)(p.getQueso() * .19);
                    int qTotal = queso * p.getQueso() + qIva;
                    Console.WriteLine("A comprado: " + queso + " Quesos: Por un total de: " + qTotal);
                    break;
            }


        }



    }
}