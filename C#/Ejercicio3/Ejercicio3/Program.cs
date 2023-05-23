using System;
using System.Reflection.PortableExecutable;

namespace Ejercicio3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            Contador con = new Contador();
            Caja ca = new Caja();
            Cobrador cob = new Cobrador();

            ca.setSaldo(20000);
            c.setNombre("Victor Trimpai");
            con.setCajita(ca);
            Console.WriteLine("Bienvenido al Sistema de Prestamo: " + c.getNombre());

            Console.WriteLine("El saldo de la caja es: " + ca.getSaldo());
            Console.WriteLine("Ingrese monto a solicitar: ");
            int montoprestamo = Int32.Parse(Console.ReadLine());
            int deudatotalcliente = con.Prestar(montoprestamo);

            c.setMontocredito(montoprestamo);
            c.setDeuda(deudatotalcliente);

            Console.WriteLine(c.getNombre() + " Usted pidio la suma de: " + c.getMontocredito());
            Console.WriteLine(c.getNombre() + " Y su deuda total es: " + c.getDeuda());


            Console.WriteLine(c.getNombre() + " Favor ingrese el mondo a devolver: ");
            int montodevuelto = Int32.Parse(Console.ReadLine());

            cob.Cobrar(montodevuelto);

            int recaudadototal = cob.Devolver();
            con.Devolver(recaudadototal);

            Console.WriteLine("El saldo de la caja es de: " + ca.getSaldo());




        }
    }
}