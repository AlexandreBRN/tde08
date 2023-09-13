string continuar;
do{
    Console.WriteLine("Informe o nome do estudante ")
    string nome = Console.ReadLine();
    Console.WriteLine("Informe primeira nota: ")
    double nota1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe segunda nota: ")
    double nota2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe terceira nota: ")
    double nota3 = Convert.ToDouble(Console.ReadLine());

    double media = (nota1 + nota2 + nota 3) / 3;

    string status;
    if (media >= 7)
    {
        status = "aprovado"
    }
    else
    {
        status = "reprovado"
    }

    Console.WriteLine("\n relatorio de desempenho");
    Console.WriteLine("Nome do aluno: " + nome);
    Console.WriteLine($"notas: {nota1}, {nota2}, {nota3} ");
    Console.WriteLine("media + " + media);
    Console.WriteLine("status: " + status);


    Console.WriteLine("deseja gerar um novo relatorio? (S/N)");
    continuar = Console.ReadLine() .ToLower();
}while(continuar = "s");
 Console.WriteLine("obrigado por usar o gerador de relatório de desempenho");
