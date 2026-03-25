
namespace aula05;

public class Aula05
{
    public static void Main()
    {
        int res = (10 + 5) * 2; // (), *, /, +, -

        bool teste = 10 < 5; // >, <, >=, <=, ==, !=

        int num = 10;

        num = num + 1;
        num += 1; // num = num + 1
        num++; // num = num + 1

        num = num - 1;
        num -= 1; // num = num - 1
        num--; // num = num - 1

        num = num * 2;
        num *= 2; // num = num * 2

        num = num / 2;
        num /= 2; // num = num / 2

        bool teste1 = (10 < 50) | (5 < 3); // | = OR bit a bit, || = OR lógico (curto-circuito)

        bool teste2 = 10 < 5 & 5 > 3; // & = AND bit a bit, && = AND lógico (curto-circuito)

        bool teste3 = !teste;

        Console.WriteLine(teste3);
    }
}