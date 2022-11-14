using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroBanco
{
    internal class Empregado
    {
        public string _nome;
        public int _idGer;
        public string _funcao;
        public int _idDept;
        public string _dataAdmissao;
        public string _salario;
        public string _comissao;


        public Empregado(string nome, int idGer, string funcao, int idDept, string data, string salario, string comissao)
        {
            this._nome = nome;
            this._idGer = idGer;
            this._funcao = funcao;
            this._idDept = idDept;
            this._dataAdmissao = data;
            this._salario = salario;
            this._comissao = comissao;

        }

        public bool gravarEmpregado()
        {
            
            Banco b = new Banco();

            SqlConnection cn = b.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;

            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;

            

            cmd.CommandText = "insert into Empregado values(@nome,@idGerente,@funcao,@idDepartamento,@dataAdmissao,@salario,@comissao);";

            


            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@idGerente", SqlDbType.Int);
            cmd.Parameters.Add("@funcao", SqlDbType.VarChar);
            cmd.Parameters.Add("@idDepartamento", SqlDbType.Int);
            cmd.Parameters.Add("@dataAdmissao", SqlDbType.Date);
            cmd.Parameters.Add("@salario", SqlDbType.Real);
            cmd.Parameters.Add("@comissao", SqlDbType.Real);


            

            cmd.Parameters[0].Value = _nome;
            cmd.Parameters[1].Value = _idGer;
            cmd.Parameters[2].Value = _funcao;
            cmd.Parameters[3].Value = _idDept;
            cmd.Parameters[4].Value = _dataAdmissao;
            cmd.Parameters[5].Value = _salario;
            cmd.Parameters[6].Value = _comissao;




            



            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("cheguei aqui");
                tran.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }


        }



    }

    
}
