namespace primeiroBanco
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
            this.button1_conectar = new System.Windows.Forms.Button();
            this.label_nomeDpto = new System.Windows.Forms.Label();
            this.label_localizacao_Dpto = new System.Windows.Forms.Label();
            this.label_orcamento_Dpto = new System.Windows.Forms.Label();
            this.textBox1_nomeDpto = new System.Windows.Forms.TextBox();
            this.textBox2_localDpto = new System.Windows.Forms.TextBox();
            this.textBox3_orcamentoDpto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_nomeEmpregado = new System.Windows.Forms.TextBox();
            this.textBox_idGerente = new System.Windows.Forms.TextBox();
            this.textBox_funcao = new System.Windows.Forms.TextBox();
            this.textBox_idDepartamento = new System.Windows.Forms.TextBox();
            this.textBox_dataAdmissao = new System.Windows.Forms.TextBox();
            this.textBox_salario = new System.Windows.Forms.TextBox();
            this.textBox_comissao = new System.Windows.Forms.TextBox();
            this.button_cadEmpregado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_conectar
            // 
            this.button1_conectar.Location = new System.Drawing.Point(12, 138);
            this.button1_conectar.Name = "button1_conectar";
            this.button1_conectar.Size = new System.Drawing.Size(163, 41);
            this.button1_conectar.TabIndex = 0;
            this.button1_conectar.Text = "abre conexao";
            this.button1_conectar.UseVisualStyleBackColor = true;
            this.button1_conectar.Click += new System.EventHandler(this.button1_conectar_Click);
            // 
            // label_nomeDpto
            // 
            this.label_nomeDpto.AutoSize = true;
            this.label_nomeDpto.Location = new System.Drawing.Point(12, 20);
            this.label_nomeDpto.Name = "label_nomeDpto";
            this.label_nomeDpto.Size = new System.Drawing.Size(116, 15);
            this.label_nomeDpto.TabIndex = 2;
            this.label_nomeDpto.Text = "nome departamento";
            // 
            // label_localizacao_Dpto
            // 
            this.label_localizacao_Dpto.AutoSize = true;
            this.label_localizacao_Dpto.Location = new System.Drawing.Point(12, 61);
            this.label_localizacao_Dpto.Name = "label_localizacao_Dpto";
            this.label_localizacao_Dpto.Size = new System.Drawing.Size(68, 15);
            this.label_localizacao_Dpto.TabIndex = 3;
            this.label_localizacao_Dpto.Text = "Localizacao";
            // 
            // label_orcamento_Dpto
            // 
            this.label_orcamento_Dpto.AutoSize = true;
            this.label_orcamento_Dpto.Location = new System.Drawing.Point(12, 102);
            this.label_orcamento_Dpto.Name = "label_orcamento_Dpto";
            this.label_orcamento_Dpto.Size = new System.Drawing.Size(67, 15);
            this.label_orcamento_Dpto.TabIndex = 4;
            this.label_orcamento_Dpto.Text = "Orcamento";
            // 
            // textBox1_nomeDpto
            // 
            this.textBox1_nomeDpto.Location = new System.Drawing.Point(145, 17);
            this.textBox1_nomeDpto.Name = "textBox1_nomeDpto";
            this.textBox1_nomeDpto.Size = new System.Drawing.Size(204, 23);
            this.textBox1_nomeDpto.TabIndex = 6;
            // 
            // textBox2_localDpto
            // 
            this.textBox2_localDpto.Location = new System.Drawing.Point(145, 61);
            this.textBox2_localDpto.Name = "textBox2_localDpto";
            this.textBox2_localDpto.Size = new System.Drawing.Size(204, 23);
            this.textBox2_localDpto.TabIndex = 7;
            // 
            // textBox3_orcamentoDpto
            // 
            this.textBox3_orcamentoDpto.Location = new System.Drawing.Point(145, 99);
            this.textBox3_orcamentoDpto.Name = "textBox3_orcamentoDpto";
            this.textBox3_orcamentoDpto.Size = new System.Drawing.Size(204, 23);
            this.textBox3_orcamentoDpto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Empregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "id Gerente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Função";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "id Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "data Admissao";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "salario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "comissao";
            // 
            // textBox_nomeEmpregado
            // 
            this.textBox_nomeEmpregado.Location = new System.Drawing.Point(526, 17);
            this.textBox_nomeEmpregado.Name = "textBox_nomeEmpregado";
            this.textBox_nomeEmpregado.Size = new System.Drawing.Size(262, 23);
            this.textBox_nomeEmpregado.TabIndex = 16;
            // 
            // textBox_idGerente
            // 
            this.textBox_idGerente.Location = new System.Drawing.Point(526, 58);
            this.textBox_idGerente.Name = "textBox_idGerente";
            this.textBox_idGerente.Size = new System.Drawing.Size(262, 23);
            this.textBox_idGerente.TabIndex = 17;
            // 
            // textBox_funcao
            // 
            this.textBox_funcao.Location = new System.Drawing.Point(526, 99);
            this.textBox_funcao.Name = "textBox_funcao";
            this.textBox_funcao.Size = new System.Drawing.Size(262, 23);
            this.textBox_funcao.TabIndex = 18;
            // 
            // textBox_idDepartamento
            // 
            this.textBox_idDepartamento.Location = new System.Drawing.Point(526, 138);
            this.textBox_idDepartamento.Name = "textBox_idDepartamento";
            this.textBox_idDepartamento.Size = new System.Drawing.Size(262, 23);
            this.textBox_idDepartamento.TabIndex = 19;
            // 
            // textBox_dataAdmissao
            // 
            this.textBox_dataAdmissao.Location = new System.Drawing.Point(526, 167);
            this.textBox_dataAdmissao.Name = "textBox_dataAdmissao";
            this.textBox_dataAdmissao.Size = new System.Drawing.Size(262, 23);
            this.textBox_dataAdmissao.TabIndex = 20;
            // 
            // textBox_salario
            // 
            this.textBox_salario.Location = new System.Drawing.Point(526, 196);
            this.textBox_salario.Name = "textBox_salario";
            this.textBox_salario.Size = new System.Drawing.Size(262, 23);
            this.textBox_salario.TabIndex = 21;
            // 
            // textBox_comissao
            // 
            this.textBox_comissao.Location = new System.Drawing.Point(526, 232);
            this.textBox_comissao.Name = "textBox_comissao";
            this.textBox_comissao.Size = new System.Drawing.Size(262, 23);
            this.textBox_comissao.TabIndex = 22;
            // 
            // button_cadEmpregado
            // 
            this.button_cadEmpregado.Location = new System.Drawing.Point(526, 288);
            this.button_cadEmpregado.Name = "button_cadEmpregado";
            this.button_cadEmpregado.Size = new System.Drawing.Size(143, 23);
            this.button_cadEmpregado.TabIndex = 23;
            this.button_cadEmpregado.Text = "cadastra empregado";
            this.button_cadEmpregado.UseVisualStyleBackColor = true;
            this.button_cadEmpregado.Click += new System.EventHandler(this.button_cadEmpregado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_cadEmpregado);
            this.Controls.Add(this.textBox_comissao);
            this.Controls.Add(this.textBox_salario);
            this.Controls.Add(this.textBox_dataAdmissao);
            this.Controls.Add(this.textBox_idDepartamento);
            this.Controls.Add(this.textBox_funcao);
            this.Controls.Add(this.textBox_idGerente);
            this.Controls.Add(this.textBox_nomeEmpregado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_orcamentoDpto);
            this.Controls.Add(this.textBox2_localDpto);
            this.Controls.Add(this.textBox1_nomeDpto);
            this.Controls.Add(this.label_orcamento_Dpto);
            this.Controls.Add(this.label_localizacao_Dpto);
            this.Controls.Add(this.label_nomeDpto);
            this.Controls.Add(this.button1_conectar);
            this.Name = "Form1";
            this.Text = "banco 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_conectar;
        private Label label_nomeDpto;
        private Label label_localizacao_Dpto;
        private Label label_orcamento_Dpto;
        private TextBox textBox1_nomeDpto;
        private TextBox textBox2_localDpto;
        private TextBox textBox3_orcamentoDpto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_nomeEmpregado;
        private TextBox textBox_idGerente;
        private TextBox textBox_funcao;
        private TextBox textBox_idDepartamento;
        private TextBox textBox_dataAdmissao;
        private TextBox textBox_salario;
        private TextBox textBox_comissao;
        private Button button_cadEmpregado;
    }
}