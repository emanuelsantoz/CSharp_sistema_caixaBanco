using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Contract
{
    internal interface IUsuario
    {
        string Name { get; set; }
        string Password { get; set; }
        string CPF { get; set; }
    }
}
