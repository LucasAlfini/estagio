using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LFSoftWeb.Areas.Admin.Models;
using LFSoftWeb.Filters;
//using cl = LFSoft.Controller;
//using vm = LFSoft.ViewModel;

namespace LFSoftWeb.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Autenticar()
        {
            Session.RemoveAll();
            Session.Abandon();

            HttpCookie ck = Request.Cookies["identificacao"];
            if (ck != null)
            {
                FormCollection form = new FormCollection();
                form.Add("txtId", ck["id"].ToString());
                form.Add("txtSenha", ck["senha"].ToString());
                form.Add("ckLembrar", "1");
                ViewData["formData"] = form;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(FormCollection form)
        {
            /*ViewData["formData"] = form;
            cl.UsuarioController cUsuario = new cl.UsuarioController();
            vm.UsuarioViewModel vmUsuario = cUsuario.Autenticar(int.Parse(form["txtId"]), form["txtSenha"]);
            if (vmUsuario != null)
            {
                Session["autenticado"] = "ok";
                Session["nomeUsuario"] = vmUsuario.Nome;
                if (form["ckLembrar"] == "1")
                {
                    HttpCookie ck = new HttpCookie("identificacao");
                    ck.Values.Add("id", form["txtId"]);
                    ck.Values.Add("senha", form["txtSenha"]);
                    Response.Cookies.Add(ck);
                }
                else
                {
                    HttpCookie ck = Request.Cookies["identificacao"];
                    if (ck != null)
                    {
                        ck.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(ck);
                    }
                }
                return RedirectToAction("Dashboard","Home");
            }
            else
            {
                ViewBag.Msg = "Usuário ou senha inválidos.";
            }*/
            return View();
        }

        [AcessoRestritoFilter]
        // GET: Admin/Usuario
        public ActionResult Alterar()
        {
            return View();
        }

        [AcessoRestritoFilter]
        [HttpPost]
        public ActionResult Alterar(Usuario dados)
        {
            if (!ModelState.IsValid)
            {

            }
            return View(dados);
        }
    }
}