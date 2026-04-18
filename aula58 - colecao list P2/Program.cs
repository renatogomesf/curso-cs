// aula58 - colecao list P2

namespace Aula58;

public class Aula58
{
    public static void Main()
    {

        List<string> carros = new List<string>();

        List<string> carros2 = new List<string>();

        carros.Add("golf");
        carros.Add("hrv");
        carros.Add("focus");
        carros.Add("argo");
        carros.Add("hrv");

        // Insert: insere um elemento em uma posição específica da lista. Ele desloca os elementos existentes para a direita, a partir da posição especificada, para acomodar o novo elemento.
        carros.Insert(2, "corolla");

        // LastIndexOf: retorna o índice da última ocorrência de um elemento específico na lista. Se o elemento for encontrado, ele retorna o índice (baseado em zero) da última ocorrência do elemento; caso contrário, ele retorna -1.
        Console.WriteLine(carros.LastIndexOf("hrv"));

        // Remove: remove a primeira ocorrência de um elemento específico da lista. Ele retorna true se o elemento for encontrado e removido com sucesso, e false caso contrário.
        carros.Remove("argo");

        // RemoveAt: remove o elemento em uma posição específica da lista. Ele desloca os elementos subsequentes para a esquerda, preenchendo a lacuna deixada pelo elemento removido.
        //carros.RemoveAt(0);

        // Reverse: inverte a ordem dos elementos na lista. O primeiro elemento se torna o último, o segundo elemento se torna o penúltimo, e assim por diante, até que todos os elementos tenham sido invertidos.
        carros.Reverse();

        // Sort: classifica os elementos da lista em ordem crescente. Ele usa a implementação de comparação padrão para determinar a ordem dos elementos, o que significa que os elementos devem ser comparáveis para serem classificados corretamente.
        carros.Sort();

        // Count: retorna o número de elementos atualmente presentes na lista. Ele fornece uma contagem precisa dos elementos, mesmo que a lista tenha sido modificada por meio de adições ou remoções.
        Console.WriteLine(carros.Count);

        // Capacity: retorna a capacidade atual da lista, ou seja, o número de elementos que a lista pode conter antes de precisar ser redimensionada. A capacidade é geralmente maior do que o número de elementos atualmente presentes na lista, pois a lista é redimensionada automaticamente quando necessário para acomodar novos elementos.
        Console.WriteLine(carros.Capacity);

        // redefinir a capacidade da lista.
        carros.Capacity = 15;
        Console.WriteLine(carros.Capacity);


        foreach (string item in carros)
        {
            Console.WriteLine($"carros: {item}");
        }
    }
}
