using System;
namespace Calculadora
{
	public class Metodos
	{

        private int suma;
        private int resta;
        private float multi;
        private double divi;
        private int num1;
        private int num2;

        public Metodos()
		{
		}




        public int getNum1()
        {
            return num1;
        }

        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public int getNum2()
        {
            return num2;
        }

        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public int getSuma()
        {
            int suma = num1 + num2;
            return suma;
        }

        public void setSuma(int suma)
        {
            this.suma = suma;
        }

        public int getResta()
        {
            int resta = num1 - num2;
            return resta;
        }

        public void setResta(int resta)
        {
            this.resta = resta;
        }

        public float getMulti()
        {
            float multi = num1 * num2;
            return multi;
        }

        public void setMulti(float multi)
        {
            this.multi = multi;
        }

        public double getDivi()
        {
            double divi = num1 / num2;
            return divi;
        }

        public void setDivi(double divi)
        {
            this.divi = divi;
        }





    }
}

