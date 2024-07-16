using DigiBank.Class;

namespace DigiBank.View
{
    internal class LayoutCriarConta : TestCampus
    {
        public static Usuario TelaCriarConta()
        {
            ContaCorrente co = new ContaCorrente();
            Usuario usuario = new Usuario();

            Console.Clear();

            Console.WriteLine("                                                     ");
            Console.WriteLine("            Digite seu nome:                         ");
            string nome = testCampus(Console.ReadLine());
            Console.WriteLine("=====================================================");
            Console.WriteLine("            Digite o CPF:                            ");
            string cpf = testCampus(Console.ReadLine());
            Console.WriteLine("=====================================================");
            Console.WriteLine("            Digite sua senha:                        ");
            string senha = testCampus(Console.ReadLine());
            Console.WriteLine("=====================================================");

            usuario.CadastrarUsuario(nome, senha, cpf);
            usuario.Conta = co;

            return usuario;
        }
    }
}
