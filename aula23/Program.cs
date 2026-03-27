
namespace aula23;

public class Program
{
    public static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

        // "Random": gerador de números aleatórios
        Random random = new Random();

        for (int i = 0; i < vetor1.Length; i++)
        {
            // "Next()": método para gerar um número aleatório. passando um valor, ele gera um número aleatório entre 0 (incluindo zero) e o valor passado (excluindo ele. um número antes). caso não seja passado um valor, ele gera um número aleatório entre 0 e o valor máximo do tipo de dado (int.MaxValue).
            // "Next('valor mínimo','valor máximo')": gera um número aleatório entre o valor mínimo (incluindo ele) e o valor máximo (excluindo ele. um número antes).
            vetor1[i] = random.Next(50);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");

        Console.WriteLine("valores vertor 1");
        foreach (var item in vetor1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // BinarySearch: método para realizar uma busca binária em um array. Ele retorna a posição do elemento encontrado ou um número negativo se o elemento não for encontrado. Para que a busca binária funcione corretamente, o array deve estar ordenado.
        Console.WriteLine("BinarySearch");
        int procurado = 22;
        int posicao = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine($"valor {procurado} na posição: {posicao}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // Copy: método para copiar elementos de um array para outro. Ele recebe o array de origem, o array de destino e a quantidade de elementos a serem copiados.
        Console.WriteLine("Copy - vetor1 copiado para vetor2");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (var item in vetor2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // CopyTo: método para copiar elementos de um array para outro. Ele é um método de instância, ou seja, é chamado a partir do array de origem. Ele recebe o array de destino e a posição inicial no array de destino onde os elementos serão copiados.
        Console.WriteLine("CopyTo - vetor1 copiado para vetor3");
        vetor1.CopyTo(vetor3, 0);
        foreach (var item in vetor3)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // GetLongLength: método para obter o número de elementos em uma dimensão de um array. Ele recebe a dimensão como parâmetro (0 para a primeira dimensão, 1 para a segunda, etc.).
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine($"Quantidade de elementos do vetor1 {qtdeElementosVetor}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // GetLowerBound: método para obter o índice do primeiro elemento de uma dimensão de um array. Ele recebe a dimensão como parâmetro (0 para a primeira dimensão, 1 para a segunda, etc.).
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine($"Menor índice do vetor1 {MenorIndiceVetor}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // GetUpperBound: método para obter o índice do último elemento de uma dimensão de um array. Ele recebe a dimensão como parâmetro (0 para a primeira dimensão, 1 para a segunda, etc.).
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine($"Maior índice do vetor1 {MaiorIndiceVetor}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // GetValue: método para obter o valor de um elemento em um array. Ele recebe os índices do elemento como parâmetros.
        Console.WriteLine("GetValue");
        int valorVetor1 = (int)vetor1.GetValue(2);
        int valorMatriz = (int)matriz.GetValue(1, 3);
        Console.WriteLine($"Valor do vetor1 na posição 2: {valorVetor1}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // IndexOf: método para obter o índice da primeira ocorrência de um elemento em um array. Ele recebe o array e o elemento a ser procurado como parâmetros. Ele retorna o índice do elemento encontrado ou -1 se o elemento não for encontrado.
        Console.WriteLine("IndexOf");
        int indiceVetor1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine($"Índice do valor 3 no vetor1: {indiceVetor1}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // LastIndexOf: método para obter o índice da última ocorrência de um elemento em um array. Ele recebe o array e o elemento a ser procurado como parâmetros. Ele retorna o índice do elemento encontrado ou -1 se o elemento não for encontrado.
        Console.WriteLine("LastIndexOf");
        int indiceVetor1Last = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine($"Índice do valor 3 no vetor1: {indiceVetor1Last}");
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // Reverse: método para inverter a ordem dos elementos em um array. Ele recebe o array como parâmetro.
        Console.WriteLine("Reverse - vetor1 invertido");
        Array.Reverse(vetor1);
        foreach (var item in vetor1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");

        // SetValue: método para definir o valor de um elemento em um array. Ele recebe o valor a ser definido e os índices do elemento como parâmetros.
        vetor2.SetValue(100, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("SetValue - vetor2 com todos os valores zerados");
        foreach (var item in vetor2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");


        // Sort: método para ordenar os elementos de um array. Ele recebe o array como parâmetro.
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        Console.WriteLine("Sort - vetor1");
        foreach (var item in vetor1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nSort - vetor2");
        foreach (var item in vetor2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nSort - vetor3");
        foreach (var item in vetor3)
        {
            Console.WriteLine(item);
        }
    }
}
