namespace ex03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_sigla = new System.Windows.Forms.TextBox();
            this.textBox2_nome = new System.Windows.Forms.TextBox();
            this.textBox3_valor = new System.Windows.Forms.TextBox();
            this.button1_consultaSigla = new System.Windows.Forms.Button();
            this.button3_listar = new System.Windows.Forms.Button();
            this.textBox4_saida = new System.Windows.Forms.TextBox();
            this.comboBox1_remover = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cadastra = new System.Windows.Forms.Button();
            this.button_remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "meus Cryptos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigla Crypto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Unitario";
            // 
            // textBox1_sigla
            // 
            this.textBox1_sigla.Location = new System.Drawing.Point(102, 54);
            this.textBox1_sigla.Name = "textBox1_sigla";
            this.textBox1_sigla.Size = new System.Drawing.Size(100, 23);
            this.textBox1_sigla.TabIndex = 4;
            // 
            // textBox2_nome
            // 
            this.textBox2_nome.Location = new System.Drawing.Point(102, 87);
            this.textBox2_nome.Name = "textBox2_nome";
            this.textBox2_nome.Size = new System.Drawing.Size(100, 23);
            this.textBox2_nome.TabIndex = 5;
            // 
            // textBox3_valor
            // 
            this.textBox3_valor.Location = new System.Drawing.Point(102, 118);
            this.textBox3_valor.Name = "textBox3_valor";
            this.textBox3_valor.Size = new System.Drawing.Size(100, 23);
            this.textBox3_valor.TabIndex = 6;
            // 
            // button1_consultaSigla
            // 
            this.button1_consultaSigla.Location = new System.Drawing.Point(247, 87);
            this.button1_consultaSigla.Name = "button1_consultaSigla";
            this.button1_consultaSigla.Size = new System.Drawing.Size(101, 23);
            this.button1_consultaSigla.TabIndex = 7;
            this.button1_consultaSigla.Text = "Consulta Sigla";
            this.button1_consultaSigla.UseVisualStyleBackColor = true;
            this.button1_consultaSigla.Click += new System.EventHandler(this.button1_consultaSigla_Click);
            // 
            // button3_listar
            // 
            this.button3_listar.Location = new System.Drawing.Point(247, 118);
            this.button3_listar.Name = "button3_listar";
            this.button3_listar.Size = new System.Drawing.Size(101, 23);
            this.button3_listar.TabIndex = 9;
            this.button3_listar.Text = "Listar Crypto";
            this.button3_listar.UseVisualStyleBackColor = true;
            this.button3_listar.Click += new System.EventHandler(this.button3_listar_Click);
            // 
            // textBox4_saida
            // 
            this.textBox4_saida.Location = new System.Drawing.Point(12, 164);
            this.textBox4_saida.Multiline = true;
            this.textBox4_saida.Name = "textBox4_saida";
            this.textBox4_saida.Size = new System.Drawing.Size(190, 233);
            this.textBox4_saida.TabIndex = 10;
            // 
            // comboBox1_remover
            // 
            this.comboBox1_remover.FormattingEnabled = true;
            this.comboBox1_remover.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "USDT",
            "BNB",
            "USDC"});
            this.comboBox1_remover.Location = new System.Drawing.Point(247, 189);
            this.comboBox1_remover.Name = "comboBox1_remover";
            this.comboBox1_remover.Size = new System.Drawing.Size(121, 23);
            this.comboBox1_remover.TabIndex = 11;
            this.comboBox1_remover.Text = "sua sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remover por Sigla";
            // 
            // button_cadastra
            // 
            this.button_cadastra.Location = new System.Drawing.Point(247, 54);
            this.button_cadastra.Name = "button_cadastra";
            this.button_cadastra.Size = new System.Drawing.Size(101, 23);
            this.button_cadastra.TabIndex = 13;
            this.button_cadastra.Text = "Cadastra Crypto";
            this.button_cadastra.UseVisualStyleBackColor = true;
            this.button_cadastra.Click += new System.EventHandler(this.button_cadastra_Click);
            // 
            // button_remover
            // 
            this.button_remover.Location = new System.Drawing.Point(247, 218);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(101, 23);
            this.button_remover.TabIndex = 14;
            this.button_remover.Text = "Remover Crypto";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.button_remover);
            this.Controls.Add(this.button_cadastra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1_remover);
            this.Controls.Add(this.textBox4_saida);
            this.Controls.Add(this.button3_listar);
            this.Controls.Add(this.button1_consultaSigla);
            this.Controls.Add(this.textBox3_valor);
            this.Controls.Add(this.textBox2_nome);
            this.Controls.Add(this.textBox1_sigla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ex03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1_sigla;
        private TextBox textBox2_nome;
        private TextBox textBox3_valor;
        private Button button1_consultaSigla;
        private Button button3_listar;
        private TextBox textBox4_saida;
        private ComboBox comboBox1_remover;
        private Label label5;
        private Button button_cadastra;
        private Button button_remover;
    }
}