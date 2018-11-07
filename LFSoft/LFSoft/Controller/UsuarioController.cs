using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.Model;
using LFSoft.ViewModel;

namespace LFSoft.Controller
{
    public class UsuarioController
    {
        public UsuarioViewModel Autenticar(int id, string senha)
        {
            Usuario u = new Usuario().Autenticar(id, senha);
            if (u != null)
            {
                return new UsuarioViewModel()
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    Email = u.Email,
                    Ativo = u.Ativo,
                    Senha = u.Senha
                };
            }
            else
                return null;

        }
    }
}
