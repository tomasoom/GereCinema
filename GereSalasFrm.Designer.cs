namespace GereCinema
{
    partial class GereSalasFrm
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
            this.gbSalas = new System.Windows.Forms.GroupBox();
            this.btnRemoverSala = new System.Windows.Forms.Button();
            this.lbSalas = new System.Windows.Forms.ListBox();
            this.gbAddSala = new System.Windows.Forms.GroupBox();
            this.btnAddSala = new System.Windows.Forms.Button();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSalas.SuspendLayout();
            this.gbAddSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSalas
            // 
            this.gbSalas.Controls.Add(this.btnRemoverSala);
            this.gbSalas.Controls.Add(this.lbSalas);
            this.gbSalas.Controls.Add(this.gbAddSala);
            this.gbSalas.Location = new System.Drawing.Point(10, 11);
            this.gbSalas.Name = "gbSalas";
            this.gbSalas.Size = new System.Drawing.Size(219, 441);
            this.gbSalas.TabIndex = 4;
            this.gbSalas.TabStop = false;
            this.gbSalas.Text = "Lista de Salas";
            // 
            // btnRemoverSala
            // 
            this.btnRemoverSala.Location = new System.Drawing.Point(6, 20);
            this.btnRemoverSala.Name = "btnRemoverSala";
            this.btnRemoverSala.Size = new System.Drawing.Size(200, 23);
            this.btnRemoverSala.TabIndex = 2;
            this.btnRemoverSala.Text = "Remover";
            this.btnRemoverSala.UseVisualStyleBackColor = true;
            this.btnRemoverSala.Click += new System.EventHandler(this.btnRemoverSala_Click);
            // 
            // lbSalas
            // 
            this.lbSalas.FormattingEnabled = true;
            this.lbSalas.Location = new System.Drawing.Point(6, 45);
            this.lbSalas.Name = "lbSalas";
            this.lbSalas.Size = new System.Drawing.Size(207, 264);
            this.lbSalas.TabIndex = 0;
            // 
            // gbAddSala
            // 
            this.gbAddSala.Controls.Add(this.txtLargura);
            this.gbAddSala.Controls.Add(this.label1);
            this.gbAddSala.Controls.Add(this.btnAddSala);
            this.gbAddSala.Controls.Add(this.txtComprimento);
            this.gbAddSala.Controls.Add(this.lblComprimento);
            this.gbAddSala.Location = new System.Drawing.Point(6, 315);
            this.gbAddSala.Name = "gbAddSala";
            this.gbAddSala.Size = new System.Drawing.Size(207, 120);
            this.gbAddSala.TabIndex = 1;
            this.gbAddSala.TabStop = false;
            this.gbAddSala.Text = "Adicionar Sala";
            // 
            // btnAddSala
            // 
            this.btnAddSala.Location = new System.Drawing.Point(10, 94);
            this.btnAddSala.Name = "btnAddSala";
            this.btnAddSala.Size = new System.Drawing.Size(184, 25);
            this.btnAddSala.TabIndex = 2;
            this.btnAddSala.Text = "Adicionar";
            this.btnAddSala.UseVisualStyleBackColor = true;
            this.btnAddSala.Click += new System.EventHandler(this.btnAddSala_Click);
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(82, 31);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(118, 20);
            this.txtComprimento.TabIndex = 1;
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Location = new System.Drawing.Point(7, 34);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(71, 13);
            this.lblComprimento.TabIndex = 0;
            this.lblComprimento.Text = "Comprimento:";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(82, 60);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(118, 20);
            this.txtLargura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Largura:";
            // 
            // GereSalasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 457);
            this.Controls.Add(this.gbSalas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GereSalasFrm";
            this.Text = "GereSalasFrm";
            this.Load += new System.EventHandler(this.GereSalasFrm_Load);
            this.gbSalas.ResumeLayout(false);
            this.gbAddSala.ResumeLayout(false);
            this.gbAddSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSalas;
        private System.Windows.Forms.Button btnRemoverSala;
        private System.Windows.Forms.ListBox lbSalas;
        private System.Windows.Forms.GroupBox gbAddSala;
        private System.Windows.Forms.Button btnAddSala;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.Label label1;
    }
}