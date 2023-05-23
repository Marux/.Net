using System;
namespace BancoThink
{
	public class Prestamo
	{

		private int Monto;
		private int Cuota;


		public Prestamo()
		{
		}


		public int getMonto()
		{
			return Monto;
		}

		public void setMonto(int Monto) {
			this.Monto = Monto;
		}

		public int getCuota()
		{
			return Cuota;
		}

		public void setCuota(int Cuota)
		{
			this.Cuota = Cuota;

		}

	}
}

