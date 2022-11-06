namespace exExtraForms
{
    public partial class Form1 : Form
    {
        List<string> listaJogador = new List<string>();//usado nas comparacoes
        List<string> listaEmail = new List<string>();//usadpo nas comparacoes

        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();

            Ferramentas ferr = new Ferramentas();

            ferr.PopulaArquivoLista( players, listaJogador, listaEmail, "exemplo.csv");//popula as listas com base no arqiovo
        }

        private void button1_cadastra_Click(object sender, EventArgs e) //cadastra o nome na lista do front e na lista de array
        {
            
            if (listaJogador.Contains(textBox1_nomePlayer.Text.ToUpper()) || (!textBox1_nomePlayer.Text.ToUpper().Contains(" ")))
            {
                MessageBox.Show("duplicado ou nao é composto");
                textBox1_nomePlayer.Clear();
                textBox1_nomePlayer.Focus();
            }
            else
            {
                Player jogador = new Player(textBox1_nomePlayer.Text.ToUpper(), (textBox1_nomePlayer.Text.ToUpper() + "@EMAIL.COM.BR"));

                players.Add(jogador);



                textBox_listaCadastrados.Text += (textBox1_nomePlayer.Text.ToUpper()) + Environment.NewLine;

                listaJogador.Add(textBox1_nomePlayer.Text.ToUpper());

                listaEmail.Add(textBox1_nomePlayer.Text.ToUpper() + "@EMAIL.COM.BR");

                textBox1_nomePlayer.Clear();
                textBox1_nomePlayer.Focus();//mantem o foco no text de cadastro nome

            }

        }

        private void button_limpaLista_Click(object sender, EventArgs e) //limpa a lista no front
        {
            textBox_listaCadastrados.Clear();
            //listaJogador.Clear();
            //listaEmail.Clear();

        }

        private void button1_cadastra_KeyPress(object sender, KeyPressEventArgs e)
        {
           





        }

        private void textBox1_nomePlayer_TextChanged(object sender, EventArgs e)
        {





        }

        private void textBox1_nomePlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (listaJogador.Contains(textBox1_nomePlayer.Text.ToUpper()) || (!textBox1_nomePlayer.Text.ToUpper().Contains(" ")))
                {
                    MessageBox.Show("duplicado");
                    textBox1_nomePlayer.Clear();
                    textBox1_nomePlayer.Focus();
                }
                else
                {

                    string nome = textBox1_nomePlayer.Text;//primeiro nome
                    string sobreNome = textBox1_nomePlayer.Text; //ultimo nome



                    Player jogador = new Player(textBox1_nomePlayer.Text.ToUpper(), (textBox1_nomePlayer.Text.ToUpper() + "@EMAIL.COM.BR"));

                    players.Add(jogador);


                    textBox_listaCadastrados.Text += (textBox1_nomePlayer.Text.ToUpper()) + Environment.NewLine;
                    listaJogador.Add(textBox1_nomePlayer.Text.ToUpper());
                    listaEmail.Add(textBox1_nomePlayer.Text.ToUpper() + "@EMAIL.COM.BR");
                    textBox1_nomePlayer.Clear();
                    textBox1_nomePlayer.Focus();//mantem o foco no text de cadastro nome

                }
            }


        }

        private void button_gravaDisco_Click(object sender, EventArgs e)//grava os dados no disco
        {


            Ferramentas ferr = new Ferramentas();

            ferr.GravaArquivo(players, "exemplo.csv");

        }

        private void button_listaJogadores_Click(object sender, EventArgs e)//lista somente os nomes dos jogadores
        {
            textBox_listaCadastrados.Clear();

            foreach (var i in players)
            {

                textBox_listaCadastrados.Text += i.PlayerName + Environment.NewLine;

            }
            textBox1_nomePlayer.Focus();
        }

        private void button_listaEmails_Click(object sender, EventArgs e)//lista somente os emails criados para os jogadores
        {
            textBox_listaCadastrados.Clear();

            foreach (var i in players)
            {

                textBox_listaCadastrados.Text += i.PlayerEmail + Environment.NewLine;

            }
            textBox1_nomePlayer.Focus();
        }
    }
}