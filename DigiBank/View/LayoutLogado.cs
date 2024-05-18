using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutLogado: TestCampus
    {
        private static int opcao = 0;
        public static void UsuarioLogado(Usuario usLogado) {
            
            do
            {
                Console.WriteLine("            Digite a Opção desejada:                 ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            1 - Realizar um Depósito:                ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            2 - Realizar um Saque:                   ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            3 - Consultar Saldo                      ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            4 - Extrato                              ");
                Console.WriteLine("=====================================================");
                Console.WriteLine("            5 - Sair da conta                         ");
                Console.WriteLine("=====================================================");
                opcao = Convert.ToInt16((testCampus(Console.ReadLine())));
                Console.WriteLine(opcao);

                switch (opcao)
                {
                    case 1:
                        LayoutDesposito.Deposito(usLogado);
                        break;
                    case 2:
                        LayoutSaque.Saque(usLogado);
                        break;
                    case 3:
                        LayoutConsultaSaldo.Saldo(usLogado);
                        break;
                    case 4:
                        LayoutExtrato.Extrato(usLogado);
                        break;
                    case 5:
                        Layout.TelaPrincipal();
                        break;
                }
            }
            while (opcao != 5);
        }
    }
}
