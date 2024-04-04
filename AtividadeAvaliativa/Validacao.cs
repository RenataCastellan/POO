using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public static class Validacao
    {
        public static bool ValidaCPF(string cpf)
        {
            string tempCpf;
            int soma;
            int resto;
            int digito;
            cpf = cpf.Replace(".", "").Replace("-", "");

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            if (cpf.Length == 11)
            {
                int[] op1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] op2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * op1[i];
                }

                resto = soma % 11;
                
                if (resto < 2)
                {
                    digito = 0;
                }
                else
                {
                    digito = soma % 11;
                    digito = 11 - digito;
                }


                if (cpf[9].ToString() == digito.ToString())
                {
                    soma = 0;
                    tempCpf = cpf.Substring(0, 10);
                    for (int i = 0; i < 10; i++)
                    {
                        soma += int.Parse(tempCpf[i].ToString()) * op2[i];
                    }

                    resto = soma % 11;

                    if (resto < 2)
                    {
                        digito = 0;
                    }
                    else
                    {
                        digito = soma % 11;
                        digito = 11 - digito;
                    }

                    if (cpf[10].ToString() == digito.ToString())
                    {
                        Console.WriteLine("CPF VÁLIDO");
                    }
                    else
                    {
                        Console.WriteLine("cpf invalido");
                    }
                }
                else
                {
                    Console.WriteLine("cpf invalido");
                }

                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
