using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabN_3_Diego_Torres
{
    internal class BancoCuenta
    {
        public decimal Saldo { get; set; }
        public List<decimal> HistoDepositos { get; set; }
        public List<decimal> HistoRetiros { get; set; }

        public BancoCuenta(decimal montoInicial)
        {
            Saldo = montoInicial;
            HistoRetiros = new List<decimal>();
            HistoDepositos = new List<decimal>();
        }
        //metodo para hacer los depositos
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                HistoDepositos.Add(monto);
            }
        }
        //metodo para hacer los retiros
        public bool Retirar(decimal monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                HistoRetiros.Add(monto);
                return true;
            }
            return false;
        }
    }
}
