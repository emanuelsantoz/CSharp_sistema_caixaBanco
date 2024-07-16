using DigiBank.Contract;


namespace DigiBank.Class
{
    internal abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroAgencia = "0001";
            Conta.ContaSquencial++;
            this.Movimentacoes = new List<Extrato>();
        }
        private double SaldoConta { get; set; }
        public string NumeroAgencia { get; protected set; }
        public string NumeroConta { get; protected set; }
        public static int ContaSquencial { get; set; }
        private List<Extrato> Movimentacoes;

        public double ConsultarSaldo()
        {
            return this.SaldoConta;
        }

        public bool Saque(double saida)
        {
            if (this.ConsultarSaldo() < saida)
            {
                return false;
            } else
            {
                DateTime dataAtual = DateTime.Now;
                this.Movimentacoes.Add(new Extrato(dataAtual, "Deposito", -saida));

                this.SaldoConta = this.SaldoConta - saida;
                return true;
            }
        }

        public void Deposistar(double entrada)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Deposito", entrada));
            this.SaldoConta += entrada;
        }

        public string GetCodigoBanco()
        {
            return this.CodigoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetNumeroConta()
        {
            return this.NumeroConta;
        }

        public int GetSequencia()
        {
            return Conta.ContaSquencial;
        }

        public List<Extrato> Extratos()
        {
            return this.Movimentacoes;
        }
    }
}
