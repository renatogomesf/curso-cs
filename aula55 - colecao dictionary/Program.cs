// aula55 - colecao dictionary

namespace Aula55;

public class Aula55
{
    public static void Main()
    {
        // coleção dictionary: é uma coleção de pares chave-valor, onde cada chave é única e está associada a um valor. parecido com json.

        // declarãção: Dictionary<tipo-chave, tipo-valor> nome-da-variavel = new Dictionary<tipo-chave, tipo-valor>();
        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        // Add: adiciona um par chave-valor à coleção. Se a chave já existir, ele lançará uma exceção.
        veiculos.Add(10, "carro");
        veiculos.Add(5, "aviao");
        veiculos.Add(0, "navio");
        veiculos.Add(20, "moto");
        veiculos.Add(15, "patinete");

        Console.WriteLine($"tamanho dictionary: {veiculos.Count}");

        // Clear(): remove todos os pares chave-valor da coleção, deixando-a vazia.
        //veiculos.Clear();
        //Console.WriteLine($"tamanho dictionary após clear: {veiculos.Count}");

        // ContainsKey(): verifica se a coleção contém uma chave específica. Retorna true se a chave existir, caso contrário, retorna false.
        if (veiculos.ContainsKey(10))
        {
            Console.WriteLine("chave existe");
        }
        else
        {
            Console.WriteLine("chave NÃO existe");
        }

        // ContainsValue(): verifica se a coleção contém um valor específico. Retorna true se o valor existir, caso contrário, retorna false.
        if (veiculos.ContainsValue("carro"))
        {
            Console.WriteLine("valor existe");
        }
        else
        {
            Console.WriteLine("valor NÃO existe");
        }

        // Remove(): remove o par chave-valor associado a uma chave específica. Retorna true se a remoção for bem-sucedida, caso contrário, retorna false.
        veiculos.Remove(0);

        if (veiculos.ContainsKey(0))
        {
            Console.WriteLine("chave existe");
        }
        else
        {
            Console.WriteLine("chave NÃO existe");
        }

        // atualiza/modifica um valor associado a uma chave específica. Se a chave não existir, ele adicionará um novo par chave-valor à coleção. o acesso a um valor é parecido com o acesso a um array, usando colchetes [] e a chave correspondente.
        veiculos[15] = "bicicleta";


        // para percorrer os pares chave-valor em um Dictionary, você precisa tipar a variável do foreach como KeyValuePair<tipo-chave, tipo-valor>. O tipo KeyValuePair é uma estrutura que representa um par chave-valor em um Dictionary.
        foreach (KeyValuePair<int, string> item in veiculos)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}