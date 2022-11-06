namespace exExtraForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_nomeJogador = new System.Windows.Forms.Label();
            this.textBox1_nomePlayer = new System.Windows.Forms.TextBox();
            this.textBox_listaCadastrados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_cadastra = new System.Windows.Forms.Button();
            this.button_limpaLista = new System.Windows.Forms.Button();
            this.button_gravaDisco = new System.Windows.Forms.Button();
            this.button_listaJogadores = new System.Windows.Forms.Button();
            this.button_listaEmails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_nomeJogador
            // 
            this.label1_nomeJogador.AutoSize = true;
            this.label1_nomeJogador.Location = new System.Drawing.Point(12, 21);
            this.label1_nomeJogador.Name = "label1_nomeJogador";
            this.label1_nomeJogador.Size = new System.Drawing.Size(82, 15);
            this.label1_nomeJogador.TabIndex = 0;
            this.label1_nomeJogador.Text = "nome jogador";
            // 
            // textBox1_nomePlayer
            // 
            this.textBox1_nomePlayer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1_nomePlayer.Location = new System.Drawing.Point(100, 21);
            this.textBox1_nomePlayer.Name = "textBox1_nomePlayer";
            this.textBox1_nomePlayer.Size = new System.Drawing.Size(266, 23);
            this.textBox1_nomePlayer.TabIndex = 1;
            this.textBox1_nomePlayer.Text = "digite seu nome ";
            this.textBox1_nomePlayer.TextChanged += new System.EventHandler(this.textBox1_nomePlayer_TextChanged);
            this.textBox1_nomePlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_nomePlayer_KeyPress);
            // 
            // textBox_listaCadastrados
            // 
            this.textBox_listaCadastrados.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_listaCadastrados.Location = new System.Drawing.Point(100, 81);
            this.textBox_listaCadastrados.Multiline = true;
            this.textBox_listaCadastrados.Name = "textBox_listaCadastrados";
            this.textBox_listaCadastrados.ReadOnly = true;
            this.textBox_listaCadastrados.Size = new System.Drawing.Size(266, 335);
            this.textBox_listaCadastrados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "cadastrados";
            // 
            // button1_cadastra
            // 
            this.button1_cadastra.Location = new System.Drawing.Point(386, 21);
            this.button1_cadastra.Name = "button1_cadastra";
            this.button1_cadastra.Size = new System.Drawing.Size(122, 32);
            this.button1_cadastra.TabIndex = 4;
            this.button1_cadastra.Text = "cadastra";
            this.button1_cadastra.UseVisualStyleBackColor = true;
            this.button1_cadastra.Click += new System.EventHandler(this.button1_cadastra_Click);
            this.button1_cadastra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_cadastra_KeyPress);
            // 
            // button_limpaLista
            // 
            this.button_limpaLista.Location = new System.Drawing.Point(537, 81);
            this.button_limpaLista.Name = "button_limpaLista";
            this.button_limpaLista.Size = new System.Drawing.Size(75, 23);
            this.button_limpaLista.TabIndex = 5;
            this.button_limpaLista.Text = "limpar lista";
            this.button_limpaLista.UseVisualStyleBackColor = true;
            this.button_limpaLista.Click += new System.EventHandler(this.button_limpaLista_Click);
            // 
            // button_gravaDisco
            // 
            this.button_gravaDisco.Location = new System.Drawing.Point(537, 26);
            this.button_gravaDisco.Name = "button_gravaDisco";
            this.button_gravaDisco.Size = new System.Drawing.Size(111, 23);
            this.button_gravaDisco.TabIndex = 6;
            this.button_gravaDisco.Text = "gravar em disco";
            this.button_gravaDisco.UseVisualStyleBackColor = true;
            this.button_gravaDisco.Click += new System.EventHandler(this.button_gravaDisco_Click);
            // 
            // button_listaJogadores
            // 
            this.button_listaJogadores.Location = new System.Drawing.Point(386, 81);
            this.button_listaJogadores.Name = "button_listaJogadores";
            this.button_listaJogadores.Size = new System.Drawing.Size(129, 23);
            this.button_listaJogadores.TabIndex = 7;
            this.button_listaJogadores.Text = "Lista Jogadores";
            this.button_listaJogadores.UseVisualStyleBackColor = true;
            this.button_listaJogadores.Click += new System.EventHandler(this.button_listaJogadores_Click);
            // 
            // button_listaEmails
            // 
            this.button_listaEmails.Location = new System.Drawing.Point(388, 128);
            this.button_listaEmails.Name = "button_listaEmails";
            this.button_listaEmails.Size = new System.Drawing.Size(91, 23);
            this.button_listaEmails.TabIndex = 8;
            this.button_listaEmails.Text = "Lista Emails";
            this.button_listaEmails.UseVisualStyleBackColor = true;
            this.button_listaEmails.Click += new System.EventHandler(this.button_listaEmails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.button_listaEmails);
            this.Controls.Add(this.button_listaJogadores);
            this.Controls.Add(this.button_gravaDisco);
            this.Controls.Add(this.button_limpaLista);
            this.Controls.Add(this.button1_cadastra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_listaCadastrados);
            this.Controls.Add(this.textBox1_nomePlayer);
            this.Controls.Add(this.label1_nomeJogador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1_nomeJogador;
        private TextBox textBox1_nomePlayer;
        private TextBox textBox_listaCadastrados;
        private Label label1;
        private Button button1_cadastra;
        private Button button_limpaLista;
        private Button button_gravaDisco;
        private Button button_listaJogadores;
        private Button button_listaEmails;
    }
}