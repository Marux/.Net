using System;
using System.Threading;

namespace BancoThink
{
	public class Calculo
	{
		private double SobreInteres = 3.0;
		private double Interes = 1.85;
		private int Prestamo;
        private int Cuotas;
        private int Total;



		public Calculo()
		{
		}


        public void setTotal(int Total)
        {
            this.Total = Total;
        }

        public int getCuotas()
        {
            return Cuotas;
        }

        public void setCuotas(int Cuotas)
        {
            this.Cuotas = Cuotas;
        }

        public int getPrestamo()
        {
            return Prestamo;
        }

        public void setPrestamo(int Prestamo)
        {
            this.Prestamo = Prestamo;
        }



        public void CalculoCredito() {
            Calculo c = new Calculo();
            Console.WriteLine("Ingrese su sueldo liquido: ");
            int sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Monto del prestamo solicitado: ");
            int Monto = Convert.ToInt32(Console.ReadLine());
            if (Monto >= (sueldo * 1.5))
            {
                Console.WriteLine("No se puede entregar prestamo ya que supera un 150% de su sueldo: ");
            }
            else
            {
                Console.WriteLine("Si se puede entregar prestamo: ");

                c.setPrestamo(Monto);
            }
            Console.WriteLine("Se entrego un prestamo por un monto de "+ c.getPrestamo());
        }

        public void CalculoCuotas() {
            Calculo c = new Calculo();
            Console.WriteLine("Ingrese cantidad de cuotas: ");
            int Cuotas = Convert.ToInt32(Console.ReadLine());
            if (Cuotas < 6)
            {
                Console.WriteLine("No se permite menos de 6 cuotas.");
            }
            else if (Cuotas <= 48)
            {

                Console.WriteLine("Se a ingresado la cantidad de cuotas de: " + Cuotas + " Con un interes del 1.85%.");
                c.setCuotas(Cuotas);

            }
            else if (Cuotas > 48)
            {

                Console.WriteLine("Sobre Interes aplicado. Cuotas de: " + Cuotas + " Con un interes de 3%");
                c.setCuotas(Cuotas);
            }
                Console.WriteLine(c.getCuotas());
                Console.WriteLine(c.getPrestamo());

           
        }

       

	}
}

