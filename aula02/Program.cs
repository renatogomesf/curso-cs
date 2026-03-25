using System;

namespace aula02;

public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CFB Cursos");

        if (args.Length > 0)
        {
            Console.WriteLine(args.GetValue(0));
            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
        }

    }
}