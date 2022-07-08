namespace GereCinema
{
    partial class frmCinema
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
            this.btnFilmes = new System.Windows.Forms.Button();
            this.btnFuncionariosVendas = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSessoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmes
            // 
            this.btnFilmes.Location = new System.Drawing.Point(182, 48);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(116, 45);
            this.btnFilmes.TabIndex = 0;
            this.btnFilmes.Text = "Filmes";
            this.btnFilmes.UseVisualStyleBackColor = true;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // btnFuncionariosVendas
            // 
            this.btnFuncionariosVendas.Location = new System.Drawing.Point(44, 149);
            this.btnFuncionariosVendas.Name = "btnFuncionariosVendas";
            this.btnFuncionariosVendas.Size = new System.Drawing.Size(116, 45);
            this.btnFuncionariosVendas.TabIndex = 1;
            this.btnFuncionariosVendas.Text = "Funcionários/Vendas";
            this.btnFuncionariosVendas.UseVisualStyleBackColor = true;
            this.btnFuncionariosVendas.Click += new System.EventHandler(this.btnFuncionariosVendas_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(44, 99);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(116, 45);
            this.btnItems.TabIndex = 3;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.Location = new System.Drawing.Point(44, 48);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(116, 45);
            this.btnSalas.TabIndex = 2;
            this.btnSalas.Text = "Salas";
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(182, 149);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(116, 45);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSessoes
            // 
            this.btnSessoes.Location = new System.Drawing.Point(182, 100);
            this.btnSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.Size = new System.Drawing.Size(116, 45);
            this.btnSessoes.TabIndex = 5;
            this.btnSessoes.Text = "Sessões";
            this.btnSessoes.UseVisualStyleBackColor = true;
            this.btnSessoes.Click += new System.EventHandler(this.btnSessoes_Click);
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 288);
            this.Controls.Add(this.btnSessoes);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnSalas);
            this.Controls.Add(this.btnFuncionariosVendas);
            this.Controls.Add(this.btnFilmes);
            this.Name = "frmCinema";
            this.Text = "GereCinema";
            this.Load += new System.EventHandler(this.frmCinema_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnFuncionariosVendas;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSessoes;
    }
}

