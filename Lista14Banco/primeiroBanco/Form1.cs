namespace primeiroBanco
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

        private void button1_conectar_Click(object sender, EventArgs e)
        {
            Departamento D = new Departamento(textBox1_nomeDpto.Text,textBox2_localDpto.Text,textBox3_orcamentoDpto.Text);

            if (D.gravarDpto())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");
        }

        private void button2_encerra_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)//nao levar em consideraçao
        {

        }

        private void button_cadEmpregado_Click(object sender, EventArgs e)
        {


            Empregado E = new Empregado(textBox_nomeEmpregado.Text, int.Parse(textBox_idGerente.Text), textBox_funcao.Text, int.Parse(textBox_idDepartamento.Text), textBox_dataAdmissao.Text, textBox_salario.Text, textBox_comissao.Text) ;
            if (E.gravarEmpregado())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar empregado!", "Erro!");
        }
    }
}