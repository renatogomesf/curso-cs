
namespace aula24;

public class Aula24
{
    public static void Main()
    {
        ExemploMetodo();
        Soma(10, 20);

        int resultadoMultiplicacao = Multiplicacao(5, 4);
        Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");
    }

    // Métodos: são blocos de código que realizam uma tarefa específica. Eles podem receber parâmetros e retornar valores.
    // como Main é um método static, os métodos chamados dentro dele também devem ser static, ou seja, eles pertencem à classe e não a uma instância da classe. Se um método não for static, ele pertence a uma instância da classe e só pode ser chamado a partir de um objeto dessa classe.
    static void ExemploMetodo()
    {
        Console.WriteLine("Este é um exemplo de método.");
    }


    // Método com parâmetros: são métodos que recebem valores de entrada para realizar uma tarefa.
    static void Soma(int n1, int n2)
    {
        Console.WriteLine($"A soma de {n1} e {n2} é: {n1 + n2}");
    }

    // Método com retorno: são métodos que retornam um valor após realizar uma tarefa.
    static int Multiplicacao(int n1, int n2)
    {
        int resultado = n1 * n2;
        return resultado;
    }
}