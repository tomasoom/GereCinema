namespace GereCinema
{
    partial class GereFilmesFrm
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
            this.gbListaFilmes = new System.Windows.Forms.GroupBox();
            this.btnRemoveFilme = new System.Windows.Forms.Button();
            this.gbAddFilme = new System.Windows.Forms.GroupBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.btnAddFilme = new System.Windows.Forms.Button();
            this.cboClassEtaria = new System.Windows.Forms.ComboBox();
            this.lblClassEtaria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbFilmes = new System.Windows.Forms.ListBox();
            this.gbEditarFilme = new System.Windows.Forms.GroupBox();
            this.lblEditarDuracao = new System.Windows.Forms.Label();
            this.txtEditarDuracao = new System.Windows.Forms.TextBox();
            this.cboEditarClassEtaria = new System.Windows.Forms.ComboBox();
            this.lblEditarClassEtaria = new System.Windows.Forms.Label();
            this.cboEditarTipo = new System.Windows.Forms.ComboBox();
            this.lblEditarTitulo = new System.Windows.Forms.Label();
            this.lblEditarTipo = new System.Windows.Forms.Label();
            this.txtEditarTitulo = new System.Windows.Forms.TextBox();
            this.btnAlterarFilme = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbEditarPreco = new System.Windows.Forms.Label();
            this.txtEditarPreco = new System.Windows.Forms.TextBox();
            this.gbListaFilmes.SuspendLayout();
            this.gbAddFilme.SuspendLayout();
            this.gbEditarFilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListaFilmes
            // 
            this.gbListaFilmes.Controls.Add(this.btnRemoveFilme);
            this.gbListaFilmes.Controls.Add(this.gbAddFilme);
            this.gbListaFilmes.Controls.Add(this.lbFilmes);
            this.gbListaFilmes.Location = new System.Drawing.Point(12, 12);
            this.gbListaFilmes.Name = "gbListaFilmes";
            this.gbListaFilmes.Size = new System.Drawing.Size(246, 536);
            this.gbListaFilmes.TabIndex = 0;
            this.gbListaFilmes.TabStop = false;
            this.gbListaFilmes.Text = "Lista de Filmes";
            // 
            // btnRemoveFilme
            // 
            this.btnRemoveFilme.Location = new System.Drawing.Point(6, 19);
            this.btnRemoveFilme.Name = "btnRemoveFilme";
            this.btnRemoveFilme.Size = new System.Drawing.Size(234, 23);
            this.btnRemoveFilme.TabIndex = 3;
            this.btnRemoveFilme.Text = "Remover";
            this.btnRemoveFilme.UseVisualStyleBackColor = true;
            this.btnRemoveFilme.Click += new System.EventHandler(this.btnRemoveFilme_Click);
            // 
            // gbAddFilme
            // 
            this.gbAddFilme.Controls.Add(this.txtPreco);
            this.gbAddFilme.Controls.Add(this.lbPreco);
            this.gbAddFilme.Controls.Add(this.txtDuracao);
            this.gbAddFilme.Controls.Add(this.lblDuracao);
            this.gbAddFilme.Controls.Add(this.btnAddFilme);
            this.gbAddFilme.Controls.Add(this.cboClassEtaria);
            this.gbAddFilme.Controls.Add(this.lblClassEtaria);
            this.gbAddFilme.Controls.Add(this.lblTipo);
            this.gbAddFilme.Controls.Add(this.cboTipo);
            this.gbAddFilme.Controls.Add(this.txtTitulo);
            this.gbAddFilme.Controls.Add(this.lblTitulo);
            this.gbAddFilme.Location = new System.Drawing.Point(6, 334);
            this.gbAddFilme.Name = "gbAddFilme";
            this.gbAddFilme.Size = new System.Drawing.Size(235, 196);
            this.gbAddFilme.TabIndex = 1;
            this.gbAddFilme.TabStop = false;
            this.gbAddFilme.Text = "Adicionar Filme";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(118, 116);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(100, 20);
            this.txtDuracao.TabIndex = 8;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(16, 119);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(96, 13);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "Duração (minutos):";
            // 
            // btnAddFilme
            // 
            this.btnAddFilme.Location = new System.Drawing.Point(19, 168);
            this.btnAddFilme.Name = "btnAddFilme";
            this.btnAddFilme.Size = new System.Drawing.Size(201, 22);
            this.btnAddFilme.TabIndex = 6;
            this.btnAddFilme.Text = "Adicionar";
            this.btnAddFilme.UseVisualStyleBackColor = true;
            this.btnAddFilme.Click += new System.EventHandler(this.btnAddFilme_Click);
            // 
            // cboClassEtaria
            // 
            this.cboClassEtaria.FormattingEnabled = true;
            this.cboClassEtaria.Items.AddRange(new object[] {
            "3",
            "6 ",
            "12",
            "14",
            "16 ",
            "18"});
            this.cboClassEtaria.Location = new System.Drawing.Point(90, 85);
            this.cboClassEtaria.Name = "cboClassEtaria";
            this.cboClassEtaria.Size = new System.Drawing.Size(130, 21);
            this.cboClassEtaria.TabIndex = 5;
            // 
            // lblClassEtaria
            // 
            this.lblClassEtaria.AutoSize = true;
            this.lblClassEtaria.Location = new System.Drawing.Point(16, 88);
            this.lblClassEtaria.Name = "lblClassEtaria";
            this.lblClassEtaria.Size = new System.Drawing.Size(68, 13);
            this.lblClassEtaria.TabIndex = 4;
            this.lblClassEtaria.Text = "Class. Etária:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Ação",
            "Comédia",
            "Drama",
            "Fantasia",
            "Terror",
            "Mistério",
            "Romance",
            "Thriller"});
            this.cboTipo.Location = new System.Drawing.Point(60, 55);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(160, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(60, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(160, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lbFilmes
            // 
            this.lbFilmes.FormattingEnabled = true;
            this.lbFilmes.Location = new System.Drawing.Point(6, 45);
            this.lbFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.lbFilmes.Name = "lbFilmes";
            this.lbFilmes.Size = new System.Drawing.Size(236, 277);
            this.lbFilmes.TabIndex = 0;
            this.lbFilmes.SelectedIndexChanged += new System.EventHandler(this.lbFilmes_SelectedIndexChanged);
            // 
            // gbEditarFilme
            // 
            this.gbEditarFilme.Controls.Add(this.lbEditarPreco);
            this.gbEditarFilme.Controls.Add(this.txtEditarPreco);
            this.gbEditarFilme.Controls.Add(this.lblEditarDuracao);
            this.gbEditarFilme.Controls.Add(this.txtEditarDuracao);
            this.gbEditarFilme.Controls.Add(this.cboEditarClassEtaria);
            this.gbEditarFilme.Controls.Add(this.lblEditarClassEtaria);
            this.gbEditarFilme.Controls.Add(this.cboEditarTipo);
            this.gbEditarFilme.Controls.Add(this.lblEditarTitulo);
            this.gbEditarFilme.Controls.Add(this.lblEditarTipo);
            this.gbEditarFilme.Controls.Add(this.txtEditarTitulo);
            this.gbEditarFilme.Controls.Add(this.btnAlterarFilme);
            this.gbEditarFilme.Location = new System.Drawing.Point(264, 12);
            this.gbEditarFilme.Name = "gbEditarFilme";
            this.gbEditarFilme.Size = new System.Drawing.Size(583, 535);
            this.gbEditarFilme.TabIndex = 3;
            this.gbEditarFilme.TabStop = false;
            this.gbEditarFilme.Text = "Editar Filme";
            // 
            // lblEditarDuracao
            // 
            this.lblEditarDuracao.AutoSize = true;
            this.lblEditarDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarDuracao.Location = new System.Drawing.Point(32, 271);
            this.lblEditarDuracao.Name = "lblEditarDuracao";
            this.lblEditarDuracao.Size = new System.Drawing.Size(74, 20);
            this.lblEditarDuracao.TabIndex = 11;
            this.lblEditarDuracao.Text = "Duração:";
            // 
            // txtEditarDuracao
            // 
            this.txtEditarDuracao.Location = new System.Drawing.Point(112, 271);
            this.txtEditarDuracao.Name = "txtEditarDuracao";
            this.txtEditarDuracao.Size = new System.Drawing.Size(180, 20);
            this.txtEditarDuracao.TabIndex = 12;
            // 
            // cboEditarClassEtaria
            // 
            this.cboEditarClassEtaria.FormattingEnabled = true;
            this.cboEditarClassEtaria.Items.AddRange(new object[] {
            "3",
            "6 ",
            "12",
            "14",
            "16 ",
            "18"});
            this.cboEditarClassEtaria.Location = new System.Drawing.Point(112, 244);
            this.cboEditarClassEtaria.Name = "cboEditarClassEtaria";
            this.cboEditarClassEtaria.Size = new System.Drawing.Size(180, 21);
            this.cboEditarClassEtaria.TabIndex = 9;
            // 
            // lblEditarClassEtaria
            // 
            this.lblEditarClassEtaria.AutoSize = true;
            this.lblEditarClassEtaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarClassEtaria.Location = new System.Drawing.Point(8, 245);
            this.lblEditarClassEtaria.Name = "lblEditarClassEtaria";
            this.lblEditarClassEtaria.Size = new System.Drawing.Size(102, 20);
            this.lblEditarClassEtaria.TabIndex = 10;
            this.lblEditarClassEtaria.Text = "Class. Etária:";
            // 
            // cboEditarTipo
            // 
            this.cboEditarTipo.FormattingEnabled = true;
            this.cboEditarTipo.Items.AddRange(new object[] {
            "Ação",
            "Comédia",
            "Drama",
            "Fantasia",
            "Terror",
            "Mistério",
            "Romance",
            "Thriller"});
            this.cboEditarTipo.Location = new System.Drawing.Point(112, 218);
            this.cboEditarTipo.Name = "cboEditarTipo";
            this.cboEditarTipo.Size = new System.Drawing.Size(180, 21);
            this.cboEditarTipo.TabIndex = 7;
            // 
            // lblEditarTitulo
            // 
            this.lblEditarTitulo.AutoSize = true;
            this.lblEditarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTitulo.Location = new System.Drawing.Point(55, 192);
            this.lblEditarTitulo.Name = "lblEditarTitulo";
            this.lblEditarTitulo.Size = new System.Drawing.Size(51, 20);
            this.lblEditarTitulo.TabIndex = 5;
            this.lblEditarTitulo.Text = "Título:";
            // 
            // lblEditarTipo
            // 
            this.lblEditarTipo.AutoSize = true;
            this.lblEditarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTipo.Location = new System.Drawing.Point(63, 219);
            this.lblEditarTipo.Name = "lblEditarTipo";
            this.lblEditarTipo.Size = new System.Drawing.Size(43, 20);
            this.lblEditarTipo.TabIndex = 8;
            this.lblEditarTipo.Text = "Tipo:";
            // 
            // txtEditarTitulo
            // 
            this.txtEditarTitulo.Location = new System.Drawing.Point(112, 194);
            this.txtEditarTitulo.Name = "txtEditarTitulo";
            this.txtEditarTitulo.Size = new System.Drawing.Size(180, 20);
            this.txtEditarTitulo.TabIndex = 6;
            // 
            // btnAlterarFilme
            // 
            this.btnAlterarFilme.Location = new System.Drawing.Point(307, 194);
            this.btnAlterarFilme.Name = "btnAlterarFilme";
            this.btnAlterarFilme.Size = new System.Drawing.Size(249, 97);
            this.btnAlterarFilme.TabIndex = 7;
            this.btnAlterarFilme.Text = "Alterar";
            this.btnAlterarFilme.UseVisualStyleBackColor = true;
            this.btnAlterarFilme.Click += new System.EventHandler(this.btnAlterarFilme_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(119, 142);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 10;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(19, 145);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 9;
            this.lbPreco.Text = "Preço:";
            // 
            // lbEditarPreco
            // 
            this.lbEditarPreco.AutoSize = true;
            this.lbEditarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarPreco.Location = new System.Drawing.Point(32, 302);
            this.lbEditarPreco.Name = "lbEditarPreco";
            this.lbEditarPreco.Size = new System.Drawing.Size(54, 20);
            this.lbEditarPreco.TabIndex = 13;
            this.lbEditarPreco.Text = "Preço:";
            // 
            // txtEditarPreco
            // 
            this.txtEditarPreco.Location = new System.Drawing.Point(112, 302);
            this.txtEditarPreco.Name = "txtEditarPreco";
            this.txtEditarPreco.Size = new System.Drawing.Size(180, 20);
            this.txtEditarPreco.TabIndex = 14;
            // 
            // GereFilmesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 619);
            this.Controls.Add(this.gbEditarFilme);
            this.Controls.Add(this.gbListaFilmes);
            this.Name = "GereFilmesFrm";
            this.Text = "GereFilmesFrm";
            this.Load += new System.EventHandler(this.GereFilmesFrm_Load);
            this.gbListaFilmes.ResumeLayout(false);
            this.gbAddFilme.ResumeLayout(false);
            this.gbAddFilme.PerformLayout();
            this.gbEditarFilme.ResumeLayout(false);
            this.gbEditarFilme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListaFilmes;
        private System.Windows.Forms.GroupBox gbAddFilme;
        private System.Windows.Forms.ComboBox cboClassEtaria;
        private System.Windows.Forms.Label lblClassEtaria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAddFilme;
        private System.Windows.Forms.GroupBox gbEditarFilme;
        private System.Windows.Forms.ComboBox cboEditarClassEtaria;
        private System.Windows.Forms.Label lblEditarClassEtaria;
        private System.Windows.Forms.ComboBox cboEditarTipo;
        private System.Windows.Forms.Label lblEditarTitulo;
        private System.Windows.Forms.Label lblEditarTipo;
        private System.Windows.Forms.TextBox txtEditarTitulo;
        private System.Windows.Forms.Button btnAlterarFilme;
        private System.Windows.Forms.ListBox lbFilmes;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblEditarDuracao;
        private System.Windows.Forms.TextBox txtEditarDuracao;
        private System.Windows.Forms.Button btnRemoveFilme;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbEditarPreco;
        private System.Windows.Forms.TextBox txtEditarPreco;
    }
}