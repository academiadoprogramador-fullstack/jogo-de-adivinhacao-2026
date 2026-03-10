// Objetivos / Passo-a-passo

// v1
// 1. Nosso jogo deve aceitar o input do jogador e exibir o valor digitado
// 2. Nosso jogo deve gerar um número aleatório
// 3. Nosso jogo deve validar a tentativa do jogador e exibir uma mensagem
// 4. Nosso jogo deve permitir múltiplas tentativas

using System; // biblioteca padrão do sistema com classes genéricas
using System.Security.Cryptography; // biblioteca padrão do sistema relacionada a criptografia

while (true == true)
{
    Console.Clear();

    Console.WriteLine("------------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("------------------------------------");

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    Console.Write("Digite um número entre 1 e 20: ");
    string? chute = Console.ReadLine();

    int numeroDigitado = Convert.ToInt32(chute);

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Parabéns, você acertou!");
        Console.WriteLine("------------------------------------");
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("O número digitado foi maior que o número secreto!");
        Console.WriteLine("------------------------------------");
    }
    else
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("O número digitado foi menor que o número secreto!");
        Console.WriteLine("------------------------------------");
    }

    Console.Write("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar?.ToUpper() != "S")
    {
        break;
    }

    Console.ReadLine();
}