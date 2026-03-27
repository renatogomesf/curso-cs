
namespace aula18;

public class MyClass
{
    public static void Main()
    {
        // MATRIZ

        // Declaração de uma matriz de inteiros com 3 linhas e 5 colunas
        // o que difere uma matriz e de um array na declaração é o uso da vírgula dentro dos colchetes para indicar o número de dimensões da matriz.
        int[,] n = new int[3,5];

        n[0, 0] = 10; n[0, 1] = 20; n[0,2] = 30; n[0, 3] = 40; n[0, 4] = 50;
        n[1, 0] = 11; n[1, 1] = 21; n[1,2] = 31; n[1, 3] = 41; n[1, 4] = 51;
        n[2, 0] = 12; n[2, 1] = 22; n[2,2] = 32; n[2, 3] = 42; n[2, 4] = 52;

        Console.WriteLine(n[1, 2]);

        // declaração e inicialização de uma matriz de inteiros com 2 linhas e 2 colunas
        int[,] num = new int[2, 2] { { 1, 2 }, { 4, 5} };
    }
}