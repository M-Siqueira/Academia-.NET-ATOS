using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoBanco
{
    internal class Paciente
    {
        public string _nomePaciente;

        public Paciente(string nomeP)
        {
            this._nomePaciente = nomeP;
        }

        public bool gravaPaciente()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();


            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;

            comando.Transaction = transacao;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into paciente values(@nomePaciente);";

            comando.Parameters.Add("@nomePaciente", SqlDbType.VarChar);

            comando.Parameters[0].Value = _nomePaciente;


            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("cheguei aqui");
                transacao.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }



    }
}
