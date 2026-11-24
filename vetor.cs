
using System;

public class Program
{
    public static void Main()
    {
        String[] alunos = new String[6];
        String aluno_busca;

        // Cadastro dos alunos
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Insira o nome do aluno: ");
            alunos[i] = Console.ReadLine();
        }

        // Exibição dos alunos cadastrados
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(alunos[i]);
        }

        // Busca de um aluno
        Console.WriteLine("Digite o nome que você deseja buscar: ");
        aluno_busca = Console.ReadLine();

        for (int i = 0; i <= 5; i++)
        {
            if (alunos[i] == aluno_busca)
            {
                Console.WriteLine("Aluno Encontrado!");
                Console.WriteLine("O aluno " + aluno_busca +
                    " foi encontrado na posição " + i + " do vetor!");
            }
        }

        // Perguntar se deseja trocar algum nome
        Console.WriteLine("Deseja trocar algum nome do vetor? (S/N)");
        String resposta = Console.ReadLine();

        if (resposta == "S")
        {
            Console.WriteLine("Digite a posição do aluno que deseja trocar (0 a 5): ");
            int posicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo nome: ");
            alunos[posicao] = Console.ReadLine();

            Console.WriteLine("Nome alterado com sucesso!");

            // Exibir vetor atualizado
            Console.WriteLine("Lista atualizada de alunos:");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(alunos[i]);
            }
        }
        else
        {
            Console.WriteLine("Nenhum nome foi alterado.");
        }
    }
}
