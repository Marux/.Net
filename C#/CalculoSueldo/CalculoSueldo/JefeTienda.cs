using System;
namespace CalculoSueldo
{
	public class JefeTienda
	{
        private String Cargo = "Jefe de tienda.";
        private int SueldoBase = 2000;
		private int HorasTrabajadas;
		private int HHEE = 3000;
      

        public JefeTienda()
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

        public int getHHEE() {

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

            JefeTienda j = new JefeTienda();

            int Horas = Convert.ToInt32(Console.ReadLine());

            j.setHorasTrabajadas(Horas);
            Console.WriteLine("**********Liquidacion de sueldo************");
            Console.WriteLine("Nombre del Trabajador: " + p.getNombre());
            Console.WriteLine("Cargo: " + j.getCargo());
            Console.WriteLine("Total Horas trabajadas: " + j.getHorasTrabajadas());
            Console.WriteLine("Total Horas Trabajadas a pagar: $" + j.getSueldoBase());
            Console.WriteLine("Total HHEE a pagar: $" + j.getHHEE());
            int suma = j.getHHEE() + j.getSueldoBase();
            Console.WriteLine("Total a pagar: " + suma);
        

        }

    }
}

