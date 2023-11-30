using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, numAlumnos;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese la cantidad de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            double[] calificaciones = new double[numAlumnos];

            for (i = 0; i < numAlumnos; i++)
            {
                Console.Write("Ingrese la calificacion para el indice {0}: ", i);
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificaciones[i];
            }
            promedio = sumaCalif / numAlumnos;

            for (i = 0;i < numAlumnos; i++)
            {
                if (califMin > calificaciones[i])
                {
                    califMin = calificaciones[i];
                }
            }
            Console.WriteLine(califMin);
        }
    }
}
