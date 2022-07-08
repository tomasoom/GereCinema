namespace GereCinema
{
    partial class GereFuncionariosFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFuncionarios = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbAddFuncionario = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbEditarFuncionario = new System.Windows.Forms.GroupBox();
            this.txtEditarSalario = new System.Windows.Forms.TextBox();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.lblEditarSalario = new System.Windows.Forms.Label();
            this.txtEditarNome = new System.Windows.Forms.TextBox();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            this.gbListaVendas = new System.Windows.Forms.GroupBox();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.gbVendaSessoes = new System.Windows.Forms.GroupBox();
            this.lbVendaBilhetes = new System.Windows.Forms.ListBox();
            this.gbVendaItems = new System.Windows.Forms.GroupBox();
            this.lbVendaItems = new System.Windows.Forms.ListBox();
            this.lbVendas = new System.Windows.Forms.ListBox();
            this.gbAddFuncionario.SuspendLayout();
            this.gbEditarFuncionario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbListaVendas.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.gbVendaSessoes.SuspendLayout();
            this.gbVendaItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.FormattingEnabled = true;
            this.lbFuncionarios.Location = new System.Drawing.Point(6, 45);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(200, 264);
            this.lbFuncionarios.TabIndex = 0;
            this.lbFuncionarios.SelectedIndexChanged += new System.EventHandler(this.lbFuncionarios_SelectedIndexChanged);
            // 
            // gbAddFuncionario
            // 
            this.gbAddFuncionario.Controls.Add(this.txtSalario);
            this.gbAddFuncionario.Controls.Add(this.lblSalario);
            this.gbAddFuncionario.Controls.Add(this.btnAddFuncionario);
            this.gbAddFuncionario.Controls.Add(this.txtNome);
            this.gbAddFuncionario.Controls.Add(this.lblNome);
            this.gbAddFuncionario.Location = new System.Drawing.Point(6, 315);
            this.gbAddFuncionario.Name = "gbAddFuncionario";
            this.gbAddFuncionario.Size = new System.Drawing.Size(200, 145);
            this.gbAddFuncionario.TabIndex = 1;
            this.gbAddFuncionario.TabStop = false;
            this.gbAddFuncionario.Text = "Adicionar Funcionário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(58, 55);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(118, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(17, 58);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário";
            // 
            // btnAddFuncionario
            // 
            this.btnAddFuncionario.Location = new System.Drawing.Point(10, 81);
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Size = new System.Drawing.Size(166, 47);
            this.btnAddFuncionario.TabIndex = 2;
            this.btnAddFuncionario.Text = "Adicionar";
            this.btnAddFuncionario.UseVisualStyleBackColor = true;
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(118, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gbEditarFuncionario
            // 
            this.gbEditarFuncionario.Controls.Add(this.txtEditarSalario);
            this.gbEditarFuncionario.Controls.Add(this.lblEditarNome);
            this.gbEditarFuncionario.Controls.Add(this.lblEditarSalario);
            this.gbEditarFuncionario.Controls.Add(this.txtEditarNome);
            this.gbEditarFuncionario.Controls.Add(this.btnAlterarFuncionario);
            this.gbEditarFuncionario.Location = new System.Drawing.Point(241, 12);
            this.gbEditarFuncionario.Name = "gbEditarFuncionario";
            this.gbEditarFuncionario.Size = new System.Drawing.Size(635, 91);
            this.gbEditarFuncionario.TabIndex = 2;
            this.gbEditarFuncionario.TabStop = false;
            this.gbEditarFuncionario.Text = "Editar Funcionário";
            // 
            // txtEditarSalario
            // 
            this.txtEditarSalario.Location = new System.Drawing.Point(95, 46);
            this.txtEditarSalario.Name = "txtEditarSalario";
            this.txtEditarSalario.Size = new System.Drawing.Size(180, 20);
            this.txtEditarSalario.TabIndex = 9;
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNome.Location = new System.Drawing.Point(38, 20);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(51, 20);
            this.lblEditarNome.TabIndex = 5;
            this.lblEditarNome.Text = "Nome";
            // 
            // lblEditarSalario
            // 
            this.lblEditarSalario.AutoSize = true;
            this.lblEditarSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarSalario.Location = new System.Drawing.Point(31, 46);
            this.lblEditarSalario.Name = "lblEditarSalario";
            this.lblEditarSalario.Size = new System.Drawing.Size(58, 20);
            this.lblEditarSalario.TabIndex = 8;
            this.lblEditarSalario.Text = "Salário";
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.Location = new System.Drawing.Point(95, 22);
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(180, 20);
            this.txtEditarNome.TabIndex = 6;
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(298, 22);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(210, 47);
            this.btnAlterarFuncionario.TabIndex = 7;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverFuncionario);
            this.groupBox1.Controls.Add(this.lbFuncionarios);
            this.groupBox1.Controls.Add(this.gbAddFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 485);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Funcionários";
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(6, 20);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(200, 23);
            this.btnRemoverFuncionario.TabIndex = 2;
            this.btnRemoverFuncionario.Text = "Remover";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = true;
            // 
            // gbListaVendas
            // 
            this.gbListaVendas.Controls.Add(this.gbVenda);
            this.gbListaVendas.Controls.Add(this.lbVendas);
            this.gbListaVendas.Location = new System.Drawing.Point(242, 110);
            this.gbListaVendas.Name = "gbListaVendas";
            this.gbListaVendas.Size = new System.Drawing.Size(634, 377);
            this.gbListaVendas.TabIndex = 4;
            this.gbListaVendas.TabStop = false;
            this.gbListaVendas.Text = "Lista de Vendas";
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.gbVendaSessoes);
            this.gbVenda.Controls.Add(this.gbVendaItems);
            this.gbVenda.Location = new System.Drawing.Point(226, 19);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(402, 352);
            this.gbVenda.TabIndex = 2;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // gbVendaSessoes
            // 
            this.gbVendaSessoes.Controls.Add(this.lbVendaBilhetes);
            this.gbVendaSessoes.Location = new System.Drawing.Point(203, 20);
            this.gbVendaSessoes.Name = "gbVendaSessoes";
            this.gbVendaSessoes.Size = new System.Drawing.Size(193, 323);
            this.gbVendaSessoes.TabIndex = 1;
            this.gbVendaSessoes.TabStop = false;
            this.gbVendaSessoes.Text = "Bilhetes";
            // 
            // lbVendaBilhetes
            // 
            this.lbVendaBilhetes.FormattingEnabled = true;
            this.lbVendaBilhetes.Location = new System.Drawing.Point(10, 20);
            this.lbVendaBilhetes.Name = "lbVendaBilhetes";
            this.lbVendaBilhetes.Size = new System.Drawing.Size(177, 290);
            this.lbVendaBilhetes.TabIndex = 1;
            // 
            // gbVendaItems
            // 
            this.gbVendaItems.Controls.Add(this.lbVendaItems);
            this.gbVendaItems.Location = new System.Drawing.Point(7, 20);
            this.gbVendaItems.Name = "gbVendaItems";
            this.gbVendaItems.Size = new System.Drawing.Size(190, 323);
            this.gbVendaItems.TabIndex = 0;
            this.gbVendaItems.TabStop = false;
            this.gbVendaItems.Text = "Items";
            // 
            // lbVendaItems
            // 
            this.lbVendaItems.FormattingEnabled = true;
            this.lbVendaItems.Location = new System.Drawing.Point(7, 20);
            this.lbVendaItems.Name = "lbVendaItems";
            this.lbVendaItems.Size = new System.Drawing.Size(177, 290);
            this.lbVendaItems.TabIndex = 0;
            // 
            // lbVendas
            // 
            this.lbVendas.FormattingEnabled = true;
            this.lbVendas.Location = new System.Drawing.Point(7, 20);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(213, 342);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.SelectedIndexChanged += new System.EventHandler(this.lbVendas_SelectedIndexChanged);
            // 
            // GereFuncionariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 490);
            this.Controls.Add(this.gbListaVendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEditarFuncionario);
            this.Name = "GereFuncionariosFrm";
            this.Text = "GereFuncionarios/Vendas";
            this.Load += new System.EventHandler(this.GereFuncionariosFrm_Load);
            this.gbAddFuncionario.ResumeLayout(false);
            this.gbAddFuncionario.PerformLayout();
            this.gbEditarFuncionario.ResumeLayout(false);
            this.gbEditarFuncionario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbListaVendas.ResumeLayout(false);
            this.gbVenda.ResumeLayout(false);
            this.gbVendaSessoes.ResumeLayout(false);
            this.gbVendaItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFuncionarios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbAddFuncionario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbEditarFuncionario;
        private System.Windows.Forms.TextBox txtEditarSalario;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.Label lblEditarSalario;
        private System.Windows.Forms.TextBox txtEditarNome;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverFuncionario;
        private System.Windows.Forms.GroupBox gbListaVendas;
        private System.Windows.Forms.ListBox lbVendas;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.GroupBox gbVendaSessoes;
        private System.Windows.Forms.ListBox lbVendaBilhetes;
        private System.Windows.Forms.GroupBox gbVendaItems;
        private System.Windows.Forms.ListBox lbVendaItems;
    }
}