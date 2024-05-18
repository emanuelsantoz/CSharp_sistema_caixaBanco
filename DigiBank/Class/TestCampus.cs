using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Class
{
    internal class TestCampus
    {
        public static string testCampus(string valor)
        {
            if (valor != null && valor != string.Empty)
            {
                return valor;
            }
            else
            {
                Console.WriteLine("CAMPO INVALIDO");
                Console.WriteLine("Por favor, digite novamente: ");
                return preenchendoCampusNovamente();
            }
        }

        private static string preenchendoCampusNovamente()
        {
            string novoCampu = Console.ReadLine();
            return novoCampu;
        }
    }
}
