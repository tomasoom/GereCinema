namespace GereCinema
{
    partial class GereClientesFrm
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
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.gbPesquisaCliente = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaNIF = new System.Windows.Forms.TextBox();
            this.lblPesquisaNIF = new System.Windows.Forms.Label();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.gbAddCliente = new System.Windows.Forms.GroupBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lbIdade = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.gbEditarCliente = new System.Windows.Forms.GroupBox();
            this.txtEditarNIF = new System.Windows.Forms.TextBox();
            this.lbEditarNIF = new System.Windows.Forms.Label();
            this.txtEditarIdade = new System.Windows.Forms.TextBox();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.lbEditarIdade = new System.Windows.Forms.Label();
            this.txtEditarNome = new System.Windows.Forms.TextBox();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.btnRemoverVenda = new System.Windows.Forms.Button();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.lbBilhetesVenda = new System.Windows.Forms.ListBox();
            this.lbItemsVenda = new System.Windows.Forms.ListBox();
            this.lbVendas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.cboFuncionarios = new System.Windows.Forms.ComboBox();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.gbSessoes = new System.Windows.Forms.GroupBox();
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnAddBilhete = new System.Windows.Forms.Button();
            this.gbMenuItems = new System.Windows.Forms.GroupBox();
            this.nudNItems = new System.Windows.Forms.NumericUpDown();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbBilhetesNovoPedido = new System.Windows.Forms.ListBox();
            this.lbItemsNovoPedido = new System.Windows.Forms.ListBox();
            this.gbClientes.SuspendLayout();
            this.gbPesquisaCliente.SuspendLayout();
            this.gbAddCliente.SuspendLayout();
            this.gbEditarCliente.SuspendLayout();
            this.gbVendas.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSessoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.gbMenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.gbPesquisaCliente);
            this.gbClientes.Controls.Add(this.btnRemoverCliente);
            this.gbClientes.Controls.Add(this.gbAddCliente);
            this.gbClientes.Controls.Add(this.lbClientes);
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(223, 662);
            this.gbClientes.TabIndex = 4;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Lista de Clientes";
            // 
            // gbPesquisaCliente
            // 
            this.gbPesquisaCliente.Controls.Add(this.btnPesquisa);
            this.gbPesquisaCliente.Controls.Add(this.txtPesquisaNIF);
            this.gbPesquisaCliente.Controls.Add(this.lblPesquisaNIF);
            this.gbPesquisaCliente.Location = new System.Drawing.Point(6, 386);
            this.gbPesquisaCliente.Name = "gbPesquisaCliente";
            this.gbPesquisaCliente.Size = new System.Drawing.Size(200, 94);
            this.gbPesquisaCliente.TabIndex = 3;
            this.gbPesquisaCliente.TabStop = false;
            this.gbPesquisaCliente.Text = "Pesquisar Cliente";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(13, 56);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(166, 29);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNIF
            // 
            this.txtPesquisaNIF.Location = new System.Drawing.Point(44, 30);
            this.txtPesquisaNIF.Name = "txtPesquisaNIF";
            this.txtPesquisaNIF.Size = new System.Drawing.Size(132, 20);
            this.txtPesquisaNIF.TabIndex = 1;
            // 
            // lblPesquisaNIF
            // 
            this.lblPesquisaNIF.AutoSize = true;
            this.lblPesquisaNIF.Location = new System.Drawing.Point(10, 30);
            this.lblPesquisaNIF.Name = "lblPesquisaNIF";
            this.lblPesquisaNIF.Size = new System.Drawing.Size(27, 13);
            this.lblPesquisaNIF.TabIndex = 0;
            this.lblPesquisaNIF.Text = "NIF:";
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Location = new System.Drawing.Point(6, 20);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(200, 23);
            this.btnRemoverCliente.TabIndex = 2;
            this.btnRemoverCliente.Text = "Remover";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.btnRemoverCliente_Click);
            // 
            // gbAddCliente
            // 
            this.gbAddCliente.Controls.Add(this.txtIdade);
            this.gbAddCliente.Controls.Add(this.lbIdade);
            this.gbAddCliente.Controls.Add(this.txtNIF);
            this.gbAddCliente.Controls.Add(this.lblNIF);
            this.gbAddCliente.Controls.Add(this.btnAddCliente);
            this.gbAddCliente.Controls.Add(this.txtNome);
            this.gbAddCliente.Controls.Add(this.lblNome);
            this.gbAddCliente.Location = new System.Drawing.Point(6, 488);
            this.gbAddCliente.Name = "gbAddCliente";
            this.gbAddCliente.Size = new System.Drawing.Size(200, 156);
            this.gbAddCliente.TabIndex = 1;
            this.gbAddCliente.TabStop = false;
            this.gbAddCliente.Text = "Adicionar Cliente";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(58, 55);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(118, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(18, 58);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(37, 13);
            this.lbIdade.TabIndex = 5;
            this.lbIdade.Text = "Idade:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(58, 82);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(118, 20);
            this.txtNIF.TabIndex = 4;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(25, 85);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(27, 13);
            this.lblNIF.TabIndex = 3;
            this.lblNIF.Text = "NIF:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(10, 108);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(166, 41);
            this.btnAddCliente.TabIndex = 2;
            this.btnAddCliente.Text = "Adicionar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
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
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.Location = new System.Drawing.Point(6, 45);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(200, 329);
            this.lbClientes.TabIndex = 0;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // gbEditarCliente
            // 
            this.gbEditarCliente.Controls.Add(this.txtEditarNIF);
            this.gbEditarCliente.Controls.Add(this.lbEditarNIF);
            this.gbEditarCliente.Controls.Add(this.txtEditarIdade);
            this.gbEditarCliente.Controls.Add(this.lblEditarNome);
            this.gbEditarCliente.Controls.Add(this.lbEditarIdade);
            this.gbEditarCliente.Controls.Add(this.txtEditarNome);
            this.gbEditarCliente.Controls.Add(this.btnAlterarCliente);
            this.gbEditarCliente.Location = new System.Drawing.Point(241, 12);
            this.gbEditarCliente.Name = "gbEditarCliente";
            this.gbEditarCliente.Size = new System.Drawing.Size(820, 91);
            this.gbEditarCliente.TabIndex = 5;
            this.gbEditarCliente.TabStop = false;
            this.gbEditarCliente.Text = "Editar Cliente";
            // 
            // txtEditarNIF
            // 
            this.txtEditarNIF.Location = new System.Drawing.Point(95, 70);
            this.txtEditarNIF.Name = "txtEditarNIF";
            this.txtEditarNIF.Size = new System.Drawing.Size(180, 20);
            this.txtEditarNIF.TabIndex = 11;
            // 
            // lbEditarNIF
            // 
            this.lbEditarNIF.AutoSize = true;
            this.lbEditarNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarNIF.Location = new System.Drawing.Point(50, 68);
            this.lbEditarNIF.Name = "lbEditarNIF";
            this.lbEditarNIF.Size = new System.Drawing.Size(39, 20);
            this.lbEditarNIF.TabIndex = 10;
            this.lbEditarNIF.Text = "NIF:";
            // 
            // txtEditarIdade
            // 
            this.txtEditarIdade.Location = new System.Drawing.Point(95, 46);
            this.txtEditarIdade.Name = "txtEditarIdade";
            this.txtEditarIdade.Size = new System.Drawing.Size(180, 20);
            this.txtEditarIdade.TabIndex = 9;
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNome.Location = new System.Drawing.Point(38, 20);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(55, 20);
            this.lblEditarNome.TabIndex = 5;
            this.lblEditarNome.Text = "Nome:";
            // 
            // lbEditarIdade
            // 
            this.lbEditarIdade.AutoSize = true;
            this.lbEditarIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditarIdade.Location = new System.Drawing.Point(38, 44);
            this.lbEditarIdade.Name = "lbEditarIdade";
            this.lbEditarIdade.Size = new System.Drawing.Size(54, 20);
            this.lbEditarIdade.TabIndex = 8;
            this.lbEditarIdade.Text = "Idade:";
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.Location = new System.Drawing.Point(95, 22);
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(180, 20);
            this.txtEditarNome.TabIndex = 6;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(298, 22);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(511, 47);
            this.btnAlterarCliente.TabIndex = 7;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // gbVendas
            // 
            this.gbVendas.Controls.Add(this.btnRemoverVenda);
            this.gbVendas.Controls.Add(this.gbPedido);
            this.gbVendas.Controls.Add(this.lbVendas);
            this.gbVendas.Location = new System.Drawing.Point(242, 110);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(415, 564);
            this.gbVendas.TabIndex = 6;
            this.gbVendas.TabStop = false;
            this.gbVendas.Text = "Lista de Vendas";
            // 
            // btnRemoverVenda
            // 
            this.btnRemoverVenda.Location = new System.Drawing.Point(6, 25);
            this.btnRemoverVenda.Name = "btnRemoverVenda";
            this.btnRemoverVenda.Size = new System.Drawing.Size(403, 23);
            this.btnRemoverVenda.TabIndex = 3;
            this.btnRemoverVenda.Text = "Remover";
            this.btnRemoverVenda.UseVisualStyleBackColor = true;
            this.btnRemoverVenda.Click += new System.EventHandler(this.btnRemoverVenda_Click);
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.lbBilhetesVenda);
            this.gbPedido.Controls.Add(this.lbItemsVenda);
            this.gbPedido.Location = new System.Drawing.Point(6, 269);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(403, 289);
            this.gbPedido.TabIndex = 2;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // lbBilhetesVenda
            // 
            this.lbBilhetesVenda.FormattingEnabled = true;
            this.lbBilhetesVenda.Location = new System.Drawing.Point(205, 19);
            this.lbBilhetesVenda.Name = "lbBilhetesVenda";
            this.lbBilhetesVenda.Size = new System.Drawing.Size(192, 264);
            this.lbBilhetesVenda.TabIndex = 5;
            // 
            // lbItemsVenda
            // 
            this.lbItemsVenda.FormattingEnabled = true;
            this.lbItemsVenda.Location = new System.Drawing.Point(6, 19);
            this.lbItemsVenda.Name = "lbItemsVenda";
            this.lbItemsVenda.Size = new System.Drawing.Size(193, 264);
            this.lbItemsVenda.TabIndex = 4;
            // 
            // lbVendas
            // 
            this.lbVendas.FormattingEnabled = true;
            this.lbVendas.Location = new System.Drawing.Point(6, 51);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(403, 212);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.SelectedIndexChanged += new System.EventHandler(this.lbVendas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFuncionarios);
            this.groupBox1.Controls.Add(this.cboFuncionarios);
            this.groupBox1.Controls.Add(this.btnAddPedido);
            this.groupBox1.Controls.Add(this.gbSessoes);
            this.groupBox1.Controls.Add(this.gbMenuItems);
            this.groupBox1.Location = new System.Drawing.Point(663, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 571);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Pedido";
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Location = new System.Drawing.Point(9, 520);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(70, 13);
            this.lblFuncionarios.TabIndex = 4;
            this.lblFuncionarios.Text = "Funcionários:";
            // 
            // cboFuncionarios
            // 
            this.cboFuncionarios.FormattingEnabled = true;
            this.cboFuncionarios.Location = new System.Drawing.Point(85, 517);
            this.cboFuncionarios.Name = "cboFuncionarios";
            this.cboFuncionarios.Size = new System.Drawing.Size(670, 21);
            this.cboFuncionarios.TabIndex = 3;
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.Location = new System.Drawing.Point(6, 541);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(749, 23);
            this.btnAddPedido.TabIndex = 2;
            this.btnAddPedido.Text = "Adicionar Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = true;
            this.btnAddPedido.Click += new System.EventHandler(this.btnAddPedido_Click);
            // 
            // gbSessoes
            // 
            this.gbSessoes.Controls.Add(this.dgvLugares);
            this.gbSessoes.Controls.Add(this.lbSessoes);
            this.gbSessoes.Controls.Add(this.btnAddBilhete);
            this.gbSessoes.Location = new System.Drawing.Point(192, 19);
            this.gbSessoes.Name = "gbSessoes";
            this.gbSessoes.Size = new System.Drawing.Size(569, 498);
            this.gbSessoes.TabIndex = 1;
            this.gbSessoes.TabStop = false;
            this.gbSessoes.Text = "Sessões";
            // 
            // dgvLugares
            // 
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(191, 19);
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.Size = new System.Drawing.Size(372, 418);
            this.dgvLugares.TabIndex = 6;
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(6, 19);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(179, 420);
            this.lbSessoes.TabIndex = 4;
            this.lbSessoes.SelectedIndexChanged += new System.EventHandler(this.lbSessoes_SelectedIndexChanged);
            // 
            // btnAddBilhete
            // 
            this.btnAddBilhete.Location = new System.Drawing.Point(6, 444);
            this.btnAddBilhete.Name = "btnAddBilhete";
            this.btnAddBilhete.Size = new System.Drawing.Size(557, 48);
            this.btnAddBilhete.TabIndex = 3;
            this.btnAddBilhete.Text = "Adicionar";
            this.btnAddBilhete.UseVisualStyleBackColor = true;
            this.btnAddBilhete.Click += new System.EventHandler(this.btnAddSessao_Click);
            // 
            // gbMenuItems
            // 
            this.gbMenuItems.Controls.Add(this.nudNItems);
            this.gbMenuItems.Controls.Add(this.lbItems);
            this.gbMenuItems.Controls.Add(this.btnAddItem);
            this.gbMenuItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbMenuItems.Location = new System.Drawing.Point(6, 19);
            this.gbMenuItems.Name = "gbMenuItems";
            this.gbMenuItems.Size = new System.Drawing.Size(180, 498);
            this.gbMenuItems.TabIndex = 0;
            this.gbMenuItems.TabStop = false;
            this.gbMenuItems.Text = "Menu Items";
            // 
            // nudNItems
            // 
            this.nudNItems.Location = new System.Drawing.Point(5, 417);
            this.nudNItems.Name = "nudNItems";
            this.nudNItems.Size = new System.Drawing.Size(167, 20);
            this.nudNItems.TabIndex = 4;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(6, 19);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(168, 394);
            this.lbItems.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 441);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(169, 48);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbBilhetesNovoPedido
            // 
            this.lbBilhetesNovoPedido.FormattingEnabled = true;
            this.lbBilhetesNovoPedido.Location = new System.Drawing.Point(1449, 398);
            this.lbBilhetesNovoPedido.Name = "lbBilhetesNovoPedido";
            this.lbBilhetesNovoPedido.Size = new System.Drawing.Size(193, 264);
            this.lbBilhetesNovoPedido.TabIndex = 6;
            // 
            // lbItemsNovoPedido
            // 
            this.lbItemsNovoPedido.FormattingEnabled = true;
            this.lbItemsNovoPedido.Location = new System.Drawing.Point(1449, 122);
            this.lbItemsNovoPedido.Name = "lbItemsNovoPedido";
            this.lbItemsNovoPedido.Size = new System.Drawing.Size(193, 264);
            this.lbItemsNovoPedido.TabIndex = 5;
            // 
            // GereClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 682);
            this.Controls.Add(this.lbItemsNovoPedido);
            this.Controls.Add(this.lbBilhetesNovoPedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.gbEditarCliente);
            this.Controls.Add(this.gbClientes);
            this.Name = "GereClientesFrm";
            this.Text = "GereClientesFrm";
            this.Load += new System.EventHandler(this.GereClientesFrm_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbPesquisaCliente.ResumeLayout(false);
            this.gbPesquisaCliente.PerformLayout();
            this.gbAddCliente.ResumeLayout(false);
            this.gbAddCliente.PerformLayout();
            this.gbEditarCliente.ResumeLayout(false);
            this.gbEditarCliente.PerformLayout();
            this.gbVendas.ResumeLayout(false);
            this.gbPedido.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSessoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.gbMenuItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.GroupBox gbAddCliente;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaNIF;
        private System.Windows.Forms.Label lblPesquisaNIF;
        private System.Windows.Forms.GroupBox gbEditarCliente;
        private System.Windows.Forms.TextBox txtEditarIdade;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.Label lbEditarIdade;
        private System.Windows.Forms.TextBox txtEditarNome;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.ListBox lbVendas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverVenda;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.ListBox lbBilhetesVenda;
        private System.Windows.Forms.ListBox lbItemsVenda;
        private System.Windows.Forms.GroupBox gbSessoes;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.Button btnAddBilhete;
        private System.Windows.Forms.GroupBox gbMenuItems;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.NumericUpDown nudNItems;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.ComboBox cboFuncionarios;
        private System.Windows.Forms.ListBox lbItemsNovoPedido;
        private System.Windows.Forms.ListBox lbBilhetesNovoPedido;
        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.TextBox txtEditarNIF;
        private System.Windows.Forms.Label lbEditarNIF;
    }
}