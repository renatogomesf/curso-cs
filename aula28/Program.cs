
namespace aula28;

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


public class Aula28
{
    public static void Main()
    {

        Jogador j1 = new Jogador();

        Console.WriteLine($"Energia j1: {j1.energia}");
        Console.WriteLine($"Vivo j1: {j1.vivo}");

        Jogador j2 = new Jogador();
        j2.energia = 0;
        j2.vivo = false;

        Console.WriteLine($"Energia j2: {j2.energia}");
        Console.WriteLine($"Vivo j2: {j2.vivo}");

    }
}

public class Jogador
{
    // para acessar a propriedade através da instancitação de um objeto, a propriedade deve ser pública.
    public int energia = 100;
    public bool vivo = true;

}