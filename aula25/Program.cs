
namespace aula25;

public class MyClass
{
    public static void Main()
    {
        int numero = 10;

        // Passando o valor da variável "numero" para o método "dobrar" usando a palavra-chave "ref". Isso permite que o método modifique o valor original da variável "numero". está sendo passado o endereço de memória da variável "numero" para o método "dobrar", permitindo que ele acesse e modifique o valor original da variável.
        dobrar(ref numero);

        Console.WriteLine(numero);
    }

    // Passagem de valor por referência: é uma forma de passar um valor para um método, onde o método pode modificar o valor original. Para isso, é necessário usar a palavra-chave "ref" tanto na declaração do método quanto na chamada do método.
    static void dobrar(ref int valor)
    {
        valor *= 2;
    }
}