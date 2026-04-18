// aula57 - colecao list P1

namespace Aula57;

public class Aula57
{
    public static void Main()
    {
        // List: é uma coleção de elementos que armazena uma sequência de itens do mesmo tipo. Ela é baseada em um array dinâmico, o que significa que pode crescer ou diminuir conforme necessário para acomodar os elementos adicionados ou removidos.

        // declaração: List<tipo> nome-da-variavel = new List<tipo>();
        List<string> carros = new List<string>();

        List<string> carros2 = new List<string>();


        // Add: adiciona um elemento ao final da lista. O novo elemento se torna o último elemento da lista, e os elementos anteriores permanecem inalterados.
        carros.Add("golf");
        carros.Add("hrv");
        carros.Add("focus");
        carros.Add("argo");

        foreach (string item in carros)
        {
            Console.WriteLine($"carros: {item}");
        }

        Console.WriteLine("---------------------------------------------------------------------");

        // AddRange: adiciona os elementos de uma coleção ao final da lista. Os elementos da coleção são adicionados na ordem em que aparecem na coleção, e os elementos anteriores da lista permanecem inalterados.
        carros2.AddRange(carros);

        foreach (string item in carros2)
        {
            Console.WriteLine($"carros 02: {item}");
        }

        // Clear(): remove todos os elementos da lista, deixando-a vazia.
        carros2.Clear();

        // Contains: verifica se um elemento específico está presente na lista. Ele retorna true se o elemento for encontrado na lista e false caso contrário.
        carros.Contains("golf");

        // IndexOf: retorna o índice da primeira ocorrência de um elemento específico na lista. Se o elemento for encontrado, ele retorna o índice (baseado em zero) do primeiro elemento encontrado; caso contrário, ele retorna -1.
        Console.WriteLine(carros.IndexOf("argo"));
    }
}