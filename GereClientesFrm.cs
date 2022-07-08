using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereCinema
{
    public partial class GereClientesFrm : Form
    {
        private bool pedido = false;
        private Lugar lugarPendente;

        private CinemaDBContainer db;
        public List<Item> itemsNovoPedido = new List<Item>();
        public List<Bilhete> bilhetesNovoPedido = new List<Bilhete>();
        public GereClientesFrm()
        {
            InitializeComponent();
        }

        private void GereClientesFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
            if (db.Clientes.Count() > 0)
            {
                lbClientes.DataSource = null;
                lbClientes.DataSource = db.Clientes.ToList();
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                if(cliente.Vendas.Count > 0)
                {
                    lbVendas.DataSource = null;
                    lbVendas.DataSource = cliente.Vendas.ToList();
                    Venda venda = lbVendas.SelectedItem as Venda;
                    lbItemsVenda.DataSource = null;
                    lbItemsVenda.DataSource = venda.Items.ToList();
                    lbBilhetesVenda.DataSource = null;
                    lbBilhetesVenda.DataSource = venda.Bilhetes.ToList();
                }
                
           
            }

            if (db.Funcionarios.Count() > 0)
            {
                cboFuncionarios.DataSource = null;
                cboFuncionarios.DataSource = db.Funcionarios.ToList();
            }

            if (db.Items.Count() > 0)
            {
                lbItems.DataSource = null;
                lbItems.DataSource = db.Items.ToList();
            }

            if (db.Sessoes.Count() > 0)
            {
                lbSessoes.DataSource = null;
                lbSessoes.DataSource = db.Sessoes.ToList();
            }
            

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            db.Clientes.Add(new Cliente(txtNome.Text, int.Parse(txtIdade.Text), txtNIF.Text));
            db.SaveChanges();
            lbClientes.DataSource = null;
            lbClientes.DataSource = db.Clientes.ToList();
            txtNome.Text = "";
            txtIdade.Text = "";
            txtNIF.Text = "";
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (lbClientes.Items.Count > 0)
            {
                Cliente clienteAlterado = lbClientes.SelectedItem as Cliente;
                clienteAlterado.Nome = txtEditarNome.Text;
                clienteAlterado.Idade = int.Parse(txtEditarIdade.Text);
                clienteAlterado.NIF = txtEditarIdade.Text;
                db.SaveChanges();
                lbClientes.DataSource = null;
                lbClientes.DataSource = db.Clientes.ToList();
            }
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex != -1)
            {
                Cliente clienteSelecionado = lbClientes.SelectedItem as Cliente;
                txtEditarNome.Text = clienteSelecionado.Nome;
                txtEditarIdade.Text = clienteSelecionado.Idade.ToString();
                txtEditarNIF.Text = clienteSelecionado.NIF;

                if (clienteSelecionado.Vendas != null)
                {
                    lbVendas.DataSource = null;
                    lbVendas.DataSource = clienteSelecionado.Vendas.ToList();
                }
                lbItemsVenda.DataSource = null;
                lbBilhetesVenda.DataSource = null;

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex != -1)
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                if (lbItems.SelectedIndex != -1)
                {
                    for (int i = 0; i < nudNItems.Value; i++)
                    {
                        itemsNovoPedido.Add(lbItems.SelectedItem as Item);
                    }
                }
                lbItemsNovoPedido.DataSource = null;
                lbItemsNovoPedido.DataSource = itemsNovoPedido;
                nudNItems.Value = 0;
            }
        }

        private void btnAddSessao_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex != -1)
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                if (lbSessoes.SelectedIndex != -1 && dgvLugares.CurrentCell.Style.BackColor == Color.Green)
                {
                    Sessao sessao = lbSessoes.SelectedItem as Sessao;
                    Lugar lugarVendido = sessao.Lugares.Single(lugar => lugar.X == dgvLugares.CurrentCell.RowIndex + 1 && lugar.Y == dgvLugares.CurrentCell.ColumnIndex + 1);
                    lugarPendente = lugarVendido;
                    Bilhete bilhete = new Bilhete(sessao, lugarVendido);
                    lugarVendido.Ocupado = true;

                    foreach (Lugar lugar in sessao.Lugares.ToList())
                    {
                        if (lugar.Ocupado)
                        {
                            dgvLugares.Rows[lugar.X - 1].Cells[lugar.Y - 1].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvLugares.Rows[lugar.X - 1].Cells[lugar.Y - 1].Style.BackColor = Color.Green;
                        }

                    }

                    db.SaveChanges();
                    bilhetesNovoPedido.Add(bilhete);

                    dgvLugares.ReadOnly = true;
                    dgvLugares.Enabled = false;

                    lbBilhetesNovoPedido.DataSource = null;
                    lbBilhetesNovoPedido.DataSource = bilhetesNovoPedido;

                }
            }
        }


        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            if(lbClientes.SelectedIndex != -1 && cboFuncionarios.SelectedIndex != -1 && (lbItemsNovoPedido.SelectedIndex != -1 || lbBilhetesNovoPedido.SelectedIndex != -1))
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                Venda venda = new Venda();
                venda.Items = itemsNovoPedido;
                venda.Bilhetes = bilhetesNovoPedido;
                venda.Funcionario = cboFuncionarios.SelectedItem as Funcionario;
                

                cliente.Vendas.Add(venda);
                db.SaveChanges();
                lbItemsNovoPedido.DataSource = null;
                lbBilhetesNovoPedido.DataSource = null;
                itemsNovoPedido.Clear();
                bilhetesNovoPedido.Clear();

                dgvLugares.ReadOnly = false;
                dgvLugares.Enabled = true;
            }
        }

        private void lbVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(lbClientes.SelectedIndex != -1)
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                if(lbVendas.SelectedIndex != -1)
                {
                    Venda venda = lbVendas.SelectedItem as Venda;
                    if(venda.Items.Count() > 0 || venda.Bilhetes.Count() > 0)
                    {
                        lbItemsVenda.DataSource = null;
                        lbItemsVenda.DataSource = venda.Items.ToList();
                        lbBilhetesVenda.DataSource = null;
                        lbBilhetesVenda.DataSource = venda.Bilhetes.ToList();
                    }
                }
            }
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void lbSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbSessoes.SelectedIndex != -1)
            {
                Sessao sessao= lbSessoes.SelectedItem as Sessao;

                dgvLugares.Rows.Clear();
                dgvLugares.ColumnCount = sessao.Sala.Comprimento;
                for(int i = 0; i < sessao.Sala.Comprimento; i++)
                {
                    dgvLugares.Columns[i].Name = (i + 1).ToString();
                }

                
                dgvLugares.Rows.Add(sessao.Sala.Largura-1);

                dgvLugares.RowHeadersVisible = true;
                for (int j= 0; j < dgvLugares.RowCount; j++)
                {
                    dgvLugares.Rows[j].HeaderCell.Value = (j+1).ToString();
                }


                foreach(Lugar lugar in sessao.Lugares.ToList())
                {
                    if (lugar.Ocupado)
                    {
                        dgvLugares.Rows[lugar.X-1].Cells[lugar.Y-1].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dgvLugares.Rows[lugar.X-1].Cells[lugar.Y-1].Style.BackColor = Color.Green;
                    }
                    
                }
                
            }
        }

        private void btnRemoverVenda_Click(object sender, EventArgs e)
        {
            if(lbClientes.SelectedIndex != -1)
            {
                Cliente cliente = lbClientes.SelectedItem as Cliente;
                if(lbVendas.SelectedIndex != 1)
                {
                    Venda vendaRemovida = lbVendas.SelectedItem as Venda;

                }
            }
        }
    }
}
