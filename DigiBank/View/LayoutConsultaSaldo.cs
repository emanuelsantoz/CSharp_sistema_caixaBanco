using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.View
{
    internal class LayoutConsultaSaldo
    {
        public static void Saldo(Usuario us)
        {
            LayoutBoasVindas.TelaBoasVidas(us);

            Console.WriteLine($"    A conta {us.Conta.GetNumeroConta()} | seu saldo é de:  {us.Conta.ConsultarSaldo()}");
            Console.WriteLine("=====================================================");
        }
    }
}
