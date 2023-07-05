namespace SOLID.OCP.Display
{
    public static class DadosOperacao
    {
        public static DebitoConta DadosDebito()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("Digite a Conta");
            var conta = Console.ReadLine();
            Console.WriteLine("Digite o Valor");
            var valor = Convert.ToDecimal(Console.ReadLine());

            var debitoConta = new DebitoConta()
            {
                NumeroConta = conta,
                Valor = valor
            };

            return debitoConta;
        }
    }
}
