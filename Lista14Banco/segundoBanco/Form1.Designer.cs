namespace segundoBanco
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
            System.Windows.Forms.ColumnHeader coluna_idPaciente;
            this.listView_dados = new System.Windows.Forms.ListView();
            this.coluna_nomePaciente = new System.Windows.Forms.ColumnHeader();
            this.coluna_idGlicemia = new System.Windows.Forms.ColumnHeader();
            this.coluna_valorGlicemia = new System.Windows.Forms.ColumnHeader();
            this.coluna_dataGlicemia = new System.Windows.Forms.ColumnHeader();
            this.panel_painelBaixo = new System.Windows.Forms.Panel();
            this.button_novoPaciente = new System.Windows.Forms.Button();
            this.textBox_nomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_idDoPaciente = new System.Windows.Forms.TextBox();
            this.textBox_dataDeMedicao = new System.Windows.Forms.TextBox();
            this.textBox_valorGlicemico = new System.Windows.Forms.TextBox();
            this.label_idPaciente = new System.Windows.Forms.Label();
            this.label_dataMedida = new System.Windows.Forms.Label();
            this.label_valorGlicemia = new System.Windows.Forms.Label();
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            coluna_idPaciente = new System.Windows.Forms.ColumnHeader();
            this.panel_painelBaixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // coluna_idPaciente
            // 
            coluna_idPaciente.Text = "idPaciente";
            coluna_idPaciente.Width = 70;
            // 
            // listView_dados
            // 
            this.listView_dados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView_dados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            coluna_idPaciente,
            this.coluna_nomePaciente,
            this.coluna_idGlicemia,
            this.coluna_valorGlicemia,
            this.coluna_dataGlicemia});
            this.listView_dados.Location = new System.Drawing.Point(12, 12);
            this.listView_dados.Name = "listView_dados";
            this.listView_dados.Size = new System.Drawing.Size(443, 168);
            this.listView_dados.TabIndex = 0;
            this.listView_dados.UseCompatibleStateImageBehavior = false;
            this.listView_dados.View = System.Windows.Forms.View.Details;
            // 
            // coluna_nomePaciente
            // 
            this.coluna_nomePaciente.Text = "nome paciente";
            this.coluna_nomePaciente.Width = 100;
            // 
            // coluna_idGlicemia
            // 
            this.coluna_idGlicemia.Text = "idGlicemia";
            this.coluna_idGlicemia.Width = 80;
            // 
            // coluna_valorGlicemia
            // 
            this.coluna_valorGlicemia.Text = "valor glicemia";
            this.coluna_valorGlicemia.Width = 100;
            // 
            // coluna_dataGlicemia
            // 
            this.coluna_dataGlicemia.Text = "data glicemia";
            this.coluna_dataGlicemia.Width = 100;
            // 
            // panel_painelBaixo
            // 
            this.panel_painelBaixo.Controls.Add(this.button_novoPaciente);
            this.panel_painelBaixo.Controls.Add(this.textBox_nomePaciente);
            this.panel_painelBaixo.Controls.Add(this.label2);
            this.panel_painelBaixo.Controls.Add(this.button_salvar);
            this.panel_painelBaixo.Controls.Add(this.textBox_idDoPaciente);
            this.panel_painelBaixo.Controls.Add(this.textBox_dataDeMedicao);
            this.panel_painelBaixo.Controls.Add(this.textBox_valorGlicemico);
            this.panel_painelBaixo.Controls.Add(this.label_idPaciente);
            this.panel_painelBaixo.Controls.Add(this.label_dataMedida);
            this.panel_painelBaixo.Controls.Add(this.label_valorGlicemia);
            this.panel_painelBaixo.Enabled = false;
            this.panel_painelBaixo.Location = new System.Drawing.Point(12, 235);
            this.panel_painelBaixo.Name = "panel_painelBaixo";
            this.panel_painelBaixo.Size = new System.Drawing.Size(443, 203);
            this.panel_painelBaixo.TabIndex = 1;
            // 
            // button_novoPaciente
            // 
            this.button_novoPaciente.Enabled = false;
            this.button_novoPaciente.Location = new System.Drawing.Point(246, 152);
            this.button_novoPaciente.Name = "button_novoPaciente";
            this.button_novoPaciente.Size = new System.Drawing.Size(136, 23);
            this.button_novoPaciente.TabIndex = 13;
            this.button_novoPaciente.Text = "salvar novo paciente";
            this.button_novoPaciente.UseVisualStyleBackColor = true;
            this.button_novoPaciente.Click += new System.EventHandler(this.button_novoPaciente_Click);
            // 
            // textBox_nomePaciente
            // 
            this.textBox_nomePaciente.Enabled = false;
            this.textBox_nomePaciente.Location = new System.Drawing.Point(211, 108);
            this.textBox_nomePaciente.Name = "textBox_nomePaciente";
            this.textBox_nomePaciente.Size = new System.Drawing.Size(229, 23);
            this.textBox_nomePaciente.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "nome Paciente";
            // 
            // button_salvar
            // 
            this.button_salvar.Enabled = false;
            this.button_salvar.Location = new System.Drawing.Point(29, 152);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(133, 23);
            this.button_salvar.TabIndex = 8;
            this.button_salvar.Text = "salvar novo valor";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_idDoPaciente
            // 
            this.textBox_idDoPaciente.Enabled = false;
            this.textBox_idDoPaciente.Location = new System.Drawing.Point(99, 108);
            this.textBox_idDoPaciente.Name = "textBox_idDoPaciente";
            this.textBox_idDoPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBox_idDoPaciente.TabIndex = 7;
            this.textBox_idDoPaciente.TextChanged += new System.EventHandler(this.textBox_idDoPaciente_TextChanged);
            // 
            // textBox_dataDeMedicao
            // 
            this.textBox_dataDeMedicao.Enabled = false;
            this.textBox_dataDeMedicao.Location = new System.Drawing.Point(99, 80);
            this.textBox_dataDeMedicao.Name = "textBox_dataDeMedicao";
            this.textBox_dataDeMedicao.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataDeMedicao.TabIndex = 6;
            this.textBox_dataDeMedicao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_valorGlicemico
            // 
            this.textBox_valorGlicemico.Enabled = false;
            this.textBox_valorGlicemico.Location = new System.Drawing.Point(99, 51);
            this.textBox_valorGlicemico.Name = "textBox_valorGlicemico";
            this.textBox_valorGlicemico.Size = new System.Drawing.Size(100, 23);
            this.textBox_valorGlicemico.TabIndex = 5;
            // 
            // label_idPaciente
            // 
            this.label_idPaciente.AutoSize = true;
            this.label_idPaciente.Location = new System.Drawing.Point(14, 111);
            this.label_idPaciente.Name = "label_idPaciente";
            this.label_idPaciente.Size = new System.Drawing.Size(62, 15);
            this.label_idPaciente.TabIndex = 3;
            this.label_idPaciente.Text = "idPaciente";
            // 
            // label_dataMedida
            // 
            this.label_dataMedida.AutoSize = true;
            this.label_dataMedida.Location = new System.Drawing.Point(14, 83);
            this.label_dataMedida.Name = "label_dataMedida";
            this.label_dataMedida.Size = new System.Drawing.Size(70, 15);
            this.label_dataMedida.TabIndex = 2;
            this.label_dataMedida.Text = "dataMedida";
            // 
            // label_valorGlicemia
            // 
            this.label_valorGlicemia.AutoSize = true;
            this.label_valorGlicemia.Location = new System.Drawing.Point(14, 55);
            this.label_valorGlicemia.Name = "label_valorGlicemia";
            this.label_valorGlicemia.Size = new System.Drawing.Size(79, 15);
            this.label_valorGlicemia.TabIndex = 1;
            this.label_valorGlicemia.Text = "valorGlicemia";
            // 
            // button_conectar
            // 
            this.button_conectar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_conectar.Location = new System.Drawing.Point(12, 186);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(93, 43);
            this.button_conectar.TabIndex = 2;
            this.button_conectar.Text = "teste conexao com banco";
            this.button_conectar.UseVisualStyleBackColor = false;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(133, 196);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(128, 23);
            this.button_cadastrar.TabIndex = 3;
            this.button_cadastrar.Text = "iniciar cadastros";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(291, 196);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "deletar";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_editar
            // 
            this.button_editar.Enabled = false;
            this.button_editar.Location = new System.Drawing.Point(380, 196);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 5;
            this.button_editar.Text = "editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.panel_painelBaixo);
            this.Controls.Add(this.listView_dados);
            this.Name = "Form1";
            this.Text = "segundo banco_glicemia";
            this.panel_painelBaixo.ResumeLayout(false);
            this.panel_painelBaixo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_dados;
        private Panel panel_painelBaixo;
        private Button button_conectar;
        private Button button_cadastrar;
        private Button button_delete;
        private Button button_editar;
        private Label label_idPaciente;
        private Label label_dataMedida;
        private Label label_valorGlicemia;
        private TextBox textBox_idDoPaciente;
        private TextBox textBox_dataDeMedicao;
        private TextBox textBox_valorGlicemico;
        private Button button_salvar;
        private Label label2;
        private TextBox textBox_nomePaciente;
        private ColumnHeader coluna_nomePaciente;
        private ColumnHeader coluna_idGlicemia;
        private ColumnHeader coluna_valorGlicemia;
        private ColumnHeader coluna_dataGlicemia;
        private Button button_novoPaciente;
    }
}