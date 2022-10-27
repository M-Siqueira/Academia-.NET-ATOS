namespace ex01
{
    public partial class Form1 : Form
    {
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
                textBox2.Text += textBox1.Text + Environment.NewLine;
                textBox1.Text = String.Empty;
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
        }
    }
}