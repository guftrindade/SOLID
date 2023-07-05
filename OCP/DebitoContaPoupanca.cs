using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta poupanca.
            return debitoConta.FormatarTransacao();
        }
    }
}
