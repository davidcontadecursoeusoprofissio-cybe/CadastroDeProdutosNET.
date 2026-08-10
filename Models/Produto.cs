namespace CadastroDeProdutos.Models;

public class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = "";

    public double Preco { get; set; }

    public int Quantidade { get; set; }

    public string Imagem { get; set; } = "";

    public string Video { get; set; } = "";
}
