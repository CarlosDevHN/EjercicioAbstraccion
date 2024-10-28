using System;

namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSeleccione una formula matematica:");
                Console.WriteLine("1. Area de un circulo");
                Console.WriteLine("2. Perimetro del rectangulo");
                Console.WriteLine("3. Convertir millas a kilometros");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese su opcion: ");

                int opcion = int.Parse(Console.ReadLine());

                FormulaMatematica formula = null;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el radio del circulo: ");
                        double radio = double.Parse(Console.ReadLine());
                        formula = new AreaCirculo(radio);
                        break;

                    case 2:
                        Console.Write("Ingrese el largo del rectangulo: ");
                        double largo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ancho del rectangulo: ");
                        double ancho = double.Parse(Console.ReadLine());
                        formula = new PerimetroRectangulo(largo, ancho);
                        break;

                    case 3:
                        Console.Write("Ingrese la cantidad de millas: ");
                        double millas = double.Parse(Console.ReadLine());
                        formula = new ConvertirMillasAKilometros(millas);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        continue;
                }

                formula.Imprimir();
            }
        }
    }
}
