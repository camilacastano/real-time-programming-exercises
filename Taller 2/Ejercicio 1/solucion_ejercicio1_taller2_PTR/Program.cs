using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace arreglomatriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int fila1 = 0, colm1 = 0, fila2 = 0, colm2 = 0,x1,y1,x2,y2;

            Console.WriteLine("Favor ingrese el número filas de la matriz 1:");
            fila1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Favor ingrese el numero columnas de la matriz 1:");
            colm1 = Convert.ToInt32(Console.ReadLine());

            double[,] matriz1 = new double[fila1, colm1];
            Console.WriteLine("Escriba los elementos de la matriz 1");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    x1 = i + 1;
                    y1 = j + 1;
                    Console.WriteLine("Escriba por favor el elemento (" + x1.ToString() + " , " + y1.ToString() + ") para la matriz 1.");
                    matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("Escriba por favor la cantidad de filas en matriz 2:");
            fila2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba por favor la cantidad de columnas en matriz 2:");
            colm2 = Convert.ToInt32(Console.ReadLine());

            double[,] matriz2 = new double[fila2, colm2];

            Console.WriteLine("Por favor escriba los elementos de la matriz 2.");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    x2 = i + 1;
                    y2 = j + 1;
                    Console.WriteLine("Escriba por favor el elemento (" + x2.ToString() + " , " + y2.ToString() + ") para la matriz 2.");
                    matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            bool ejecutarprog = true;
            while (ejecutarprog)
            {
                //es la parte para el menu
                Console.Clear();
                int opcion = 0;
                Console.WriteLine("Menu");
                Console.WriteLine("1.Cambiar matriz 1.");
                Console.WriteLine("2.Cambiar matriz 2.");
                Console.WriteLine("3.Suma de matrices.");
                Console.WriteLine("4.Resta de matrices.");
                Console.WriteLine("5.Multiplicación de matrices.");
                Console.WriteLine("6.Multiplicación de un escalar por una matriz.");
                Console.WriteLine("7.Salida.");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Favor ingrese el número filas de la matriz 1:");
                        fila1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Favor ingrese el numero columnas de la matriz 1:");
                        colm1 = Convert.ToInt32(Console.ReadLine());

                        matriz1 = new double[fila1, colm1];
                        Console.WriteLine("Escriba los elementos de la matriz 1");

                        for (int i = 0; i < matriz1.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz1.GetLength(1); j++)
                            {
                                Console.WriteLine("Escriba por favor el elemento (" + i + 1.ToString() + " , " + j + 1.ToString() + ") para la matriz 1.");
                                matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
                            }
                        }

                        break;

                    case 2:
                        
                        Console.WriteLine("Escriba por favor la cantidad de filas en matriz 2:");
                        fila2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba por favor la cantidad de columnas en matriz 2:");
                        colm2 = Convert.ToInt32(Console.ReadLine());

                        matriz2 = new double[fila2, colm2];

                        Console.WriteLine("Por favor escriba los elementos de la matriz 2.");
                        for (int i = 0; i < matriz2.GetLength(0); i++)
                        {
                            for (int j = 0; j < matriz2.GetLength(1); j++)
                            {
                                Console.WriteLine("Por favor escriba el elemento (" + (i + 1).ToString() + " , " + (j + 1).ToString() + ") de la matriz 2.");
                                matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
                            }
                        } 

                        break;

                    case 3:
                        Console.WriteLine("Para la suma de matrices: ");

                        if (fila1 == fila2 && colm1 == colm2)
                        {
                            double[,] matrizsum = new double[fila2, colm1];

                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    matrizsum[i, j] = matriz1[i, j] + matriz2[i, j];
                                }
                            }
                            Console.Clear();

                            Console.WriteLine("El resultado de la suma de matrices es: ");

                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    Console.Write(matrizsum[i, j] + "  ");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Las matrices no se pueden sumar. ");
                        }

                        break;

                    case 4:
                        int opcionrestar = 0;
                        Console.WriteLine("La resta de las matrices es: ");

                        while (true)
                        {
                            Console.WriteLine("Elija el tipo de resta: (1) para la matriz 1 menos la 2, o (2) si quiere restar la matriz 2 menos 1");
                            opcionrestar = Convert.ToInt32(Console.ReadLine());
                            if (opcionrestar == 1 || opcionrestar == 2)
                                break;
                            else
                                Console.WriteLine("Favor vuelva a ingresar una opción verdadera");
                        }


                        if (fila1 == fila2 && colm1 == colm2)
                        {
                            double[,] matrizrest = new double[fila1, colm1];
                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    if (opcionrestar == 1)
                                        matrizrest[i, j] = matriz1[i, j] - matriz2[i, j];
                                    else if (opcionrestar == 2)
                                        matrizrest[i, j] = matriz2[i, j] - matriz1[i, j];
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("El resultado para la resta de matrices es: ");

                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    Console.Write(matrizrest[i, j] + "   ");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Las dimensiones no son correctas para la resta, vuelva e intente.");
                        }

                        break;

                    case 5:
                        int opcionmultipli = 0;
                        Console.WriteLine("Multiplicar matriz: ");
                        if (colm1 == fila2 || colm2 == fila1)
                        {
                        while (true)
                        {
                            Console.WriteLine("Cual es el orden de la multiplicación: (1)  1 por 2  (2) o 2 por 1");
                            opcionmultipli = Convert.ToInt32(Console.ReadLine());
                            if (opcionmultipli == 1 || opcionmultipli == 2)
                                break;
                            else
                                Console.WriteLine("La opción es erronea, favor vuelva a intentar.");
                        }

                        if (opcionmultipli == 1)
                        {
                            if (colm1 == fila2)
                            {
                                double[,] matriZmult = new double[colm1, fila2];
                                for (int i = 0; i < matriz1.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz2.GetLength(1); j++)
                                    {
                                        for (int k = 0; k < matriz1.GetLength(1); k++)
                                        {
                                            matriZmult[i, j] = matriz1[i, k] * matriz2[k, j] + matriZmult[i, j];
                                        }
                                    }
                                }
                                Console.Clear();
                                Console.WriteLine("El resultado de la multiplicación de matrices es: ");
                                for (int i = 0; i < matriz1.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz2.GetLength(1); j++)
                                    {
                                        Console.Write(matriZmult[i, j] + "   ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("La operación de multiplicación es inválida, vuelva e intente.");
                                Console.ReadKey();
                            }
                        }
                        else if (opcionmultipli == 2)
                        {
                            if (colm2 == fila1)
                            {
                                double[,] matriZmult = new double[colm1, fila2];
                                for (int i = 0; i < matriz2.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz1.GetLength(1); j++)
                                    {
                                        for (int k = 0; k < matriz2.GetLength(1); k++)
                                        {
                                            matriZmult[i, j] = matriz2[i, k] * matriz1[k, j] + matriZmult[i, j];
                                        }
                                    }
                                }
                                Console.Clear();
                                Console.WriteLine("El resultado de la multiplicación es: ");
                                for (int i = 0; i < matriz2.GetLength(0); i++)
                                {
                                    for (int j = 0; j < matriz1.GetLength(1); j++)
                                    {
                                        Console.Write(matriZmult[i, j] + "   ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("la multiplicación no es válida, vuelva a intentarlo");
                            }
                        }
                        }
                        break;

                    case 6:
                        int opcionmultiscalmat = 0;
                        double scalar = 0;
                        Console.WriteLine("Multiplica un escalar por la una matriz. ");
                        while (true)
                        {
                            Console.WriteLine("Multiplica la matriz: (1) primera matriz (2) o la segunda matriz. ");
                            opcionmultiscalmat = Convert.ToInt32(Console.ReadLine());
                            if (opcionmultiscalmat == 1 || opcionmultiscalmat == 2)
                                break;
                            else
                                Console.WriteLine("La opción no es correcta, vuelva a intentar. ");
                                Console.ReadKey();
                        }

                        Console.WriteLine("Escriba un escalar para continuar la multiplicación: ");
                        scalar = Convert.ToDouble(Console.ReadLine());

                        if (fila1 == fila2 && colm1 == colm2)
                        {
                            double[,] matrizresu = new double[fila1, colm1];
                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    if (opcionmultiscalmat == 1)
                                        matrizresu[i, j] = matriz1[i, j] * scalar;
                                    else if (opcionmultiscalmat == 2)
                                        matrizresu[i, j] = scalar * matriz2[i, j];
                                }
                            }

                            Console.Clear();
                            Console.WriteLine("El Resultado es el siguiente: ");

                            for (int i = 0; i < matriz2.GetLength(0); i++)
                            {
                                for (int j = 0; j < matriz2.GetLength(1); j++)
                                {
                                    Console.Write(matrizresu[i, j] + "  ");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No es posible realizar la operación, vuelva a intentarlo.");
                            Console.ReadKey();
                        }
                        break;

                    case 7:
                        Console.WriteLine("Salida");
                        ejecutarprog = false;
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}