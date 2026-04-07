
namespace aula38;

public class Aula38
{
    public static void Main()
    {
        // Ref: faz referência a um objeto do tipo Base, mas pode apontar para objetos de classes derivadas, permitindo o polimorfismo.
        Base Ref;

        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada1;
        Ref.info(); // Chama o método info() da classe Derivada1, pois Ref aponta para um objeto do tipo Derivada1.

        Ref = derivada2;
        Ref.info(); // Chama o método info() da classe Derivada2, pois Ref agora aponta para um objeto do tipo Derivada2.

        derivada1.info();
        derivada2.info();
    }
}

public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor classe Base");
    }

    // virtual permite que o método seja sobrescrito em classes derivadas, permitindo o polimorfismo.
    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}

public class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor classe Derivada1");
    }

    // override indica que este método está sobrescrevendo um método virtual da classe base, permitindo que a implementação específica da classe Derivada1 seja chamada quando o método info() for invocado em um objeto do tipo Derivada1.
    override public void info()
    {
        Console.WriteLine("Derivada 1");
    }
}

public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor classe Derivada2");
    }

    override public void info()
    {
        Console.WriteLine("Derivada 2");
    }
}