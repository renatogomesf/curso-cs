
namespace aula04;

public class Aula04
{

    static int num = 10; // variável de instância/global, pode ser acessada por todos os métodos da classe MyClass


    public static void Main()
    {
        int num1 = 10; // variável local do metodo Main, só pode ser acessada dentro do método Main

        Console.WriteLine(num);
    }


    void Teste() 
    {
        int num2 = 1000; // variável local do método Teste, só pode ser acessada dentro do método Teste

        Console.WriteLine(num2);
    }
}
