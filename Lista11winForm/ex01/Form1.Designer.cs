namespace ex01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_cadastraLista = new System.Windows.Forms.Button();
            this.label_NOME = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_limpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(86, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button_cadastraLista
            // 
            this.button_cadastraLista.Location = new System.Drawing.Point(393, 23);
            this.button_cadastraLista.Name = "button_cadastraLista";
            this.button_cadastraLista.Size = new System.Drawing.Size(75, 23);
            this.button_cadastraLista.TabIndex = 1;
            this.button_cadastraLista.Text = "CADASTRA";
            this.button_cadastraLista.UseVisualStyleBackColor = true;
            this.button_cadastraLista.Click += new System.EventHandler(this.button_cadastraLista_Click);
            this.button_cadastraLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_cadastraLista_KeyDown);
            this.button_cadastraLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // label_NOME
            // 
            this.label_NOME.AutoSize = true;
            this.label_NOME.Location = new System.Drawing.Point(12, 27);
            this.label_NOME.Name = "label_NOME";
            this.label_NOME.Size = new System.Drawing.Size(42, 15);
            this.label_NOME.TabIndex = 2;
            this.label_NOME.Text = "NOME";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(12, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(519, 369);
            this.textBox2.TabIndex = 3;
            // 
            // button_limpa
            // 
            this.button_limpa.Location = new System.Drawing.Point(474, 23);
            this.button_limpa.Name = "button_limpa";
            this.button_limpa.Size = new System.Drawing.Size(75, 23);
            this.button_limpa.TabIndex = 4;
            this.button_limpa.Text = "LIMPAR";
            this.button_limpa.UseVisualStyleBackColor = true;
            this.button_limpa.Click += new System.EventHandler(this.button_limpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.button_limpa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_NOME);
            this.Controls.Add(this.button_cadastraLista);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button_cadastraLista;
        private Label label_NOME;
        private TextBox textBox2;
        private Button button_limpa;
    }
}