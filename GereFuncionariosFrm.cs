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
    public partial class GereFuncionariosFrm : Form
    {
        private CinemaDBContainer db;

        public GereFuncionariosFrm()
        {
            InitializeComponent();
        }

        private void GereFuncionariosFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
            lbFuncionarios.DataSource = null;
            if (db.Funcionarios.Count() > 0)
            {
                lbFuncionarios.DataSource = null;
                lbFuncionarios.DataSource = db.Funcionarios.ToList();
                Funcionario funcionario = lbFuncionarios.SelectedItem as Funcionario;
                if(funcionario.Vendas.Count() > 0)
                {
                    lbVendas.DataSource = null;
                    lbVendas.DataSource = funcionario.Vendas.ToList();
                }

            }
            
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtSalario.Text != "")
            {
                db.Funcionarios.Add(new Funcionario(txtNome.Text, Double.Parse(txtSalario.Text)));
                db.SaveChanges();
                lbFuncionarios.DataSource = db.Funcionarios.ToList();
                lbFuncionarios.SelectedIndex = db.Funcionarios.Count() - 1;
                txtNome.Text = "";
                txtSalario.Text = "";
            }
            else
            {
                MessageBox.Show("Tem que introduzir todos os dados!");
            }
            
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if(lbFuncionarios.SelectedIndex != -1)
            {
                Funcionario funcionario = lbFuncionarios.SelectedItem as Funcionario;
                funcionario.Nome = txtEditarNome.Text;
                funcionario.Salario = Double.Parse(txtEditarSalario.Text);
                db.SaveChanges();
                lbFuncionarios.DataSource = null;
                lbFuncionarios.DataSource = db.Funcionarios.ToList();
                lbFuncionarios.SelectedItem = funcionario;
            }
            
        }

        private void lbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbFuncionarios.SelectedIndex != -1)
            {
                Funcionario funcionario = lbFuncionarios.SelectedItem as Funcionario;
                txtEditarNome.Text = funcionario.Nome;
                txtEditarSalario.Text = funcionario.Salario.ToString();
                lbVendas.DataSource = null;
                if(funcionario.Vendas != null)
                {
                    lbVendas.DataSource = funcionario.Vendas.ToList();
                }
                
            }
        }

        private void lbVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbVendas.SelectedIndex != -1)
            {
                Venda venda = lbVendas.SelectedItem as Venda;
                lbVendaItems.DataSource = null;
                lbVendaItems.DataSource = venda.Items.ToList();
                lbVendaBilhetes.DataSource = null;
                lbVendaBilhetes.DataSource = venda.Bilhetes.ToList();
            }
        }
    }
}
