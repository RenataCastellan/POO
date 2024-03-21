using AtividadeEncapsulamento;

int opcao = 1;
List<Produto> prod = new List<Produto>();
Produto produto = new Produto();
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("----------------- CADASTRO DE PRODUTO -----------------");
    Console.ResetColor();
    Console.WriteLine();



    Console.Write("Insira o código: ");
    produto.codigo = Console.ReadLine();
    Console.Write("Insira o nome: ");
    produto.nome = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("---- TIPOS DE UNIDADE ----");
    Console.WriteLine("1 - LT");
    Console.WriteLine("2 - CX");
    Console.WriteLine("3 - KG");
    Console.WriteLine("4 - UN");
    Console.WriteLine("5 - MT");
    Console.WriteLine();
    Console.ResetColor();
    Console.Write("Insira a unidade do produto: ");
    int unidade = int.Parse(Console.ReadLine());
    produto.SetUnidade(unidade);
    Console.Write("Insira o preço do produto: ");
    double preco = double.Parse(Console.ReadLine());
    produto.SetPreco(preco);
    Console.Write("Insira a quantidade do produto: ");
    produto.quantidade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    prod.Add(produto);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Deseja cadastrar outro produto?");
    Console.ResetColor();
    Console.WriteLine("1 - SIM");
    Console.WriteLine("0 - NÃO");
    Console.Write("Informe a opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

} while (opcao == 1);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("------------- PRODUTOS CADASTRADOS -------------");
Console.ResetColor();

//lista todos os produtos

foreach (Produto produtos in prod)
{
    Console.WriteLine("Codigo: " + produtos.codigo);
    Console.WriteLine("Nome: " + produtos.nome);
    Console.WriteLine("Unidade: " + produtos.GetUnidade());
    Console.WriteLine("Preço: " + produtos.GetPreco());
    Console.WriteLine("Quantidade: " + produtos.quantidade);
    Console.WriteLine();
}

//remove um produto

Console.WriteLine("Digite o id: ");
string id = Console.ReadLine();

foreach (Produto p in prod)
{
    if(produto.codigo == id)
    {
        prod.Remove(produto);
        break;
    }
}