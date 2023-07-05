namespace SOLID.OCP
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            return debitoConta.FormatarTransacao();
        }
    }
}
