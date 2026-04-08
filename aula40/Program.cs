
namespace aula40;

public class Aula40
{
    public static void Main()
    {
        Veiculo veiculo1 = new Veiculo();
        veiculo1.info();
    }
}

//  classe sealed: indica que a classe é selada, ou seja, não pode ser herdada por outras classes. Isso é útil quando você deseja impedir que outras classes derivem de uma classe específica, garantindo que a implementação da classe permaneça inalterada e protegida contra modificações indesejadas por meio da herança.
sealed public class Veiculo
{
    public void info()
    {
        Console.WriteLine("Classe selada");
    }
}