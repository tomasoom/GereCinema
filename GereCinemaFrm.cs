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
    public partial class frmCinema : Form
    {
        private CinemaDBContainer db;
        public frmCinema()
        {
            InitializeComponent();
        }

        private void frmCinema_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereItemsFrm frmItems = new GereItemsFrm();
            frmItems.ShowDialog();
            
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereSalasFrm frmSalas = new GereSalasFrm();
            frmSalas.ShowDialog();
        }

        private void btnFuncionariosVendas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereFuncionariosFrm frmFuncionariosVendas = new GereFuncionariosFrm();
            frmFuncionariosVendas.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereClientesFrm frmGereClientes = new GereClientesFrm();
            frmGereClientes.ShowDialog();
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereFilmesFrm frmGereFilmes = new GereFilmesFrm();
            frmGereFilmes.ShowDialog();
        }

        private void btnSessoes_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GereSessoesFrm frmGereSessoes = new GereSessoesFrm();
            frmGereSessoes.ShowDialog();
        }
    }
}
