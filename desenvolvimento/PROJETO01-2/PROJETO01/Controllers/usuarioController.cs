
using PROJETO01.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROJETO01.Dados.EntityFramework;

namespace PROJETO01.Controllers
{
    public class usuarioController : Controller
    {

        public IActionResult Index(string codPlayer, string IdLogin, string NickJogador, string senha, int codJogo)
        {
            var objeto = new usuario();
            objeto.codPlayer = codPlayer;
            objeto.IdLogin = IdLogin;
            objeto.NickJogador = NickJogador;
            objeto.senha = senha;
            objeto.codJogo = codJogo;
            return View(objeto);
        }


        public IActionResult Adicionar()
        {
            var db = new Contexto();
            ViewBag.jogo = db.jogo.ToList();
            return View();
        }

        public IActionResult AdicionarConfirmacao(usuario usuario)
        {
            var db = new Contexto();

            var obj = db.usuario.FirstOrDefault(f => f.codPlayer == usuario.codPlayer);

            if (obj == null)
            {
                db.usuario.Add(usuario);
            }
            else
            {
                BadRequest();
            }

            db.SaveChanges();

            return RedirectToAction("listar");
        }
        public IActionResult Listar()
        {

            //SELECT * FROM Estado
            var listaDeusuario = new Contexto().usuario.ToList();

            return View(listaDeusuario);
        }

        public IActionResult ListarJogador()
        {

            //SELECT * FROM Estado
            var listaDeusuario = new Contexto().usuario.ToList();

            return View(listaDeusuario);
        }


        public IActionResult Login()
        {

            return View();
        }

    }
}
