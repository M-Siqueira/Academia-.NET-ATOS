using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace segundoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button_cadastrar.Visible = false;
            button_delete.Visible = false;
            button_editar.Visible = false;
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            //testa conexao com o banco e habilita o form para o CRUD.

            Banco banco = new Banco();

            banco.abrirConexao();

            //implementar para trazer uma lista os arquivos que estao no banco.

            panel_painelBaixo.Visible = true;
            panel_painelBaixo.Enabled = true;

            button_cadastrar.Visible = true;
            button_delete.Visible = true;
            button_editar.Visible = true;

            string sql = "select paciente.idPaciente, paciente.nomePaciente, valores.idGlicemia, valores.valorGlicemia, valores.dataMedida from paciente inner join valores on paciente.idPaciente = valores.idPaciente";

            DataTable dt = new DataTable();

            dt = banco.populaLista(sql);

            











            banco.fecharConexao();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            button_delete.Enabled = true;
            button_editar.Enabled = true;
            button_salvar.Enabled = true;
            button_novoPaciente.Enabled = true;

            textBox_valorGlicemico.Enabled = true;
            textBox_dataDeMedicao.Enabled = true;
            textBox_idDoPaciente.Enabled = true;
            textBox_nomePaciente.Enabled = true;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            Valor valor = new Valor(textBox_idDoPaciente.Text);//na vdd estou passando o id da glicemia
            valor.apagaValor();

        }

        private void button_editar_Click(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Valor valor = new Valor(textBox_idDoPaciente.Text,textBox_valorGlicemico.Text,textBox_dataDeMedicao.Text);

            if (valor.gravaValor())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar empregado!", "Erro!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_novoPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(textBox_nomePaciente.Text);

            if (paciente.gravaPaciente())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar empregado!", "Erro!");
        }

        private void textBox_idDoPaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}