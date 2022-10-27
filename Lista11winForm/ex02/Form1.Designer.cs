namespace ex02
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
            this.Nome = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.textBox2_email = new System.Windows.Forms.TextBox();
            this.button1_cadastro = new System.Windows.Forms.Button();
            this.button2_listaNome = new System.Windows.Forms.Button();
            this.button3_listaEmail = new System.Windows.Forms.Button();
            this.textBox1_listaNomes = new System.Windows.Forms.TextBox();
            this.textBox2_listaEmail = new System.Windows.Forms.TextBox();
            this.button4_listaDominio = new System.Windows.Forms.Button();
            this.textBox3_listaDominios = new System.Windows.Forms.TextBox();
            this.button0_limpaTela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 52);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.Location = new System.Drawing.Point(56, 19);
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(157, 23);
            this.textBox1_nome.TabIndex = 2;
            this.textBox1_nome.TextChanged += new System.EventHandler(this.textBox1_nome_TextChanged);
            // 
            // textBox2_email
            // 
            this.textBox2_email.Location = new System.Drawing.Point(56, 52);
            this.textBox2_email.Name = "textBox2_email";
            this.textBox2_email.Size = new System.Drawing.Size(157, 23);
            this.textBox2_email.TabIndex = 3;
            this.textBox2_email.TextChanged += new System.EventHandler(this.textBox2_email_TextChanged);
            // 
            // button1_cadastro
            // 
            this.button1_cadastro.Location = new System.Drawing.Point(219, 35);
            this.button1_cadastro.Name = "button1_cadastro";
            this.button1_cadastro.Size = new System.Drawing.Size(75, 23);
            this.button1_cadastro.TabIndex = 4;
            this.button1_cadastro.Text = "cadastrar";
            this.button1_cadastro.UseVisualStyleBackColor = true;
            this.button1_cadastro.Click += new System.EventHandler(this.button1_cadastro_Click);
            // 
            // button2_listaNome
            // 
            this.button2_listaNome.Location = new System.Drawing.Point(12, 90);
            this.button2_listaNome.Name = "button2_listaNome";
            this.button2_listaNome.Size = new System.Drawing.Size(111, 23);
            this.button2_listaNome.TabIndex = 5;
            this.button2_listaNome.Text = "Listar Nomes";
            this.button2_listaNome.UseVisualStyleBackColor = true;
            this.button2_listaNome.Click += new System.EventHandler(this.button2_listaNome_Click);
            // 
            // button3_listaEmail
            // 
            this.button3_listaEmail.Location = new System.Drawing.Point(157, 90);
            this.button3_listaEmail.Name = "button3_listaEmail";
            this.button3_listaEmail.Size = new System.Drawing.Size(100, 23);
            this.button3_listaEmail.TabIndex = 6;
            this.button3_listaEmail.Text = "Listar Email";
            this.button3_listaEmail.UseVisualStyleBackColor = true;
            this.button3_listaEmail.Click += new System.EventHandler(this.button3_listaEmail_Click);
            // 
            // textBox1_listaNomes
            // 
            this.textBox1_listaNomes.Location = new System.Drawing.Point(12, 139);
            this.textBox1_listaNomes.Multiline = true;
            this.textBox1_listaNomes.Name = "textBox1_listaNomes";
            this.textBox1_listaNomes.Size = new System.Drawing.Size(111, 299);
            this.textBox1_listaNomes.TabIndex = 7;
            // 
            // textBox2_listaEmail
            // 
            this.textBox2_listaEmail.Location = new System.Drawing.Point(157, 139);
            this.textBox2_listaEmail.Multiline = true;
            this.textBox2_listaEmail.Name = "textBox2_listaEmail";
            this.textBox2_listaEmail.Size = new System.Drawing.Size(100, 299);
            this.textBox2_listaEmail.TabIndex = 8;
            // 
            // button4_listaDominio
            // 
            this.button4_listaDominio.Location = new System.Drawing.Point(289, 90);
            this.button4_listaDominio.Name = "button4_listaDominio";
            this.button4_listaDominio.Size = new System.Drawing.Size(100, 23);
            this.button4_listaDominio.TabIndex = 9;
            this.button4_listaDominio.Text = "Dominios";
            this.button4_listaDominio.UseVisualStyleBackColor = true;
            this.button4_listaDominio.Click += new System.EventHandler(this.button4_listaDominio_Click);
            // 
            // textBox3_listaDominios
            // 
            this.textBox3_listaDominios.Location = new System.Drawing.Point(289, 139);
            this.textBox3_listaDominios.Multiline = true;
            this.textBox3_listaDominios.Name = "textBox3_listaDominios";
            this.textBox3_listaDominios.Size = new System.Drawing.Size(100, 299);
            this.textBox3_listaDominios.TabIndex = 10;
            // 
            // button0_limpaTela
            // 
            this.button0_limpaTela.Location = new System.Drawing.Point(314, 35);
            this.button0_limpaTela.Name = "button0_limpaTela";
            this.button0_limpaTela.Size = new System.Drawing.Size(75, 23);
            this.button0_limpaTela.TabIndex = 11;
            this.button0_limpaTela.Text = "Limpar tela";
            this.button0_limpaTela.UseVisualStyleBackColor = true;
            this.button0_limpaTela.Click += new System.EventHandler(this.button0_limpaTela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.button0_limpaTela);
            this.Controls.Add(this.textBox3_listaDominios);
            this.Controls.Add(this.button4_listaDominio);
            this.Controls.Add(this.textBox2_listaEmail);
            this.Controls.Add(this.textBox1_listaNomes);
            this.Controls.Add(this.button3_listaEmail);
            this.Controls.Add(this.button2_listaNome);
            this.Controls.Add(this.button1_cadastro);
            this.Controls.Add(this.textBox2_email);
            this.Controls.Add(this.textBox1_nome);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "ex02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label Email;
        private TextBox textBox1_nome;
        private TextBox textBox2_email;
        private Button button1_cadastro;
        private Button button2_listaNome;
        private Button button3_listaEmail;
        private TextBox textBox1_listaNomes;
        private TextBox textBox2_listaEmail;
        private Button button4_listaDominio;
        private TextBox textBox3_listaDominios;
        private Button button0_limpaTela;
    }
}