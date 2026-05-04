using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taller4P4a
{
    class Caja
    {
        public double ValorIngresado, Saldo, Sum = 0, ValorPago, Devuelta, Ingresos = 0, Egresos = 0;

        public bool PermitirSaldo(double valor)
        {
            if (valor >= 50000)
                return false;
            else
                return true;
        }
        public void SumaProductos(double Valor)
        {
            Sum += Valor;
        }
        public void QuitaProductos(double Valor)
        {
            Sum -= Valor;
        }

        public bool PosiblePago(double Valor)
        {
            if (Valor > Saldo)
                return false;
            else
                return true;
        }
        public void EfectuarPago(double VPagado, double VDevuelto)
        {
            Ingresos += - VPagado + VDevuelto;
            Saldo += -VPagado + VDevuelto;
        }
    }
}
