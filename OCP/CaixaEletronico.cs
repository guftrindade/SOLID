using SOLID.OCP.Display;

namespace SOLID.OCP
{
    public static class CaixaEletronico
    {
        public static void Operacoes()
        {
            Menu.Opcoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;

            var debitoConta = DadosOperacao.DadosDebito();

            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em Conta Corrente");
                    retorno = debitoConta.DebitarContaCorrente();
                    break;
                case '2':
                    Console.WriteLine("Efetuando operação em Conta Poupança");
                    retorno = debitoConta.DebitarContaPoupanca();
                    break;
                case '3':
                    Console.WriteLine("Efetuando operação em Conta Investimento");
                    retorno = debitoConta.DebitarContaInvestimento();
                    break;

                    //Para criação de mais um tipo de conta, basta acrescentar aqui
            }

            Menu.RetornoTransacao(retorno);
        }
    }
}
