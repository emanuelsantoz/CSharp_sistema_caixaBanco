using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Class
{
    internal class Banco
    {
        public Banco()
        {
            this.Name = "DigiBank";
            this.CodigoBanco = "1000222-000";
        }

        public string Name { get; private set; }

        public string CodigoBanco { get; private set; }
    }
}
