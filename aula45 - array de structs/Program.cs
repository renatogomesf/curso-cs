
namespace aula44;

public class Aula44
{
    public static void Main()
    {
        // para criar um array de structs, basta declarar o tipo do struct seguido de colchetes e o número de elementos. como no array normal.
        Carro[] carros = new Carro[4];

        carros[0].modelo = "Gol";
        carros[0].cor = "Prata";

        carros[1].modelo = "Celta";
        carros[1].cor = "Preto";

        carros[2].modelo = "Uno";
        carros[2].cor = "Branco";

        carros[3].modelo = "Palio";
        carros[3].cor = "Vermelho";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].ExibirInformacoes();
        }
    }
}


struct Carro
{
    public string modelo;
    public string cor;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {modelo}\nCor: {cor}");
        Console.WriteLine("---------------------------------------------------------------");

    }
}