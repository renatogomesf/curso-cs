
namespace aula11;

public class Aula11
{
    public static void Main()
    {
        // type casting: Refere-se à conversão de um tipo de dado para outro tipo de dado. Existem dois tipos principais de type casting: conversão implícita e conversão explícita.

        int n1 = 10;
        float n2 = n1; // Conversão implícita: Permite converter um tipo de dado para outro tipo de dado sem a necessidade de uma conversão explícita, desde que a conversão seja segura e não haja perda de dados.

        Console.WriteLine(n2);


        float n3 = 3.14f;
        int n4 = (int)n3; // Conversão explícita: Permite converter um tipo de dado para outro tipo de dado, mas requer uma conversão explícita, indicando que o programador está ciente da possibilidade de perda de dados ou de uma conversão não segura.

        Console.WriteLine(n4);
    }
}