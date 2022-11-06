using System.Linq;

namespace ex01
{
    public partial class Form1 : Form
    {
        List<Pessoa> listPessoas = new List<Pessoa>();

        Pessoa pessoa = new Pessoa();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void button_cadastraLista_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {

                MessageBox.Show("erro na linha. vazio");
            }
            else
            {
                //textBox2.Text += textBox1.Text + Environment.NewLine; ver erros tortais 
                //textBox1.Text = String.Empty;

                var aux = textBox1.Text.ToUpper();

                foreach (var item in listPessoas)
                {
                    MessageBox.Show("cheguei no for");

                    if (aux.Contains(" "))
                    {
                        MessageBox.Show("composto....");
                        if (item._nome.Contains(aux))
                        {
                            Pessoa pessoa = new Pessoa(textBox1.Text.ToUpper());
                            listPessoas.Add(pessoa);
                            MessageBox.Show("cadastrado");
                        }
                        else
                        {
                            MessageBox.Show("ja existente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("nome incompleto");
                    }

                    break;

                }





            }
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_cadastraLista_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button_limpa_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}