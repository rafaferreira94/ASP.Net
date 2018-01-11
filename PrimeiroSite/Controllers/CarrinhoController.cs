using PrimeiroSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiroSite.Controllers
{
    public class CarrinhoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Carrinho
        public ActionResult Index()
        {
            if (Session["carrinho"] == null)
                Session["carrinho"] = new List<Produto>();

            return View(Session["carrinho"]);
        }

        // GET: Carrinho
        public ActionResult Adicionar(int? id)
        {
            if (Session["carrinho"] == null)
                Session["carrinho"] = new List<Produto>();

            var produto = db.Produtoes.Include("Categoria").FirstOrDefault(x => x.IDProduto == id);

            (Session["carrinho"] as List<Produto>).Add(produto);

            return View("Index", Session["carrinho"]);
        }
    }
}