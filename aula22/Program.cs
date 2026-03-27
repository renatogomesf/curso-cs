
namespace aula22;

public class MyClass
{
    public static void Main()
    {
        // FOR EACH

        int[] num = new int[5] { 10, 20, 30, 40, 50 };

        // com for normal
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }

        // com for each
        // pega elemento por elemento do array e armazena na variável "item".
        foreach (int item in num)
        {
            Console.WriteLine(item);
        }
    }
}