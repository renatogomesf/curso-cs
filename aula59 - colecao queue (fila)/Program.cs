// aula59 - colecao queue (fila)

namespace Aula59;

public class Aula59
{
    public static void Main()
    {
        // Queue: é uma coleção que representa uma fila, onde os elementos são inseridos no final da fila e removidos do início da fila. Ele segue o princípio FIFO (First In, First Out), ou seja, o primeiro elemento a ser inserido é o primeiro a ser removido.

        // Declaração: Queue<tipo> nomeDaFila = new Queue<tipo>();
        Queue<string> veiculos = new Queue<string>();

        // Enqueue: adiciona um elemento ao final da fila. Ele insere o elemento na posição mais recente da fila, seguindo a ordem de chegada dos elementos.
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        // Conteins: verifica se um elemento específico está presente na fila. Ele retorna true se o elemento for encontrado na fila, e false caso contrário.
        veiculos.Contains("Navio");

        // Clear: remove todos os elementos da fila, deixando-a vazia. Ele limpa a fila completamente, removendo todos os elementos e redefinindo o estado da fila para o estado inicial.
        //veiculos.Clear();

        // remove o primeiro elemento da fila, ou seja, o elemento que foi inserido primeiro. Ele retorna o elemento removido da fila.
        Console.WriteLine($"Elemento removido: {veiculos.Dequeue()}");
        Console.WriteLine("-------------------------------------------------------------");

        // Peek: retorna o elemento no início da fila sem removê-lo. Ele permite que você visualize o próximo elemento a ser removido da fila, sem modificar a estrutura da fila.
        Console.WriteLine($"Primeiro elemento: {veiculos.Peek()}");
        Console.WriteLine("-------------------------------------------------------------");

        foreach (string item in veiculos)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------------------------------");

        while (veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine($"tamanho fila: {veiculos.Count}");
    }
}