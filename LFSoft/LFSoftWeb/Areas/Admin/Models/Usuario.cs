using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSoftWeb.Areas.Admin.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Id do usuário é obrigatório.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do usuário.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o e-mail do usuário.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha do usuário.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirme a senha do usuário.")]
        public string ConfirmeSenha { get; set; }
    }
}
