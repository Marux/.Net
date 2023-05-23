using System;

namespace BancoThink
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c = new Cliente();
            Empleado e = new Empleado();
            Calculo a = new Calculo();

            Console.WriteLine("******************************");
            Console.WriteLine("Bienenido al BancoThink: ");
            Console.WriteLine("******************************");
            Console.WriteLine("");
            Console.WriteLine("Eliga el tipo de persona que solicitara el credito: ");
            Console.WriteLine("1.- Cliente");
            Console.WriteLine("2.- Empleado");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    c.RegistroCliente();
                    a.CalculoCredito();
                    a.CalculoCuotas();
                    

                    break;
                case 2:
                    e.RegistroCliente();
                    a.CalculoCredito();
                    a.CalculoCuotas();
                    break;
                default:
                    break;
            }
            

        }
    }
}