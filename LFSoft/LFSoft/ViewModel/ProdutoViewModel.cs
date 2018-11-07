using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSoft.ViewModel
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public int TipoProdutoId { get; set; }
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal Preco { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public char Ativo { get; set; }

    }
}
