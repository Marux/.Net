using System;
namespace CalculoSueldo
{
	public class ReponedorTienda
	{
        private String Cargo = "Reponedor de tienda.";
        private int SueldoBase = 1000;
        private int HorasTrabajadas;
        private int HHEE = 2000;


        public ReponedorTienda()
		{
		}

        public int getSueldoBase()
        {
            int Sueldo = SueldoBase * HorasTrabajadas;
            return Sueldo;
        }

        public void setSueldoBase(int SueldoBase)
        {

            this.SueldoBase = SueldoBase;
        }


        public int getHorasTrabajadas()
        {
            return HorasTrabajadas;
        }

        public void setHorasTrabajadas(int HorasTrabajadas)
        {
            this.HorasTrabajadas = HorasTrabajadas;
        }

        public int getHHEE()
        {

            int Hhee = (HorasTrabajadas - 40) * HHEE;
            return Hhee;
        }

        public String getCargo()
        {

            return Cargo;

        }

        public void setCargo(String Cargo)
        {

            this.Cargo = Cargo;
        }

        public void Formulario()
        {

            Console.WriteLine("Favor ingrese nombre del trabajador");
            Persona p = new Persona();

            String Nombre = Console.ReadLine();

            p.setNombre(Nombre);


            Console.WriteLine(" ");
            Console.WriteLine("Favor ingrese Cantidad Horas Trabajadas: ");

            ReponedorTienda r = new ReponedorTienda();

            int Horas = Convert.ToInt32(Console.ReadLine());

            r.setHorasTrabajadas(Horas);
            Console.WriteLine("**********Liquidacion de sueldo************");
            Console.WriteLine("Nombre del Trabajador: " + p.getNombre());
            Console.WriteLine("Cargo: " + r.getCargo());
            Console.WriteLine("Total Horas trabajadas: " + r.getHorasTrabajadas());
            Console.WriteLine("Total Horas Trabajadas a pagar: $" + r.getSueldoBase());
            Console.WriteLine("Total HHEE a pagar: $" + r.getHHEE());
            int suma = r.getHHEE() + r.getSueldoBase();
            Console.WriteLine("Total a pagar: " + suma);

        }


    }
}

