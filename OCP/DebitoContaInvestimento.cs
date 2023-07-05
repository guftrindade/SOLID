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
