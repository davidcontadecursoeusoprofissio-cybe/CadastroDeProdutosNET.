using CadastroDeProdutos.Models;

namespace CadastroDeProdutos.Data;

public static class ProdutoData
{
    public static List<Produto> Produtos { get; set; } = new List<Produto>();

    public static List<Produto> Carrinho { get; set; } = new List<Produto>();
}