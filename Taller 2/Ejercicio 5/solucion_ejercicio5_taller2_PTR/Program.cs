using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;


namespace solucion_ejercicio5_taller2_PTR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recordatorio a una hora especifica
            bool sal = true;
            int  opcion=0, opcion2, hora=1, min=1, hora2=1, min2=1;


            DateTime tiempo1 = new DateTime(2021, 3, 1, 15, 30, 0);
            DateTime tiempo2 = new DateTime(2021, 3, 1, 16, 50, 0);

           // Task contador = Task.
            Console.WriteLine("Ingreso de la hora actual");
            Console.WriteLine("Para ingresar automaticamente la hora presione (1), para hacerlo manualmente presione (2)");
            opcion2 = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (opcion2 == 1 || opcion2 == 2)
                {
                    if (opcion2 == 2)
                    {
                        Console.WriteLine("ingrese la hora actual (como un numero del 0 al 23)");
                        hora = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ingrese el minuto actual (como un numero del 0 al 59)");
                        min = Convert.ToInt32(Console.ReadLine());

                        tiempo1 = new DateTime(2021, 3, 1, hora, min, 0);
                    }
                    else
                    {
                        tiempo1 = DateTime.Now;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Numero ingresado no valido, intente nuevamente");
                }
            }
            Console.WriteLine("La hora actual es: "+Convert.ToString(tiempo1.TimeOfDay));
            Console.WriteLine("");
            Console.WriteLine("Ingreso de la hora del evento");
            Console.WriteLine("ingrese la hora actual (como un numero del 0 al 23)");
            hora2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el minuto actual (como un numero del 0 al 59)");
            min2 = Convert.ToInt32(Console.ReadLine());
            tiempo2 = new DateTime(2021, 3, 1, hora2, min2, 0);

            while (sal==true)
            {
                Console.Clear();
                Console.WriteLine("---Menu de operaciones---");
                Console.WriteLine("1. Ver el reloj configurado");
                Console.WriteLine("2. Activar recordatorio");
                Console.Write("");
                Console.Write("Ingrese la opcion que desea:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("La hora del evento es:" + Convert.ToString(tiempo2.TimeOfDay));
                        Console.WriteLine("");
                        Console.WriteLine("La hora actual es:"+Convert.ToString(tiempo1.TimeOfDay));
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;

                    case 2:
                        TimeSpan faltante = tiempo2 - tiempo1;
                        while (true)
                        {
                            if (Convert.ToInt32(faltante.Seconds) > 0)
                            {
                                tiempo1 = tiempo1.AddSeconds(1);
                                faltante = tiempo2 - tiempo1;
                                Thread.Sleep(500);
                            }
                            else
                            {
                                SystemSounds.Beep.Play();
                                Thread.Sleep(200);
                                SystemSounds.Beep.Play();
                                Thread.Sleep(200);
                                SystemSounds.Beep.Play();
                                Console.WriteLine("Hora cumplida");
                                break;
                            }
                        }
                        sal=false;
                        Console.WriteLine("Fin de operaciones");
                        Console.ReadKey();
                        break;

                    
                }
            }
            
        }
    }
}
