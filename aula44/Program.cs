
namespace aula44;

public class Aula44
{
    public static void Main()
    {
        // variável "c1" tipada com o struct "Carro"
        Carro c1;

        // Atribuição de valores aos campos do struct "Carro" para a variável "c1". aqui o construtor não é chamado, pois o struct foi declarado sem o uso do operador "new". os campos do struct são inicializados diretamente.
        c1.marca = "Ford";
        c1.modelo = "Mustang";
        c1.cor = "Vermelho";

        Console.WriteLine(c1.marca);
        Console.WriteLine(c1.modelo);
        Console.WriteLine(c1.cor);
        c1.ExibirInformacoes();

        Console.WriteLine("\n---------------------------------------------------------------\n");

        // variável "c2" tipada com o struct "Carro" e inicializada usando o construtor. aqui o construtor é chamado para inicializar os campos do struct "Carro" com os valores fornecidos.
        Carro c2 = new Carro("Chevrolet", "Camaro", "Azul");

        Console.WriteLine(c2.marca);
        Console.WriteLine(c2.modelo);
        Console.WriteLine(c2.cor);
        c2.ExibirInformacoes();
    }
}

// Structs (NÃO É CLASSE) são tipos de valor, ou seja, eles armazenam seus dados diretamente, ao contrário das classes que são tipos de referência e armazenam uma referência para os dados. Structs são úteis para representar pequenos objetos imutáveis e podem ser mais eficientes em termos de desempenho em alguns casos.
// Permite o uso de construtores. o construtor é chamado na instanciação de um objeto tipada com o struct.
struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    // caso seja usado "new" para criar um objeto tipado com o struct, o construtor é chamado para inicializar os campos do struct.
    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Cor: {cor}");
    }
}