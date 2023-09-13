class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite o nome do estudante: ");
            string nome = Console.ReadLine();
            
            double[] notas = new double[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite a nota {i + 1} do estudante: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            double media = CalcularMedia(notas);
            string resultado = VerificarAprovacao(media);
            
            Console.WriteLine("\nRelatório:");
            Console.WriteLine($"Nome do estudante: {nome}");
            Console.WriteLine($"Notas: {string.Join(", ", notas)}");
            Console.WriteLine($"Média: {media:F2}");
            Console.WriteLine($"Resultado: {resultado}\n");
            
            Console.Write("Deseja gerar um novo relatório para outro estudante? (S/N): ");
            string continuar = Console.ReadLine().ToUpper();
            
            if (continuar != "S")
            {
                break;
            }
        }
    }

    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Length;
    }

    static string VerificarAprovacao(double media)
    {
        if (media >= 7.0)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}
