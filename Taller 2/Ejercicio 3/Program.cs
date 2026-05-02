using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HISTOGRAMA
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.Clear();
            

            // defino las variables
            double mayor = 0, menor = 999, dx = 0, rango = 0, u = 0;
            int n = 0, ni = 0, i, j = 0, m = 0;

            Console.WriteLine("\t\t\t HISTOGRAMA DE DATOS");
            Console.WriteLine("Ingresar la cantidad de numeros a analizar");
            n = Convert.ToInt32(Console.ReadLine());

            double[] vector = new double[n];


            for (i = 0; i < n; i++)
            {

                Console.WriteLine("Ingrese el dato " + (i + 1).ToString());
                vector[i] = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine(" Estos son los datos ingresados ");

            for (i = 0; i < n; i++)
            {
                Console.Write("          " + vector[i].ToString());
                //Salto de linea
                Console.WriteLine("");
            }


            double conta = 0;
            //orden de los valores 
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        conta = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = conta;
                    }
                }
            }

            Console.ReadKey();
            //imprime el vector ordenado

            Console.WriteLine("los numeros ordenados son: ");
            for (i = 0; i < n; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }

                if (vector[i] < menor)
                {
                    menor = vector[i];
                }

                Console.Write("      " + vector[i].ToString());
                //Salto de linea
                Console.WriteLine("");
            }

            Console.WriteLine("El numero mayor es" + mayor);
            Console.WriteLine("El numero menor es" + menor);

            //  para el intervalo
            Console.ReadKey();
            Console.WriteLine("\n Ingrese el numero de intervalos ");
            ni = Convert.ToInt32(Console.ReadLine());
            rango = menor;
            int menor1 = Convert.ToInt32(menor);

            dx = (mayor - menor) / ni;

            //vector para poder hacer el histograma
            double[] c = new double[10000];
            i = 0;
            for (m = 0; m < 100; )
            {
                c[i] = m;
                m = m + 1;
                i++;
            }

            for (u = 0; u < ni; u++)
            {
                menor = rango;
                rango = rango + dx;

                Console.Write("I" + (u + 1).ToString() + " |");

                for (m = 0; m < n; m++)
                {

                    if ((menor <= vector[m]) && (vector[m] <= rango))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
