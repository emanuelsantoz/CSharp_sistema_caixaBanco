using DigiBank.Class;


namespace DigiBank.View
{
    internal class LayoutSaque:TestCampus
    {
        public static void Saque(Usuario us)
        {
            LayoutBoasVindas.TelaBoasVidas(us);

            Console.WriteLine("            Digite o valor para o saque              ");
            double valor = Convert.ToDouble(testCampus((Console.ReadLine())));
            us.Conta.Saque(valor);
            Console.WriteLine("=====================================================");

            LayoutPosAcoes.VoltarPosAcao(us);
        }
    }
}
