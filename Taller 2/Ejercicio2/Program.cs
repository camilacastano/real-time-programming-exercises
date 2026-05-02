using System;

namespace T2Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SALAS DE CINE
            int capf = 100, capc =100, opc=1, costoB = 0, cx = 0, cy = 0, conf, totalb, totalp;
            bool[,] sillas = new bool[capf, capc];
            bool intento1= true, salir = false, asign = true, verif = false;
            while (!salir)
            {
                if (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("---MENÚ---");
                    Console.WriteLine("1. DEFINICIÓN DE LOS PARÁMETROS DE LA SALA");
                    Console.WriteLine("2. VISUALIZACIÓN DE LA SALA");
                    Console.WriteLine("3. ASIGNACIÓN DE SILLAS");
                    Console.WriteLine("4. DINERO DISPONIBLE EN LA CAJA ");
                    Console.WriteLine("5. CAMBIAR  O DEFINIR PRECIO DE LOS ASIENTOS BÁSICOS ");
                    Console.WriteLine("CUALQUIER OTRA TECLA PARA SALIR ");
                    Console.WriteLine(" ");
                    Console.Write("Seleccione la opción que desea: ");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            if (intento1)
                            {
                                Console.WriteLine("1. DEFINICIÓN DE LOS PARÁMETROS DE LA SALA");
                                Console.Write("Ingrese el total de filas que tendrá la sala: ");
                                capf = (Convert.ToInt32(Console.ReadLine()));
                                Console.Write("Ingrese el total de columnas que tendrá la sala: ");
                                capc = (Convert.ToInt32(Console.ReadLine()));
                            }

                            if (intento1)
                            {
                                Console.Write("Ingrese el valor de los asientos básicos: ");
                                costoB = (Convert.ToInt32(Console.ReadLine()));
                                intento1 = false;
                            }
                            Console.WriteLine("Presione cualquier tecla para continuar. ");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("2. VISUALIZACIÓN DE LA SALA");
                            Console.WriteLine("[x]: Sillas ocupadas, [ ]: Disponibles, { }\\{x} Preferenciales Desocupadas\\Ocupadas");
                            Console.Write("                    ");
                            for (int i = 0; i < capc; i++)
                            {
                                if (i < 9)
                                    Console.Write(" " + (i + 1));
                                else
                                    Console.Write((i + 1));
                                Console.Write("   ");
                            }
                            Console.WriteLine(" ");
                            for (int i = 0; i < capf - 1; i++)
                            {
                                if (i < 9)
                                    Console.Write("               " + (i + 1) + " : ");
                                else
                                    Console.Write("              " + (i + 1) + " : ");
                                for (int j = 0; j < capc; j++)
                                {
                                    Console.Write(" [");
                                    if (sillas[i, j])
                                        Console.Write("x");
                                    else
                                        Console.Write(" ");
                                    Console.Write("] ");
                                }
                                Console.WriteLine();
                            }
                            if (capf < 10)
                                Console.Write("               " + capf + " : ");
                            else
                                Console.Write("              " + capf + " : ");
                            for (int j = 0; j < capc; j++)
                            {
                                Console.Write(" {");
                                if (sillas[capf - 1, j])
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                                Console.Write("} ");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier tecla para continuar. ");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("3. ASIGNACIÓN DE SILLAS");
                            asign = true;
                            while (asign)
                            {
                                verif = false;
                                while (!verif)
                                {
                                    Console.Clear();
                                    Console.WriteLine("VISUALIZACIÓN DE LA SALA");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("[x]: Sillas ocupadas, [ ]: Disponibles, { }\\{x} Preferenciales Desocupadas\\Ocupadas ");
                                    Console.WriteLine(" ");
                                    Console.Write("                    ");
                                    for (int i = 0; i < capc; i++)
                                    {
                                        if (i < 9)
                                            Console.Write(" " + (i + 1));
                                        else
                                            Console.Write((i + 1));
                                        Console.Write("   ");
                                    }
                                    Console.WriteLine(" ");
                                    for (int i = 0; i < capf - 1; i++)
                                    {
                                        if (i < 9)
                                            Console.Write("               " + (i + 1) + " : ");
                                        else
                                            Console.Write("              " + (i + 1) + " : ");
                                        for (int j = 0; j < capc; j++)
                                        {
                                            Console.Write(" [");
                                            if (sillas[i, j])
                                                Console.Write("x");
                                            else
                                                Console.Write(" ");
                                            Console.Write("] ");
                                        }
                                        Console.WriteLine();
                                    }
                                    if (capf < 10)
                                        Console.Write("               " + capf + " : ");
                                    else
                                        Console.Write("              " + capf + " : ");
                                    for (int j = 0; j < capc; j++)
                                    {
                                        Console.Write(" {");
                                        if (sillas[capf - 1, j])
                                            Console.Write("x");
                                        else
                                            Console.Write(" ");
                                        Console.Write("} ");
                                    }
                                    Console.WriteLine("Ingrese las coordenadas del puesto de interés:  ");
                                    Console.Write("          Fila: ");
                                    cy = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("       Columna: ");
                                    cx = Convert.ToInt32(Console.ReadLine());
                                    if (cy > capf || cx > capc)
                                    {
                                        Console.Write("La coordenada está fuera de límites, intente nuevamente.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        verif = true;
                                        Console.Write("Este asiento está ");
                                        if (sillas[cy - 1, cx - 1])
                                        {
                                            Console.Write("OCUPADO. Desea desocuparlo? (1: Si) : ");
                                            conf = Convert.ToInt32(Console.ReadLine());
                                            if (conf == 1)
                                            {
                                                Console.Write("Ha desocupado el asiento ( " + cy + " , " + cx + " ).");
                                                sillas[cy - 1, cx - 1] = false;
                                            }
                                            else
                                                Console.Write("Ha decicido no desocupar el asiento ( " + cy + " , " + cx + " ).");
                                        }
                                        else
                                        {
                                            Console.Write("DESOCUPADO. Desea ocuparlo? (1: Si) : ");
                                            conf = Convert.ToInt32(Console.ReadLine());
                                            if (conf == 1)
                                            {
                                                Console.Write("Ha decicido ocupar el asiento ( " + cy + " , " + cx + " ).");
                                                sillas[cy - 1, cx - 1] = true;
                                            }
                                            else
                                                Console.Write("Ha decicido no ocupar el asiento ( " + cy + " , " + cx + " ).");
                                        }
                                        Console.Write("Quiere seguir modificando puestos? (1: Sí): ");
                                        Console.WriteLine("Cualquier otra tecla para continuar");
                                        conf = Convert.ToInt32(Console.ReadLine());
                                        if (conf == 1)
                                        {
                                            Console.Clear();
                                        }
                                        else
                                            asign = false;
                                    }
                                }

                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier tecla para continuar. ");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("4. DINERO DISPONIBLE EN LA CAJA POR ASIENTOS OCUPADOS ");
                            Console.WriteLine("La sala es: ");
                            Console.WriteLine("[x]: Sillas ocupadas, [ ]: Disponibles, { }\\{x} Preferenciales Desocupadas\\Ocupadas");
                            Console.Write("                    ");
                            for (int i = 0; i < capc; i++)
                            {
                                if (i < 9)
                                    Console.Write(" " + (i + 1));
                                else
                                    Console.Write((i + 1));
                                Console.Write("   ");
                            }
                            Console.WriteLine(" ");
                            for (int i = 0; i < capf - 1; i++)
                            {
                                if (i < 9)
                                    Console.Write("               " + (i + 1) + " : ");
                                else
                                    Console.Write("              " + (i + 1) + " : ");
                                for (int j = 0; j < capc; j++)
                                {
                                    Console.Write(" [");
                                    if (sillas[i, j])
                                        Console.Write("x");
                                    else
                                        Console.Write(" ");
                                    Console.Write("] ");
                                }
                                Console.WriteLine();
                            }
                            if (capf < 10)
                                Console.Write("               " + capf + " : ");
                            else
                                Console.Write("              " + capf + " : ");
                            for (int j = 0; j < capc; j++)
                            {
                                Console.Write(" {");
                                if (sillas[capf - 1, j])
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                                Console.Write("} ");
                            }
                            totalb = 0;
                            totalp = 0;
                            for (int i = 0; i < capf - 1; i++)
                            {
                                for (int j = 0; j < capc; j++)
                                {
                                    if (sillas[i, j])
                                        totalb++;
                                }
                            }
                            for (int j = 0; j < capc; j++)
                            {
                                if (sillas[capf - 1, j])
                                    totalp++;
                            }
                            Console.WriteLine("EL TOTAL RECAUDADO SERÁ: ");
                            Console.WriteLine("Básicos: " + totalb + " x $ " + costoB + " = " + (costoB * totalb));
                            Console.WriteLine("Preferencial: " + totalp + " x $ " + (costoB + 4000) + " = " + ((costoB + 4000) * totalp));
                            Console.WriteLine(" ");
                            Console.WriteLine("Total : $ " + (((costoB + 4000) * totalp) + (costoB * totalb)));
                            Console.WriteLine(" Presione cualquier tecla para continuar. ");
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("5. CAMBIAR O DEFINIR PRECIO DE LOS ASIENTOS BÁSICOS ");
                            Console.Write("Ingrese el costo de los asientos básicos: $ ");
                            costoB = Convert.ToInt32(Console.ReadLine());
                            intento1 = false;
                            Console.WriteLine("Presione cualquier tecla para continuar. ");
                            Console.ReadKey();
                            break;
                        default:
                            salir = true;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Ha elegido salir del programa");
                    Console.ReadKey();
                }
            }

            
        }
    }
}
