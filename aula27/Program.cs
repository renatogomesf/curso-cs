
namespace aula27;

public class MyClass
{
    public static void Main()
    {
        soma();
        soma(2);
        soma(2,2);
        soma(2,3,6,5,8);

    }

    // Params: permite que um método aceite um número variável de argumentos do mesmo tipo. Isso é útil quando você não sabe quantos argumentos serão passados para o método. Para usar "params", basta declarar um parâmetro com a palavra-chave "params" seguida do tipo do argumento e um array. O método pode então ser chamado com qualquer número de argumentos, e eles serão tratados como um array dentro do método.

    // AQUI O MÉTODO "soma" ACEITA UM NÚMERO VARIÁVEL DE ARGUMENTOS DO TIPO "int". DENTRO DO MÉTODO, O PARÂMETRO "n" É TRATADO COMO UM ARRAY DE INTEIROS, E O CÓDIGO PODE ITERAR SOBRE ESSE ARRAY PARA CALCULAR A SOMA DOS VALORES PASSADOS.

    // SE FOSSE SOMENTE "int[] n", O MÉTODO EXIGIRIA QUE UM ARRAY DE INTEIROS FOSSE PASSADO COMO ARGUMENTO, E NÃO PERMITIRIA UM NÚMERO VARIÁVEL DE ARGUMENTOS.
    static void soma(params int[] n)
    {
        int res = 0;

        if(n.Length < 1)
        {
            Console.WriteLine("sem valor a ser somado");
        } else if (n.Length < 2)
        {
            Console.WriteLine("valores insuficientes");
        }else
        {
            foreach (var item in n)
            {
                res += item;
            }

            Console.WriteLine($"soma dos valores = {res}");
        }
    }
}
