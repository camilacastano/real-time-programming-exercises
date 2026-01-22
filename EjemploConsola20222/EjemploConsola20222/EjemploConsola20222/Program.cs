using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploConsola20222
{
    class Program
    {
        //Constructores
        //Metodos
        //Enumeraciones
        //Propiedades
        //Variables
        //Eventos

        static void Main(string[] args)
        {
            int numeroIngresado;
            int operacion;
            bool tieneCedula = false;
            bool tieneContrasena = false;
            string opcion = "y";


            while (opcion == "y")
            {
                Console.WriteLine("Hola");
                Console.WriteLine("Ingrese la edad: ");
                numeroIngresado = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Tiene contrasena: ");
                tieneContrasena = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Tiene cedula: ");
                tieneCedula = Convert.ToBoolean(Console.ReadLine());

                if ((numeroIngresado >= 18 && (tieneCedula || tieneContrasena)))
                {
                    Console.WriteLine("Puede ir");
                }
                else if ((tieneCedula || tieneContrasena))
                {
                    Console.WriteLine("Puede ir");
                }
                else
                {
                    Console.WriteLine("no puede ir");
                }

                for (int i = 0; i == 1; )
                {
                    Console.WriteLine("Quiere ejecutar de nuevo la aplicacion (y/n)? ");
                    opcion = Console.ReadLine();
                    if (opcion == "y" || opcion == "n")
                    {
                        break;
                    }
                }
            }




            //switch (numeroIngresado)
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    default:
            //        break;
            //}









            //operacion = numeroIngresado * numeroIngresado;

            //Console.WriteLine("El cuadrado del numero ingresado es: " + operacion.ToString());

            Console.ReadKey();
        }
    }
}
