namespace aula15;

public class Aula15
{
    public static void Main()
    {
        int tempo = 0;
        char escolha = 'a';

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                break;

            case 'b':
            case 'B':
                tempo = 480;
                break;

            case 'c':
            case 'C':
                tempo = 660;
                break;

            default:
                tempo = -1;
                break;
        }

        Console.WriteLine($"O tempo de espera é: {tempo}");
    }
}