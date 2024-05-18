using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutLogin : TestCampus
    {
        public static void TelaLogin(List<Usuario> us)
        {
            Console.Clear();
            
            Console.WriteLine("                                                     ");
            Console.WriteLine("            Digite seu CPF:                          ");
            string cpf = testCampus(Console.ReadLine());
            Console.WriteLine("=====================================================");
            Console.WriteLine("                                                     ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("            Digite sua senha:                        ");
            string password = testCampus(Console.ReadLine());
            Console.WriteLine("=====================================================");


            Usuario usuariolocaal = us.FirstOrDefault(x => x.CPF == cpf && x.Password == password);
            if(usuariolocaal != null)
            {
                // Tela de boas vinda
                LayoutBoasVindas.TelaBoasVidas(usuariolocaal);

                // tela logada
                LayoutLogado.UsuarioLogado(usuariolocaal);
            }
            else
            {
                Console.Clear();

                Console.WriteLine("=====================================================");
                Console.WriteLine("           Cliente não cadastrado                    ");
                Console.WriteLine("=====================================================");
            }
            
        }
    }
}
