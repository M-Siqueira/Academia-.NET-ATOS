using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ADOnetAdicional
{
    internal class Banco
    {
        private string conec = "Data Source=localhost; Initial Catalog=aula; User ID=sa; password=12345;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try{
                conexao();

                cn.Open();//tenta abrir a conexao

                return cn;  

            }catch(Exception ex)
            {
                return null;
            }
            

        }
        public void fechaConexao()
        {
            try
            {
                cn.Close();

            }
            catch (Exception ex)
            {
                return;
            }
            
        }


        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;

            }
            catch(Exception ex)
            {
                return null ;
            }
            finally
            {
               fechaConexao();  
            }
        }

    }
}
