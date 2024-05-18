using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutBoasVindas: TestCampus
    {
        
        public static void TelaBoasVidas(Usuario usLogado)
        {
            Console.Clear();

            Console.WriteLine(" ");
            Console.WriteLine($"            Seja bem-vindo - {usLogado.Name} | Número da conta - {usLogado.Conta.GetNumeroAgencia()} | Sequencia - {usLogado.Conta.GetSequencia()}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
