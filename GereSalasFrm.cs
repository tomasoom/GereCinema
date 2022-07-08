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
    public partial class GereSalasFrm : Form
    {
        private CinemaDBContainer db;
        public GereSalasFrm()
        {
            InitializeComponent();
        }

        private void GereSalasFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
            lbSalas.DataSource = null;
            if(db.Salas.Count() > 0)
            {
                lbSalas.DataSource = db.Salas.ToList();
            }
        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            db.Salas.Add(new Sala(db.Salas.Count() + 1, int.Parse(txtComprimento.Text), int.Parse(txtLargura.Text)));
            db.SaveChanges();
            lbSalas.DataSource = null;
            lbSalas.DataSource = db.Salas.ToList();
            lbSalas.SelectedIndex = db.Salas.Count() - 1;
            txtComprimento.Text = "";
            txtLargura.Text = "";
        }

        private void btnRemoverSala_Click(object sender, EventArgs e)
        {
            if(lbSalas.SelectedIndex != -1)
            {
                
                Sala salaRemovida = lbSalas.SelectedItem as Sala;

                if(salaRemovida.Sessoes != null)
                {
                    foreach (Sessao sessao in salaRemovida.Sessoes.ToList())
                    {
                        db.Sessoes.Remove(sessao);
                        db.SaveChanges();
                    }
                }
                


                db.Salas.Remove(salaRemovida);
                db.SaveChanges();
                lbSalas.DataSource = null;
                lbSalas.DataSource = db.Salas.ToList();
            }
            
        }
    }
}
