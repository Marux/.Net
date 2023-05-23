using System;
namespace BancoThink
{
	public class Persona
	{
		private int Rut;
		private String Nombre;
		private String Apellidos;
		private int Telefono;
		private String Direccion;
		private String DireccionLab;
		private int Sueldo;


		public Persona()
		{
		}



        public int getRut()
        {
            return Rut;
        }

        public void setRut(int Rut)
        {
            this.Rut = Rut;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }


        public String getApellidos()
        {
            return Apellidos;
        }

        public void setApellidos(String Apellidos)
        {
            this.Apellidos = Apellidos;
        }

        public String getDireccion()
        {
            return Direccion;
        }

        public void setDireccion(String Direccion)
        {
            this.Direccion = Direccion;
        }

        public String getDireccionLab()
        {
            return DireccionLab;
        }

        public void setDireccionLab(String DireccionLab)
        {
            this.DireccionLab = DireccionLab;
        }


        public int getTelefono()
        {
            return Telefono;
        }

        public void setTelefono(int Telefono)
        {
            this.Telefono = Telefono;
        }


        public int getSueldo()
        {
            return Sueldo;
        }

        public void setSueldo(int Sueldo)
        {
            this.Sueldo = Sueldo;
        }





    }
}

