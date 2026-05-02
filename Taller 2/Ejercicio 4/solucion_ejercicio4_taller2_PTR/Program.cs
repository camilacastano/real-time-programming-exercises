using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solucion_ejercicio4_taller2_PTR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polinomio por regla de ruffini
            int i, j,grado,x,y,move1,move2;
            double raiz;
            double[] pol;
            double[] resp;
            double[] mult;

            move1 = 0;
            move2 = 0;
            x = 1;
            y = 15;

            Console.WriteLine("Ingrese el grado del polinomio a evaluar: ");
            grado=Convert.ToInt32(Console.ReadLine());

            if (grado >= 0)
            {
                pol = new double[grado + 1];
                resp = new double[grado + 1];
                mult = new double[grado + 1];

                for (i = 0; i <= grado; i++)
                {
                    Console.WriteLine("Ingrese el coheficiente correspondiente al grado " + i + " del polinomio: ");
                    pol[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el valor que se va a evaluar como raiz: ");
                raiz = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Presione ENTER para avanzar en el procedimiento");

                //Formato de presentacion procedimiento
                for (i = 0; i <= 23; i++)
                {
                    Console.SetCursorPosition(x + move2, y + 3);
                    Console.Write("-");
                    move2++;
                }
                move2 = 0;
                for (i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(x + 24, y + move2);
                    Console.Write("|");
                    move2++;
                }

                for (i = grado; i >= 0; i--)
                {
                    if (i == grado)
                    {
                        resp[i] = pol[i];
                        mult[i] = 0;
                    }
                    else
                    {
                        mult[i] = resp[i + 1] * raiz;
                        resp[i] = pol[i] + mult[i];
                    }
                }
                //Mostrar procedimiento
                Console.SetCursorPosition(x + 25, y + 2);
                Console.Write(raiz);

                for (j = grado; j >= 0; j--)
                {
                    Console.SetCursorPosition(x + move1, y);
                    Console.Write(pol[j]);
                    move1 = move1 + 7;
                }

                move1 = 0;

                for (j = grado; j >= 0; j--)
                {
                    if (j == grado)
                    {
                        Console.SetCursorPosition(x + move1, y + 4);
                        Console.Write(resp[j]);
                        Console.ReadKey();
                        move1 = move1 + 7;

                    }
                    else
                    {
                        Console.SetCursorPosition(x + move1, y + 2);
                        Console.Write(mult[j]);
                        Console.ReadKey();

                        Console.SetCursorPosition(x + move1, y + 4);
                        Console.Write(resp[j]);
                        Console.ReadKey();
                        move1 = move1 + 7;
                    }
                }

                //Resultado
                if (resp[0] == 0)
                {
                    Console.SetCursorPosition(0, y + 6);
                    Console.WriteLine("El valor " + Convert.ToString(raiz) + " es raiz del polinomio ");
                }
                else
                {
                    Console.SetCursorPosition(0, y + 6);
                    Console.WriteLine("El valor " + Convert.ToString(raiz) + " no es raiz del polinomio ");
                }
                Console.WriteLine("");
                Console.WriteLine("Presione ENTER para salir");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor ingresado no valido");
                Console.WriteLine("Presione ENTER para salir");
                Console.ReadKey();
            }
        }
    }
}
