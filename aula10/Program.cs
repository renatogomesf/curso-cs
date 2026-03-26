namespace aula10;

public class Aula10
{

    // ENUM: Tipo de dado que representa um conjunto de constantes nomeadas. cada constante é associada a um valor inteiro subjacente, começando por padrão em 0 e incrementando em 1 para cada constante subsequente.
    // Definindo um enum para os dias da semana
    enum DiasSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }


    public static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana ds2 = (DiasSemana)3; // Conversão explícita: Permite converter um valor inteiro para o tipo do enum correspondente.
        int ds3 = (int)DiasSemana.Sexta; // Conversão explícita: Permite converter um valor do tipo enum para seu valor inteiro subjacente.

        // "${}": Interpolação de string: Permite incorporar expressões dentro de uma string, facilitando a construção de mensagens dinâmicas. O valor da expressão é avaliado e convertido em string, sendo então inserido na posição correspondente dentro da string.
        Console.WriteLine($"O valor do dia da semana é: {ds}");
        Console.WriteLine($"O valor do dia da semana é: {ds2}");
        Console.WriteLine($"O valor do dia da semana é: {ds3}");


    }
}
