using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class jogoController : Controller
    {

        public IActionResult Index(int codJogo, string nomeDoJogo, string codFornecedor, DateTime anolancamento, string requisitos, string codTipoJogo)
        {
            var objeto = new jogo();
            objeto.codJogo = codJogo;
            objeto.nomeDoJogo = nomeDoJogo;
            objeto.codFornecedor = codFornecedor;
            objeto.requisitos = requisitos;
            objeto.anolancamento = anolancamento;
            objeto.codTipoJogo = codTipoJogo;


            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.Fornecedorjogos = db.Fornecedorjogos.ToList();
            ViewBag.TipoJogos = db.TipoJogos.ToList();
            return View();
        }

        public IActionResult AdicionarConfirmacao(jogo jogo)
        {
            var db = new Contexto();

            var obj = db.jogo.FirstOrDefault(f => f.codJogo == jogo.codJogo);

            if (obj == null)
            {
                db.jogo.Add(jogo);
            }
            else
            {
                obj.nomeDoJogo = jogo.nomeDoJogo;
                ViewBag.Fornecedorjogos = db.Fornecedorjogos.ToList();
                obj.requisitos = jogo.requisitos;
                obj.anolancamento = jogo.anolancamento;
                ViewBag.TipoJogos = db.TipoJogos.ToList();
                db.jogo.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("listar");
        }
        [HttpGet]
        public IActionResult Editar(int codJogo)
        {
            var db = new Contexto();
           
            ViewBag.Fornecedorjogos = db.Fornecedorjogos.ToList();
            ViewBag.TipoJogos = db.TipoJogos.ToList();
            var jogo = db.jogo.First(item => item.codJogo == codJogo);
            return View("Adicionar", jogo);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDejogo = new Contexto().jogo.ToList();

            return View(listaDejogo);
        }

        public IActionResult Excluir(int codJogo)
        {
            var db = new Contexto();
            var jogo = db.jogo.FirstOrDefault(f => f.codJogo == codJogo);
            db.jogo.Remove(jogo);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}