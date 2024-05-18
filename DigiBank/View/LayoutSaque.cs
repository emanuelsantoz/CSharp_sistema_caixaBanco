using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
