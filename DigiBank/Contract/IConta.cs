using DigiBank.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Contract
{
    internal interface IConta
    {
        void Deposistar(double entrada);

        bool Saque(double saida);

        double ConsultarSaldo();
        string GetNumeroAgencia();
        int GetSequencia();

        string GetCodigoBanco();

        string GetNumeroConta();

        List<Extrato> Extratos();
    }
}
