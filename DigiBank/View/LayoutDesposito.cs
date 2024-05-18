using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutDesposito: TestCampus
    {
        public static void Deposito(Usuario us)
        {
            LayoutBoasVindas.TelaBoasVidas(us);

            Console.WriteLine("            Digite o valor do Depósito:              ");
            double valor = Convert.ToDouble(testCampus((Console.ReadLine())));
            us.Conta.Deposistar(valor);

            Console.WriteLine("=====================================================");
            Console.WriteLine("            Depósito realizado com sucesso!          ");

            LayoutPosAcoes.VoltarPosAcao(us);
        }
    }
}
