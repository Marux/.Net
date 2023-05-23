using System;
namespace BancoThink
{
	public class Cliente : Persona
	{
		public Cliente()
		{
		}

		public void RegistroCliente() {
			Persona p = new Persona();

			Console.WriteLine("Ingrese Nombre: ");
            String Nombre = Console.ReadLine();
            p.setNombre(Nombre);

            Console.WriteLine("Ingrese Apellidos: ");
			String Apellidos = Console.ReadLine();
			p.setApellidos(Apellidos);

            Console.WriteLine("Ingrese Rut: ");
			int Rut = Convert.ToInt32(Console.ReadLine());
			p.setRut(Rut);

            Console.WriteLine("Ingrese Telefono: ");
			int Telefono = Convert.ToInt32(Console.ReadLine());
			p.setTelefono(Telefono);

            Console.WriteLine("Ingrese Direccion: ");
			String Direccion = Console.ReadLine();
			p.setDireccion(Direccion);

     







        }

	}
}

