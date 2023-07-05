using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta investimento.
            var teste = debitoConta;

            return debitoConta.FormatarTransacao();
        }
    }
}
