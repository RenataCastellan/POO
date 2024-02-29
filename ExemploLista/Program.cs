/*
List<string> nomes = new List<string>();
nomes.Add("Jão");
nomes.Add("Maria");
nomes.Insert(0, "Lucia"); //insere o valor numa determinada posição
nomes.Remove("Jão"); //remove o valor pelo nome
nomes.RemoveAt(0); //remove o valor pelo valor

foreach (string s in nomes) //percorrer toda a lista
{
    Console.WriteLine(s);
}
*/

using ExemploLista;
using System.Drawing;

int opcao = 1;
List<Aluno> alunos = new List<Aluno>();
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("CADASTRO DE ALUNO");
    Console.ResetColor();
    Console.WriteLine();
    Aluno aluno = new Aluno();
    Console.Write("Insira o nome do aluno: ");
    aluno.nome = Console.ReadLine();
    Console.Write("Digite o CPF: ");
    aluno.cpf = Console.ReadLine();
    Console.Write("Informe o email: ");
    aluno.email = Console.ReadLine();
    Console.WriteLine();


    alunos.Add(aluno);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Deseja cadastrar outro aluno?");
    Console.ResetColor();
    Console.WriteLine("1 - SIM");
    Console.WriteLine("0 - NÃO");
    Console.Write("Informe a opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

} while (opcao == 1);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("------------- ALUNOS CADASTRADOS -------------");
Console.ResetColor();

foreach (Aluno estudante in alunos) //percorrer toda a lista
{
    Console.WriteLine("Nome: " + estudante.nome);
    Console.WriteLine("cpf: " + estudante.cpf);
    Console.WriteLine("email: " + estudante.email);
    Console.WriteLine();
}