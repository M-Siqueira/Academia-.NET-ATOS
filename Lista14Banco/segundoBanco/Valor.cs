using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoBanco
{
    internal class Valor
    {
        public string _idPaciente;
        public string _valorG;
        public string _dataMedida;

        public Valor(string idPaciente, string valorG, string dataMedida)
        {
            this._idPaciente = idPaciente;
            this._valorG = valorG; 
            this._dataMedida = dataMedida;
        }

        public Valor(string id2)
        {
            this._idPaciente = id2;
           
        }
        

        public bool gravaValor()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();


            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;

            comando.Transaction = transacao;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into valores values(@idPaciente,@valorGlicemia,@dataMedida);";

            comando.Parameters.Add("@idPaciente", SqlDbType.Int);
            comando.Parameters.Add("@valorGlicemia", SqlDbType.Int);
            comando.Parameters.Add("@dataMedida", SqlDbType.Date);

            comando.Parameters[0].Value = _idPaciente;
            comando.Parameters[1].Value = _valorG;
            comando.Parameters[2].Value = _dataMedida;


            



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

        public bool apagaValor()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();


            SqlCommand comando = new SqlCommand();


            comando.Connection = cn;

            comando.Transaction = transacao;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "delete from valores where idGlicemia = "+(_idPaciente) +" ";


            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("deletado com sucesso......");
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
