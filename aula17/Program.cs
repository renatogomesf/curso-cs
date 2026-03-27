
namespace aula17;

public class MyClass
{
    public static void Main()
    {
        // ARRAY

        // Declaração de um array de inteiros com 5 elementos
        int[] n = new int[5];
        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        Console.WriteLine(n[0]);

        // declaração e inicialização de um array de inteiros com 3 elementos
        int[] num = new int[3] {55,77,99};
        Console.WriteLine(num[1]);

        // declaração e inicialização de um array de inteiros com 3 elementos (forma simplificada). o array possui o tamanho definido automaticamente pelo número de elementos fornecidos
        int[] num2 = { 11, 22, 33 };
        Console.WriteLine(num[2]);
    }
}