using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Class
{
    internal class Extrato
    {
        public Extrato(DateTime data, string des, double valor)
        {
            Data = data;
            Descricao = des;
            this.Valor = valor;
        }

        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
