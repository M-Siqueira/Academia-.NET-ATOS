using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoBanco
{
    internal class Banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=glicemia_db; User ID=sa; password=12345;language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                //tentar fazer algo
                conexao();
                cn.Open();
                MessageBox.Show("conexão de teste estabelecida");
                return cn;
            }
            catch (Exception ex)
            {
                //faz algo se deu erro
                MessageBox.Show("erro de conexão");
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                MessageBox.Show("fechando conexao");
                cn.Close();


            }
            catch (Exception e)
            {
                //MessageBox.Show("erro de encerramento");
                return;
            }
        }

        public DataTable populaLista(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);

                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }

        }

    }
}
