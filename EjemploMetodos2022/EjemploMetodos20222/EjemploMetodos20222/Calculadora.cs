using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploMetodos20222
{
    class Calculadora
    {
        //Campos, propiedades, constructores, metodos, enumeraciones, estructuras
        public int dato1;
        public int dato2;

        public Calculadora()   //constructor sin parametros
        {
            dato1 = 10;
        }

        public Calculadora(int d1)
        {
 
        }

        public Calculadora(int d1, int d2)
        {

        }

        public int Sumar()
        {
            return (dato1 + dato2);
        }
    }
}
