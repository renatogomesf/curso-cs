
namespace aula06;

public class Aula06
{
    public static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;

        // uso de índice para concatenar os valores
        // \n = nova linha, \t = tabulação
        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", num1, num2, num3);

        Console.WriteLine("\nn1 = {0}\nn2 = {1}\nn3 = {2}\n", num1, num2, num3); // \n = nova linha

        Console.WriteLine("\nn1 =\t {0}\nn2 =\t {1}\nn3 =\t {2}\n", num1, num2, num3); // \t = tabulação


        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.10;
        string produto = "pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("produto.............:{0,15}", produto); // 15 = alinha o texto a direita, -15 = alinha o texto a esquerda
        Console.WriteLine("val. compra.........:{0,15:c}", valorCompra); // :c = formata o valor como moeda
        Console.WriteLine("lucro...............:{0,15:p}", lucro); // :p = formata o valor como porcentagem, multiplicando por 100 e adicionando o símbolo de porcentagem
        Console.WriteLine("val. venda..........:{0,15:c}", valorVenda);
    }
}