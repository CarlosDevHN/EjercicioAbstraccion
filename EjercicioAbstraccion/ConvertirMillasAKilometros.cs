using System;

namespace EjercicioAbstraccion
{
    public class ConvertirMillasAKilometros : FormulaMatematica
    {
        private double millas;

        public ConvertirMillasAKilometros(double millas)
        {
            this.millas = millas;
        }

        public override double Calcular()
        {
            return millas * 1.60934;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{millas} millas equivalen a: {Calcular()} kilometros");
        }
    }
}
