using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.Model;
using LFSoft.ViewModel;

namespace LFSoft.Controller
{
    public class TipoProdutoController
    {
        public List<TipoProdutoViewModel> Obter()
        {
            List<TipoProduto> dados = new TipoProduto().Obter();
            return (from tp in dados
                    select new TipoProdutoViewModel()
                    {
                        Id = tp.Id,
                        Nome = tp.Nome
                    }).ToList();
        }

        public int Gravar(TipoProdutoViewModel tipoProduto)
        {
            TipoProduto tp = new TipoProduto();
            tp.Id = tipoProduto.Id;
            tp.Nome = tipoProduto.Nome;
            return tp.Gravar();
        }

        public int Excluir(int id)
        {
            return new TipoProduto().Excluir(id);
        }
    }
}
