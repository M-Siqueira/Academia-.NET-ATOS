using System.Linq;

namespace ex03
{
    public partial class Form1 : Form
    {

        List<Moeda> moedaList = new List<Moeda>();



        public Form1()
        {
            InitializeComponent();



        }

        private void button_cadastra_Click(object sender, EventArgs e)
        {
            //textBox4_saida.Text += textBox1_sigla.Text.ToUpper() + Environment.NewLine; 
            //textBox4_saida.Text += textBox2_nome.Text.ToUpper() + Environment.NewLine;
            //textBox4_saida.Text += textBox3_valor.Text.ToUpper() + Environment.NewLine;
            //textBox4_saida.Text += Environment.NewLine;



            Moeda moeda = new Moeda(textBox1_sigla.Text.ToUpper(), textBox2_nome.Text.ToUpper(), textBox3_valor.Text.ToUpper());


            moedaList.Add(moeda);
            MessageBox.Show("cadastrado na lista");

            textBox1_sigla.Clear();
            textBox2_nome.Clear();
            textBox3_valor.Clear();



        }

        private void button1_consultaSigla_Click(object sender, EventArgs e)
        {
            var aux = comboBox1_remover.Text;
            var aux2 = textBox1_sigla.Text.ToUpper();

            textBox4_saida.Clear();

            foreach (Moeda moeda in moedaList)
            {
                if (moeda._sigla.Contains(aux2))
                {
                    textBox4_saida.Text += moeda._sigla + Environment.NewLine;
                    textBox4_saida.Text += moeda._name + Environment.NewLine;
                    textBox4_saida.Text += moeda._valor + Environment.NewLine;

                }else if (moeda._sigla.Contains(aux))
                {
                    textBox4_saida.Text += moeda._sigla + Environment.NewLine;
                    textBox4_saida.Text += moeda._name + Environment.NewLine;
                    textBox4_saida.Text += moeda._valor + Environment.NewLine;

                }
            }


        }

        private void button3_listar_Click(object sender, EventArgs e)
        {
            textBox4_saida.Clear();

            foreach (Moeda moeda in moedaList)
            {
                textBox4_saida.Text += moeda._sigla + Environment.NewLine;
                textBox4_saida.Text += moeda._name + Environment.NewLine;
                textBox4_saida.Text += moeda._valor + Environment.NewLine;

            }



        }

        private void button_remover_Click(object sender, EventArgs e)
        {
            var aux = comboBox1_remover.Text;



            foreach (Moeda moeda in moedaList)
            {
                if (moeda._sigla.Contains(aux))
                {
                    moedaList.Remove(moeda);

                    MessageBox.Show("apagado " + aux + "!");
                    break;
                }
                else
                {
                    MessageBox.Show("sem moeda");
                    break;
                }
            }

        }
    }
}