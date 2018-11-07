using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.ViewModel;
using LFSoft.Model;
namespace LFSoft.Controller
{
    public class ProdutoController
    {
        public List<ProdutoViewModel> Obter()
        {/*
            List<Produto> dados = new Produto().Obter();
            return (from P in dados
                    select new ProdutoViewModel()
                    {
                        Id = P.Id,
                        Nome = P.Nome,
                        Preco=P.Preco,
                        Ativo=P.Ativo,
                        CidadeId=P.CidadeId,
                        Contato=P.Contato,
                        DataCadastro=P.DataCadastro,
                        DataValidade=P.DataValidade,
                        Descricao=P.Descricao,
                        Email=P.Email,
                        Obs=P.Obs,
                        Telefone=P.Telefone,
                        TipoProdutoId=P.TipoProdutoId
                    }).ToList();*/
            
        }

        public int Gravar(ProdutoViewModel Produto)
        {
            Produto Pd = new Produto();
            Pd.Id = Produto.Id;
            Pd.Nome = Produto.Nome;
            Pd.Descricao = Produto.Descricao;
            Pd.DataCadastro = Produto.DataCadastro;
            Pd.DataValidade = Produto.DataValidade;
            Pd.CidadeId = Produto.CidadeId;
            Pd.TipoProdutoId = Produto.TipoProdutoId;
            Pd.Preco = Produto.Preco;
            return Pd.Gravar();
        }

        public int Excluir(int id)
        {
            return new Produto().Excluir(id);
        }
    }
}
