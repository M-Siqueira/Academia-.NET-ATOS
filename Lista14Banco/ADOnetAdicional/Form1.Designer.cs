namespace ADOnetAdicional
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.textBox2_peso = new System.Windows.Forms.TextBox();
            this.textBox_consulta = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_consulta = new System.Windows.Forms.Button();
            this.button_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(403, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.Location = new System.Drawing.Point(38, 42);
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(100, 23);
            this.textBox1_nome.TabIndex = 1;
            // 
            // textBox2_peso
            // 
            this.textBox2_peso.Location = new System.Drawing.Point(38, 100);
            this.textBox2_peso.Name = "textBox2_peso";
            this.textBox2_peso.Size = new System.Drawing.Size(100, 23);
            this.textBox2_peso.TabIndex = 2;
            // 
            // textBox_consulta
            // 
            this.textBox_consulta.Location = new System.Drawing.Point(420, 33);
            this.textBox_consulta.Name = "textBox_consulta";
            this.textBox_consulta.Size = new System.Drawing.Size(185, 23);
            this.textBox_consulta.TabIndex = 3;
            this.textBox_consulta.TextChanged += new System.EventHandler(this.textBox_consulta_TextChanged);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(38, 24);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 15);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "nome";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(38, 82);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(32, 15);
            this.label_peso.TabIndex = 5;
            this.label_peso.Text = "peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "consulta/filtro";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(38, 163);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 7;
            this.button_salvar.Text = "salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_consulta
            // 
            this.button_consulta.Location = new System.Drawing.Point(331, 99);
            this.button_consulta.Name = "button_consulta";
            this.button_consulta.Size = new System.Drawing.Size(75, 23);
            this.button_consulta.TabIndex = 8;
            this.button_consulta.Text = "consulta";
            this.button_consulta.UseVisualStyleBackColor = true;
            this.button_consulta.Click += new System.EventHandler(this.button_consulta_Click);
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(445, 99);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(75, 23);
            this.button_filtrar.TabIndex = 9;
            this.button_filtrar.Text = "filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.button_consulta);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_consulta);
            this.Controls.Add(this.textBox2_peso);
            this.Controls.Add(this.textBox1_nome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ADOnet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1_nome;
        private TextBox textBox2_peso;
        private TextBox textBox_consulta;
        private Label label_nome;
        private Label label_peso;
        private Label label3;
        private Button button_salvar;
        private Button button_consulta;
        private Button button_filtrar;
    }
}