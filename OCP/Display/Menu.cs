namespace SOLID.OCP.Display
{
    public static class Menu
    {
        public static void Opcoes()
        {
            Console.Clear();
            Console.WriteLine("Caixa Eletrônico SOLID");
            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque Conta Corrente");
            Console.WriteLine("2 - Saque Conta Poupança");
            Console.WriteLine("3 - Saque Conta Investimento");
        }

        public static void RetornoTransacao(string transacao)
        {
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transação: " + transacao);
            Console.ReadKey();
        }
    }
}
