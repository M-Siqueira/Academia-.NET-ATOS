using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroBanco
{
    internal class Departamento
    {
        public string _nome;
        public string _localizacao;
        public string _orcamento;


        public Departamento(string nome, string localizacao, string orcamento)
        {
            this._nome = nome;
            this._localizacao = localizacao;
            this._orcamento = orcamento;

        }

        public bool gravarDpto()
        {
            Banco b = new Banco();

            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Departamento values(@nome,@localizacao,@orcamento);";


            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@orcamento", SqlDbType.VarChar);

            cmd.Parameters[0].Value = _nome;
            cmd.Parameters[1].Value = _localizacao;
            cmd.Parameters[2].Value = _orcamento;

            try
            {
            cmd.ExecuteNonQuery();
            tran.Commit();
            return true;
            }catch(Exception e)
            {
                tran.Rollback();
                return false;
            }finally
            {
                b.fecharConexao();
            }


        }

        
    }
}
