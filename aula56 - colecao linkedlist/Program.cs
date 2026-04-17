// aula56 - colecao linkedlist

namespace Aula56;

public class Aula56
{
    public static void Main()
    {
        // linkedList: é uma coleção de elementos onde cada elemento (nó) contém uma referência para o próximo elemento na lista. Isso permite que a lista seja facilmente modificada, pois os elementos podem ser inseridos ou removidos sem a necessidade de realocar toda a estrutura de dados, como acontece em um array.

        // declaração: LinkedList<tipo> nome-da-variavel = new LinkedList<tipo>();
        LinkedList<string> transp = new LinkedList<string>();

        // AddFirst: adiciona um elemento no início da lista. O novo elemento se torna o primeiro elemento da lista, e o elemento que estava anteriormente no início se torna o segundo elemento.
        transp.AddFirst("carro");
        transp.AddFirst("aviao");
        transp.AddFirst("navio");
        transp.AddFirst("motocicleta");

        // AddLast: adiciona um elemento no final da lista. O novo elemento se torna o último elemento da lista, e o elemento que estava anteriormente no final se torna o penúltimo elemento.
        transp.AddLast("bicicleta");

        // AddAfter: adiciona um elemento após um elemento específico na lista. O novo elemento é inserido imediatamente após o elemento especificado, e os elementos subsequentes são deslocados para acomodar o novo elemento.
        // AddAfter requer dois parâmetros: o primeiro é o nó (através do LinkedListNode) após o qual o novo elemento deve ser adicionado, e o segundo é o valor do novo elemento a ser adicionado.
        LinkedListNode<string> node = transp.Find("aviao");
        transp.AddAfter(node, "patinete");

        // AddBefore: adiciona um elemento antes de um elemento específico na lista. O novo elemento é inserido imediatamente antes do elemento especificado, e os elementos subsequentes são deslocados para acomodar o novo elemento.
        transp.AddBefore(node, "patins");

        // Clear(): remove todos os elementos da lista, deixando-a vazia.
        //transp.Clear();

        // Find(): procura por um elemento específico na lista e retorna o primeiro nó que contém esse elemento. Se o elemento for encontrado, ele retorna um LinkedListNode que representa o nó onde o elemento está localizado. Se o elemento não for encontrado, ele retorna null.
        transp.Find("carro");

        // Next: é uma propriedade de um LinkedListNode que retorna o próximo nó na lista. Se o nó atual for o último nó da lista, a propriedade Next retornará null.
        var item1 = transp.Find("carro").Next;

        // Previous: é uma propriedade de um LinkedListNode que retorna o nó anterior na lista. Se o nó atual for o primeiro nó da lista, a propriedade Previous retornará null.
        var item2 = transp.Find("carro").Previous;

        // Value: é uma propriedade de um LinkedListNode que retorna o valor armazenado no nó. O tipo do valor é o mesmo tipo especificado para a LinkedList.
        var item3 = transp.Find("carro").Value;

        // Remove(): remove a primeira ocorrência de um elemento específico da lista. Se o elemento for encontrado e removido com sucesso, ele retorna true; caso contrário, retorna false.
        transp.Remove("navio");

        transp.RemoveFirst(); // Remove o primeiro elemento da lista. Se a lista estiver vazia, ele lança uma exceção.
        transp.RemoveLast(); // Remove o último elemento da lista. Se a lista estiver vazia, ele lança uma exceção.

        foreach (string item in transp)
        {
            Console.WriteLine(item);
        }
    }
}