using CadastroDeProdutos.Data;
using CadastroDeProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeProdutos.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Produto produto)
    {
        produto.Id = ProdutoData.Produtos.Count + 1;

        ProdutoData.Produtos.Add(produto);

        return RedirectToAction("ProdutosRegistrados");
    }

    public IActionResult ProdutosRegistrados()
    {
        return View(ProdutoData.Produtos);
    }

    public IActionResult AdicionarCarrinho(int id)
    {
        var produto = ProdutoData.Produtos.FirstOrDefault(p => p.Id == id);

        if (produto == null)
        {
            return NotFound();
        }

        ProdutoData.Carrinho.Add(produto);

        return RedirectToAction("ProdutosRegistrados");
    }

    public IActionResult Carrinho()
    {
        return View("~/Views/Carrinho/Index.cshtml", ProdutoData.Carrinho);
    }
}
