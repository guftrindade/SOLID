namespace SOLID.LSP
{
    public static class CalculoArea
    {
        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);
            var ret = new Retangulo(5, 10);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }

        private static void ObterAreaParalelogramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }
    }
}
