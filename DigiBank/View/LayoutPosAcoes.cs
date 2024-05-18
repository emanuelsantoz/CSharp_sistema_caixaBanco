using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutPosAcoes
    {
        private static int opcao = 0;
        public static void VoltarPosAcao(Usuario us)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            
            Console.WriteLine("           Dígite a opção desejada                   ");
            Console.WriteLine(" ");

            Console.WriteLine("      1 -  Deseja voltar para tela principal         ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("      2 -  Sair da conta                             ");
            Console.WriteLine("=====================================================");
            opcao = int.Parse(Console.ReadLine());
            

            switch (opcao) {
                case 1:
                    LayoutLogado.UsuarioLogado(us);
                    
                    break;
                case 2:
                    Layout.TelaPrincipal();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            
        }
    }
}
