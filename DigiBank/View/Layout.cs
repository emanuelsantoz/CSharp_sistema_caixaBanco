using DigiBank.Class;


namespace DigiBank.View
{
    internal class Layout
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            Console.Clear();
            do
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Clear();
                Console.WriteLine("                                                     ");
                Console.WriteLine("            Digite a Opção desejada:                 ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            1 - Criar Conta                          ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            2 - Entrar com CPF e Senha               ");
                Console.WriteLine("=====================================================");

                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        usuarios.Add(LayoutCriarConta.TelaCriarConta());
                        break;
                    case 2:
                        LayoutLogin.TelaLogin(usuarios);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
            while (opcao != 5); ;

        }
    }
}
