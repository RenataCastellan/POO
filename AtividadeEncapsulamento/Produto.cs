using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEncapsulamento
{
    public class Produto
    {
        public string codigo;
        public string nome;
        private string unidade;
        private double preco;
        public int quantidade;

        public void SetPreco(double valor)
        {
            if (valor > 0)
            {
                this.preco = valor;
            }
            else
            {
                Console.WriteLine("Insira apenas valores positivos!!");
            }
        }

        public double GetPreco() { return preco; }

        public void SetUnidade(int uni)
        {
            if (uni == 1)
            {
                this.unidade = "LT";
            }
            else if (uni == 2)
            {
                this.unidade = "CX";
            }
            else if(uni == 3)
            {
                this.unidade = "KG";
            }
            else if(uni == 4)
            {
                this.unidade = "UN";
            }
            else if(uni == 5)
            {
                this.unidade = "MT";
            }
            else
            {
                Console.WriteLine("Insira um valor válido!");
            }
        }

        public string GetUnidade() { return unidade; }
    }
}
