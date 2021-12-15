using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    public class FornecedorjogosController : Controller
    {
        public IActionResult Index(string codFornecedor, string nomefornecedor, string Descricaofornecedor)
        {
            var objeto = new Fornecedorjogos();
            objeto.codFornecedor = codFornecedor;
            objeto.nomefornecedor = nomefornecedor;
            objeto.Descricaofornecedor = Descricaofornecedor;




            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(Fornecedorjogos Fornecedorjogos)
        {
            var db = new Contexto();

            var obj = db.Fornecedorjogos.FirstOrDefault(f => f.codFornecedor == Fornecedorjogos.codFornecedor);

            if (obj == null)
            {
                db.Fornecedorjogos.Add(Fornecedorjogos);
            }
            else
            {
                obj.nomefornecedor = Fornecedorjogos.nomefornecedor;
                obj.Descricaofornecedor = Fornecedorjogos.Descricaofornecedor;
                db.Fornecedorjogos.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("listar");
        }

        [HttpGet]
        public IActionResult Editar(string codFornecedor)
        {
            var db = new Contexto();
                var Fornecedorjogos = db.Fornecedorjogos.FirstOrDefault(item => item.codFornecedor == codFornecedor);
            return View("Adicionar", Fornecedorjogos);
        }

        public IActionResult Listar()
        {

         
            var listaDeFornecedorjogos = new Contexto().Fornecedorjogos.ToList();

            return View(listaDeFornecedorjogos);
        }

        public IActionResult Excluir(string codFornecedor)
        {
            var db = new Contexto();
            var TipoJogos = db.Fornecedorjogos.First(f => f.codFornecedor == codFornecedor);
            db.Fornecedorjogos.Remove(TipoJogos);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
