using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.Model;

namespace LFSoft.DAL
{
    internal class ProdutoDAO : Banco
    {
        private Produto ConvertToObject(DataRow row)
        {
            Produto Prod = new Produto()
            {
                Id = int.Parse(row["Id"].ToString()),
                Nome = row["Nome"].ToString(),
                Preco=decimal.Parse(row["Preco"].ToString()),
                CidadeId=int.Parse(row["CidadeId"].ToString()),
                Ativo=char.Parse(row["Ativo"].ToString()),
                Contato=row["Contato"].ToString(),
                DataCadastro=DateTime.Parse(row["DataCadastro"].ToString()),
                DataValidade=DateTime.Parse(row["DataValidade"].ToString()),
                Descricao=row["Descrição"].ToString(),
                Email=row["Email"].ToString(),
                Obs=row["Obs"].ToString(),
                Telefone=row["Telefone"].ToString(),
                TipoProdutoId=int.Parse(row["TipoProdutoId"].ToString())
            };
            return Prod;
        }

        private List<Produto> ConvertToList(DataTable dt)
        {
            List<Produto> dados = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                dados = new List<Produto>();
                foreach (DataRow dr in dt.Rows)
                    dados.Add(ConvertToObject(dr));
            }
            return dados;
        }


        internal List<Produto> Obter()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from PRODUTO order by NOME";
            DataTable dados = ExecutaSelect();
            if (dados != null && dados.Rows.Count > 0)
                return ConvertToList(dados);
            else
                return null;
        }

        internal int Gravar(Produto Prod)
        {
            ComandoSQL.Parameters.Clear();
            if (Prod.Id == 0) //Novo produto
            {
                ComandoSQL.CommandText = @"insert into PRODUTO (NOME,ATIVO,CIDADEID,TIPOPRODUTOID,DATAVALIDADE,DATACADASTRO,DESCRIÇÃO,PRECO,CONTATO,TELEFONE,EMAIL,OBS) 
                                        values (@nome,@ATIVO,@cidid,@tipoid,@datv,@datc,@desc,@preco,@contato,@telefone,@email,@obs)";
                ComandoSQL.Parameters.AddWithValue("@ATIVO", 'S');
                ComandoSQL.Parameters.AddWithValue("@cidid", Prod.CidadeId);
                ComandoSQL.Parameters.AddWithValue("@tipoid", Prod.TipoProdutoId);
                ComandoSQL.Parameters.AddWithValue("@datv", Prod.DataValidade);
                ComandoSQL.Parameters.AddWithValue("@datc", Prod.DataCadastro);
                ComandoSQL.Parameters.AddWithValue("@desc", Prod.Descricao);
                ComandoSQL.Parameters.AddWithValue("@preco", Prod.Preco);
                ComandoSQL.Parameters.AddWithValue("@contato", " ");
                ComandoSQL.Parameters.AddWithValue("@telefone", " ");
                ComandoSQL.Parameters.AddWithValue("@email", " ");
                ComandoSQL.Parameters.AddWithValue("@obs", " ");

            }
            else //Alterar produto
            {
                ComandoSQL.CommandText = @"update PRODUTO set NOME = @nome where ID = @id";
                ComandoSQL.Parameters.AddWithValue("@id", Prod.Id);
            }
            ComandoSQL.Parameters.AddWithValue("@nome", Prod.Nome);
            return ExecutaComando();
        }

        internal int Excluir(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"delete from PRODUTO where ID = @id";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            return ExecutaComando(false);
        }
    }
}
