using Microsoft.AspNetCore.Mvc;
using PROJETO01.Dados.EntityFramework;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETO01.Controllers
{
    
    public class TipoJogoController : Controller
    {
        public IActionResult Index(string codTipoJogo, string Tipojogo)
        {
            var objeto = new TipoJogos();
            objeto.codTipoJogo = codTipoJogo;
            objeto.descrisaoTipoJogo = Tipojogo;




            return View(objeto);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarConfirmacao(TipoJogos TipoJogos)
        {
            var db = new Contexto();

            var obj = db.TipoJogos.FirstOrDefault(f => f.codTipoJogo == TipoJogos.codTipoJogo);

            if (obj == null)
            {
                db.TipoJogos.Add(TipoJogos);
            }
            else
            {
                obj.descrisaoTipoJogo = TipoJogos.descrisaoTipoJogo;
                db.TipoJogos.Update(obj);
            }

            db.SaveChanges();

            return RedirectToAction("listar");
        }

        [HttpGet]
        public IActionResult Editar(string codTipoJogo)
        {
            var db = new Contexto();
            var TipoJogos = db.TipoJogos.FirstOrDefault(item => item.codTipoJogo == codTipoJogo);
            return View("Adicionar", TipoJogos);
        }

        public IActionResult Listar()
        {

            //SELECT * FROM Estado
                var listaDeTipoJogos = new Contexto().TipoJogos.ToList();

            return View(listaDeTipoJogos);
        }

        public IActionResult Excluir(string codTipoJogo)
        {
            var db = new Contexto();
            var TipoJogos = db.TipoJogos.FirstOrDefault(f => f.codTipoJogo == codTipoJogo);
            db.TipoJogos.Remove(TipoJogos);
            db.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
