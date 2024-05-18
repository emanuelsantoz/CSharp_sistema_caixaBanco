using DigiBank.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Class
{
    internal class Usuario : IUsuario
    {   
        public string Name {  get; set; }

        public string Password { get; set; }

        public string CPF { get; set; }
        public IConta Conta { get; set; }

        public bool CadastrarUsuario(string name, string password, string cpf)
        {
            
            if (name != null && password != null && cpf != null && 
                name != string.Empty && password != string.Empty && cpf != string.Empty)
            {
                this.Name = name;
                this.Password = password;
                this.CPF = cpf;
                Console.WriteLine("Conta cadastrada com sucesso!");

                return true;
            } else
            {
                Console.WriteLine("Dados invalidos, Por favor informe os dados corretamente!");
                return  false;
            }
        }

        public static implicit operator List<object>(Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}
