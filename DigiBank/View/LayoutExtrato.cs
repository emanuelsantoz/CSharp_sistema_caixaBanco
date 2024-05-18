using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutExtrato
    {
        public static void Extrato(Usuario us)
        {
            Console.Clear();

            LayoutBoasVindas.TelaBoasVidas(us);
            if (us.Conta.Extratos().Any()){

                foreach (Extrato extrato in us.Conta.Extratos())
                {
                    Console.WriteLine($"        Data: {extrato.Data.ToString("d")}                            ");
                    Console.WriteLine($"        Tipo de Movimentação: {extrato.Descricao}       ");
                    Console.WriteLine($"        Valor: {extrato.Valor}                          ");
                }
            }
            else
            {
                Console.WriteLine("        Não há extrato a ser exibido!     ");
                Console.WriteLine("==========================================");
            }


            LayoutPosAcoes.VoltarPosAcao(us);
        }
    }
}
