using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFSoft.Model;

namespace LFSoft.DAL
{
    internal class UsuarioDAO : Banco
    {
        #region MÉTODOS PARA CONVERTER DATATABLE EM OBJETOS
        private Usuario ConvertToObject(DataRow row)
        {
            Usuario u = new Usuario()
            {
                Id = Convert.ToInt32(row["Id"]),
                Nome = row["Nome"].ToString(),
                Email = row["Email"].ToString(),
                Senha = row["Senha"].ToString(),
                Ativo = row["Ativo"].ToString()
            };
            return u;
        }

        private List<Usuario> ConvertToList(DataTable dt)
        {
            List<Usuario> dados = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                dados = new List<Usuario>();
                foreach (DataRow dr in dt.Rows)
                    dados.Add(ConvertToObject(dr));
            }
            return dados;
        }
        #endregion

        internal Usuario Autenticar(int id, string senha)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from Usuario
                                       where id = @id and senha = @senha";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            ComandoSQL.Parameters.AddWithValue("@senha", senha);
            DataTable dados = ExecutaSelect();
            if (dados != null && dados.Rows.Count > 0)
                return ConvertToObject(dados.Rows[0]);
            else
                return null;
        }
    }
}
