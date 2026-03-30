
namespace aula26;

public class MyClass
{
    public static void Main()
    {
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 3;
        quoc = divide(divid, divis, out rest);

        Console.WriteLine($"{divid} / {divis} = {quoc} | Resto: {rest}");
    }

    // "out": permite que um método retorne mais de um valor. O método pode retornar um valor principal e, ao mesmo tempo, fornecer valores adicionais por meio de parâmetros "out". Isso é útil quando você deseja retornar múltiplos resultados de um método sem a necessidade de criar uma classe ou estrutura para encapsular esses valores.
    static int divide(int dividendo, int divisor, out int resto)
    {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}