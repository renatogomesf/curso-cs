
namespace aula29;

/*
[ModificadorClasse] class NOME_DA_CLASSE{
    
    Variáveis / propriedades
    [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

    Métodos
    [EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...]){
            Corpo do método
    }
}

ModificadorClasse: Define a visibilidade da classe
    public: Pública, sem restrição de visualização
    abstract: Classe-Base para outras classes, não podem ser instanciados objetos desta classe
    sealed: Classe não pode ser herdada
    static: Classe não permite a instanciação de objetos e seus membros devem ser static

EspecificadorAcesso: Onde um membro da classe pode ser acessado
    public: Sem restrição de acesso
    private: Só podem ser acessador pela própria classe
    protected: Podem ser acessados na própria classe e nas classes derivadas
    abstract: Os métodos não tem implementação somente os cabeçalhos
    sealed: O método não pode ser redefinido
    virtual: O método pode ser redefinido em uma classe derivada
    static: O método pode ser chamado mesmo sem a instanciação de um objeto
*/


public class Aula29
{
    public static void Main()
    {

        Jogador j1 = new Jogador("Bruno");

        Console.WriteLine($"Nome j2: {j1.nome}");
        Console.WriteLine($"Energia j1: {j1.energia}");
        Console.WriteLine($"Vivo j1: {j1.vivo}");

        Console.WriteLine("\n----------------------------------------------\n");

        Jogador j2 = new Jogador("Theo");
        j2.energia = 50;
        j2.vivo = true;

        Console.WriteLine($"Nome j2: {j2.nome}");
        Console.WriteLine($"Energia j2: {j2.energia}");
        Console.WriteLine($"Vivo j2: {j2.vivo}");

    }
}

public class Jogador
{
    // para acessar a propriedade através da instancitação de um objeto, a propriedade deve ser pública.
    public int energia;
    public bool vivo;
    public string nome;

    // Construtor: método especial que é chamado quando um objeto é criado a partir de uma classe. Ele é usado para inicializar os objetos e pode receber parâmetros para configurar o estado inicial do objeto.
    public Jogador(string nome)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
    }

    //Destrutor: método especial que é chamado quando um objeto é destruído ou liberado da memória. Ele é usado para realizar tarefas de limpeza, como liberar recursos ou fechar conexões, antes que o objeto seja completamente removido da memória.
    // declaração: ~NOME_DA_CLASSE() { /* código de limpeza */ }. importanto o uso do operador til (~) antes do nome da classe.
    ~Jogador()
    {
        Console.WriteLine("Objeto destruído");
    }
}
