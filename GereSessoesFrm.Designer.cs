namespace GereCinema
{
    partial class GereSessoesFrm
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
            this.gbAddSessao = new System.Windows.Forms.GroupBox();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAddSessao = new System.Windows.Forms.Button();
            this.gbFilmes = new System.Windows.Forms.GroupBox();
            this.lbFilmes = new System.Windows.Forms.ListBox();
            this.gbSalas = new System.Windows.Forms.GroupBox();
            this.lbSalas = new System.Windows.Forms.ListBox();
            this.gbSessoes = new System.Windows.Forms.GroupBox();
            this.btnRemoveSessao = new System.Windows.Forms.Button();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbAddSessao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbFilmes.SuspendLayout();
            this.gbSalas.SuspendLayout();
            this.gbSessoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddSessao
            // 
            this.gbAddSessao.Controls.Add(this.nudMinutos);
            this.gbAddSessao.Controls.Add(this.nudHoras);
            this.gbAddSessao.Controls.Add(this.dtpDataInicio);
            this.gbAddSessao.Controls.Add(this.btnAddSessao);
            this.gbAddSessao.Controls.Add(this.gbFilmes);
            this.gbAddSessao.Controls.Add(this.gbSalas);
            this.gbAddSessao.Location = new System.Drawing.Point(13, 13);
            this.gbAddSessao.Name = "gbAddSessao";
            this.gbAddSessao.Size = new System.Drawing.Size(480, 402);
            this.gbAddSessao.TabIndex = 0;
            this.gbAddSessao.TabStop = false;
            this.gbAddSessao.Text = "Adicionar Sessão";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(384, 311);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(33, 20);
            this.nudMinutos.TabIndex = 4;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(345, 311);
            this.nudHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(33, 20);
            this.nudHoras.TabIndex = 2;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(16, 311);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(310, 20);
            this.dtpDataInicio.TabIndex = 3;
            // 
            // btnAddSessao
            // 
            this.btnAddSessao.Location = new System.Drawing.Point(16, 337);
            this.btnAddSessao.Name = "btnAddSessao";
            this.btnAddSessao.Size = new System.Drawing.Size(451, 54);
            this.btnAddSessao.TabIndex = 2;
            this.btnAddSessao.Text = "Adicionar";
            this.btnAddSessao.UseVisualStyleBackColor = true;
            this.btnAddSessao.Click += new System.EventHandler(this.btnAddSessao_Click);
            // 
            // gbFilmes
            // 
            this.gbFilmes.Controls.Add(this.lbFilmes);
            this.gbFilmes.Location = new System.Drawing.Point(243, 20);
            this.gbFilmes.Name = "gbFilmes";
            this.gbFilmes.Size = new System.Drawing.Size(224, 285);
            this.gbFilmes.TabIndex = 1;
            this.gbFilmes.TabStop = false;
            this.gbFilmes.Text = "Filmes";
            // 
            // lbFilmes
            // 
            this.lbFilmes.FormattingEnabled = true;
            this.lbFilmes.Location = new System.Drawing.Point(6, 20);
            this.lbFilmes.Name = "lbFilmes";
            this.lbFilmes.Size = new System.Drawing.Size(205, 251);
            this.lbFilmes.TabIndex = 1;
            // 
            // gbSalas
            // 
            this.gbSalas.Controls.Add(this.lbSalas);
            this.gbSalas.Location = new System.Drawing.Point(7, 20);
            this.gbSalas.Name = "gbSalas";
            this.gbSalas.Size = new System.Drawing.Size(230, 285);
            this.gbSalas.TabIndex = 0;
            this.gbSalas.TabStop = false;
            this.gbSalas.Text = "Salas Disponíveis";
            // 
            // lbSalas
            // 
            this.lbSalas.FormattingEnabled = true;
            this.lbSalas.Location = new System.Drawing.Point(9, 20);
            this.lbSalas.Name = "lbSalas";
            this.lbSalas.Size = new System.Drawing.Size(205, 251);
            this.lbSalas.TabIndex = 0;
            // 
            // gbSessoes
            // 
            this.gbSessoes.Controls.Add(this.btnRemoveSessao);
            this.gbSessoes.Controls.Add(this.lbSessoes);
            this.gbSessoes.Location = new System.Drawing.Point(510, 13);
            this.gbSessoes.Name = "gbSessoes";
            this.gbSessoes.Size = new System.Drawing.Size(254, 364);
            this.gbSessoes.TabIndex = 1;
            this.gbSessoes.TabStop = false;
            this.gbSessoes.Text = "Sessões";
            // 
            // btnRemoveSessao
            // 
            this.btnRemoveSessao.Location = new System.Drawing.Point(7, 20);
            this.btnRemoveSessao.Name = "btnRemoveSessao";
            this.btnRemoveSessao.Size = new System.Drawing.Size(241, 27);
            this.btnRemoveSessao.TabIndex = 1;
            this.btnRemoveSessao.Text = "Remover";
            this.btnRemoveSessao.UseVisualStyleBackColor = true;
            this.btnRemoveSessao.Click += new System.EventHandler(this.btnRemoveSessao_Click);
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(7, 53);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(242, 303);
            this.lbSessoes.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(510, 384);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(254, 31);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GereSessoesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 424);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbSessoes);
            this.Controls.Add(this.gbAddSessao);
            this.Name = "GereSessoesFrm";
            this.Text = "GereSessoesFrm";
            this.Load += new System.EventHandler(this.GereSessoesFrm_Load);
            this.gbAddSessao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbFilmes.ResumeLayout(false);
            this.gbSalas.ResumeLayout(false);
            this.gbSessoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddSessao;
        private System.Windows.Forms.Button btnAddSessao;
        private System.Windows.Forms.GroupBox gbFilmes;
        private System.Windows.Forms.ListBox lbFilmes;
        private System.Windows.Forms.GroupBox gbSalas;
        private System.Windows.Forms.ListBox lbSalas;
        private System.Windows.Forms.GroupBox gbSessoes;
        private System.Windows.Forms.Button btnRemoveSessao;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnRefresh;
    }
}