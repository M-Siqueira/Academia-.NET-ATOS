using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOnetAdicional
{
    internal class Pessoa
    {

        public int _Id;
        public string _Nome;
        public float _Peso;

        //public Pessoa(string nome, float peso)
        //{
        //    this._Nome = nome;
        //    this._Peso = peso;
        //}

        public bool gravarPessoa()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;

            cmd.Transaction = transacao;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Insert Into pessoas values (@nome,@peso)";

            

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@peso", SqlDbType.Float);

            //MessageBox.Show("passei do insert");

            cmd.Parameters[0].Value = _Nome;
            cmd.Parameters[1].Value = _Peso;
            
            try
            {
                cmd.ExecuteNonQuery();

                transacao.Commit();

                return true;
            }
            catch
            {
                transacao.Rollback();
                //MessageBox.Show("ENTREI EM ROLLBAK");
                return false;

            }
            finally
            {
                banco.fechaConexao();   
            }

        }

        public bool apagaPessoa()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;

            cmd.Transaction = transacao;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from pessoas where nome = @nome";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);

            cmd.Parameters[0].Value = _Nome;

            cmd.ExecuteNonQuery();
            transacao.Commit();

            return true;
        }

        

    }
}
