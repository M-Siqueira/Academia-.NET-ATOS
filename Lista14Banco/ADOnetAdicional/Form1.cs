using System.Data;

namespace ADOnetAdicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa();

            P._Nome = textBox1_nome.Text;

            P._Peso = float.Parse(textBox2_peso.Text);

            if( P.gravarPessoa() ) {

                MessageBox.Show("foi");
            }
            else
            {
                MessageBox.Show("nao foi");
            }


        }

        private void button_consulta_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            DataTable dt = new DataTable();

            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            //Banco banco = new Banco();

            //DataTable dt = new DataTable();

            //dt = banco.executaConsulta("select * from pessoas " + "where nome = '" + textBox_consulta.Text+"'");

            //dataGridView1.DataSource = dt;

            Pessoa p = new Pessoa();

            p._Nome = textBox1_nome.Text;

            p.apagaPessoa();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_consulta_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}