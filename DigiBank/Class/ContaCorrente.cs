using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Class
{
    internal class ContaCorrente: Conta
    {
        public ContaCorrente() {
            this.NumeroConta = "00" + Conta.ContaSquencial;
        }
    }
}
