using System.Linq;

namespace ex02
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoaList = new List<Pessoa>();

        


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_nome_TextChanged(object sender, EventArgs e)//local do nome
        {

        }

        private void textBox2_email_TextChanged(object sender, EventArgs e)//local do email
        {

        }

        private void button1_cadastro_Click(object sender, EventArgs e)//botao de cadastro
        {
           

            if ((textBox1_nome.Text.Contains(" ")) && textBox2_email.Text.Contains("@"))
            {
                Pessoa pessoa = new Pessoa(textBox1_nome.Text.ToUpper(), textBox2_email.Text.ToUpper());

                pessoaList.Add(pessoa);
            }
            //else
            //{
            //    MessageBox.Show("erro de nome");
            //}


            //textBox1_listaNomes.Text += textBox1_nome.Text.ToUpper() + Environment.NewLine;
            //textBox2_listaEmail.Text += textBox2_email.Text.ToUpper() + Environment.NewLine;
            textBox1_nome.Clear();
            textBox2_email.Clear();

        }

        private void button2_listaNome_Click(object sender, EventArgs e)//botao de llistar nomes
        {
            textBox1_listaNomes.Clear();

            foreach (Pessoa pessoa in pessoaList)
            {
                textBox1_listaNomes.Text += pessoa.pessoaNome + Environment.NewLine;
            }
        }

        private void button3_listaEmail_Click(object sender, EventArgs e)//botao de listar email
        {
            textBox2_listaEmail.Clear();

            foreach (Pessoa pessoa in pessoaList)
            {
               textBox2_listaEmail.
               Text += pessoa.pessoaEmail + Environment.NewLine;
            }
        }

        private void button4_listaDominio_Click(object sender, EventArgs e)//botao de listar Dominios
        {
            textBox3_listaDominios.Clear();

            foreach (Pessoa pessoa in pessoaList)
            {
                var aux = pessoa.pessoaEmail.Split("@");

               textBox3_listaDominios.Text += aux[1] + Environment.NewLine;
            }
        }

        private void button0_limpaTela_Click(object sender, EventArgs e)
        {
            textBox1_nome.Clear();
            textBox2_email.Clear();
            textBox1_listaNomes.Clear();
            textBox2_listaEmail.Clear();
            textBox3_listaDominios.Clear();
        }
    }
}