using System;
namespace CalculoSueldo
{
	public class VendedorTienda
	{
        private String Cargo = "Vendedor de tienda.";
        private int SueldoBase = 1500;
        private int HorasTrabajadas;
        private int HHEE = 2500;

        public VendedorTienda()
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

            VendedorTienda v = new VendedorTienda();

            int Horas = Convert.ToInt32(Console.ReadLine());

            v.setHorasTrabajadas(Horas);
            Console.WriteLine("**********Liquidacion de sueldo************");
            Console.WriteLine("Nombre del Trabajador: " + p.getNombre());
            Console.WriteLine("Cargo: " + v.getCargo());
            Console.WriteLine("Total Horas trabajadas: " + v.getHorasTrabajadas());
            Console.WriteLine("Total Horas Trabajadas a pagar: $" + v.getSueldoBase());
            Console.WriteLine("Total HHEE a pagar: $" + v.getHHEE());
            int suma = v.getHHEE() + v.getSueldoBase();
            Console.WriteLine("Total a pagar: " + suma);

        }
    }
}

