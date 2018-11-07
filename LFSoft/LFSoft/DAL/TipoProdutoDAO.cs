using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.Model;

namespace LFSoft.DAL
{
    internal class TipoProdutoDAO : Banco
    {
        #region MÉTODOS PARA CONVERTER DATATABLE EM OBJETOS
        private TipoProduto ConvertToObject(DataRow row)
        {
            TipoProduto tp = new TipoProduto()
            {
                Id = Convert.ToInt32(row["Id"]),
                Nome = row["Nome"].ToString()
            };
            return tp;
        }

        private List<TipoProduto> ConvertToList(DataTable dt)
        {
            List<TipoProduto> dados = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                dados = new List<TipoProduto>();
                foreach (DataRow dr in dt.Rows)
                    dados.Add(ConvertToObject(dr));
            }
            return dados;
        }
        #endregion

        internal List<TipoProduto> Obter()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from TIPOPRODUTO order by NOME";
            DataTable dados = ExecutaSelect();
            if (dados != null && dados.Rows.Count > 0)
                return ConvertToList(dados);
            else
                return null;
        }

        internal int Gravar(TipoProduto tipoProduto)
        {
            ComandoSQL.Parameters.Clear();
            if (tipoProduto.Id == 0) //Novo tipo de produto
                ComandoSQL.CommandText = @"insert into TIPOPRODUTO (NOME) values (@nome)";
            else //Alterar tipo de produto
            {
                ComandoSQL.CommandText = @"update TIPOPRODUTO set NOME = @nome where ID = @id";
                ComandoSQL.Parameters.AddWithValue("@id", tipoProduto.Id);
            }
            ComandoSQL.Parameters.AddWithValue("@nome", tipoProduto.Nome);

            return ExecutaComando(false);
        }

        internal int Excluir(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"delete from TIPOPRODUTO where ID = @id";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            return ExecutaComando(false);
        }
    }
}
