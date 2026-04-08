
namespace aula39;

public class Aula39
{
    public static void Main()
    {
        Carro carro1 = new Carro();

        carro1.aceleracao(1);

        Console.WriteLine(carro1.getVelAtual());
    }
}


// Abstract: indica que a classe é abstrata, ou seja, não pode ser instanciada diretamente e serve como base para outras classes. Ela pode conter métodos abstratos, que são declarados sem implementação e devem ser implementados por classes derivadas.
abstract public class Veiculo
{
    protected int VelMax;
    protected int VelAtual;
    protected bool ligado;

    // Não é obrigado implementar um construtor em uma classe abstrata, mas é possível criar um construtor para inicializar os atributos comuns a todas as classes derivadas. As classes derivadas podem chamar esse construtor usando a palavra-chave base.
    public Veiculo()
    {
        ligado = false;
        VelAtual = 0;
    }

    // Metodos não abstratos de uma classe abstrata podem ser implementados normalmente, e as classes derivadas podem herdar e usar esses métodos sem a necessidade de sobrescrevê-los, a menos que desejem fornecer uma implementação específica.
    public void setLigar(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelAtual()
    {
        return VelAtual;
    }

    // Métodos abstratos são declarados sem implementação e devem ser implementados por classes derivadas. Eles definem a assinatura do método, mas a implementação específica é fornecida pelas classes que herdam da classe abstrata.
    abstract public void aceleracao(int mult);
}


public class Carro : Veiculo
{
    public Carro()
    {
        VelMax = 120;
    }

    // Override: indica que este método está sobrescrevendo um método abstrato da classe base, permitindo que a implementação específica da classe Carro seja chamada quando o método aceleracao() for invocado em um objeto do tipo Carro.
    override public void aceleracao(int mult)
    {
        VelAtual += 10 * mult;
    }
}