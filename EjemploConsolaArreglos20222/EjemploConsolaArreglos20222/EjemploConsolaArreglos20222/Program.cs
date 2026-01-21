using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploConsolaArreglos20222
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Tablero = new string[3, 3];
            int contador = 1;
            int posicionDefinida;
            string simbolo = "O";
            bool jugadaValida = false;

            for (int i = 0; i < Tablero.GetLength(0); i++)
            {
                for (int j = 0; j < Tablero.GetLength(1); j++)
                {
                    Tablero[i, j] = contador.ToString();
                    contador++;
                }
            }

            while (true)
            {
                //
                Console.WriteLine("Tablero Actual");

                for (int i = 0; i < Tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < Tablero.GetLength(1); j++)
                    {
                        Console.Write(Tablero[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Ingrese la posicion que desea:");
                posicionDefinida = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < Tablero.GetLength(1); j++)
                    {
                        if (Tablero[i, j] == posicionDefinida.ToString())
                        {
                            Tablero[i, j] = simbolo;
                            if (simbolo == "O")
                                simbolo = "X";
                            else
                                simbolo = "O";
                            jugadaValida = true;
                            break;
                        }
                        
                    }
                }

                if (!jugadaValida)
                {
                    Console.WriteLine("Posicion no disponible");
                    Console.ReadKey();
                }
                else
                {
                    //evaluar si existe un ganador

                }
                jugadaValida = false;
                Console.Clear();
            }

            ////matrices

            //double[,] Numeros = new double[2,2];
            //string[,] Nombres = new string[,] { { "Camilo", "Daniel", "Maria Camila", "Sebastian" }, { "Ana", "Luis", "Oscar", "Leo" } };

            //int cantFilas, cantColumnas;
            //int[,] NumerosEnteros;

            //Console.WriteLine("Ingrese la cantidad de filas para la matriz:");
            //cantFilas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese la cantidad de columnas para la matriz:");
            //cantColumnas = Convert.ToInt32(Console.ReadLine());

            //NumerosEnteros = new int[cantFilas, cantColumnas];

            //for (int i = 0; i < NumerosEnteros.GetLength(0); i++)
            //{
            //    for (int j = 0; j < NumerosEnteros.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Ingrese el valor de la posicion [" + i.ToString() + "," + j.ToString() +"] de la matriz:");
            //        NumerosEnteros[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.Clear();
            //Console.WriteLine("El contenido la matriz es:");


            //for (int i = 0; i < NumerosEnteros.GetLength(0); i++)
            //{
            //    for (int j = 0; j < NumerosEnteros.GetLength(1); j++)
            //    {
            //        Console.Write(NumerosEnteros[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Lectura con ciclo foreach:");

            //foreach (int dato in NumerosEnteros)
            //{
            //    Console.WriteLine(dato);
            //}


            //Console.ReadKey();




            ////vector

            //double[] Numeros = new double[20];
            //string[] Nombres = new string[] {"Camilo","Daniel", "Maria Camila", "Sebastian" };

            //int cantPosiciones;
            //int[] NumerosEnteros;

            //Console.WriteLine("Ingrese la cantidad de elementos que desea para el vector:");
            //cantPosiciones = Convert.ToInt32(Console.ReadLine());

            //NumerosEnteros = new int[cantPosiciones];

            //for (int i = 0; i < NumerosEnteros.Length; i++)
            //{
            //    Console.WriteLine("Ingrese el valor de la posicion "+ i.ToString() + "del vector:");
            //    NumerosEnteros[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Clear();
            //Console.WriteLine("El contenido del vector es:");


            //for (int i = 0; i < NumerosEnteros.Length; i++)
            //{
            //    Console.WriteLine("El vector en la posicion " + i.ToString() + " tiene:" + NumerosEnteros[i]);
            //}

            //Console.ReadKey();
        }
    }
}
