using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public static class Validacao
    {
        public static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            //int a1 = Convert.ToInt32(cpf[0].ToString());

            if (cpf.Length == 11)
            {
                Console.WriteLine("deu certo");

                for (int i = 10; i >= 2; i--)
                {
                  
                }

                return true;
            }
            else
            {
                return false;
            }

            for (int i = 10; i >= 2; i--)
            {

            }

       
        }
    }
}
