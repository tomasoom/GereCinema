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
    public partial class GereItemsFrm : Form
    {
        private CinemaDBContainer db;
        public GereItemsFrm()
        {
            InitializeComponent();
        }

        private void GereItemsFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
            lbMenu.DataSource = null;
            if(db.Items.Count() > 0)
            {
                lbMenu.DataSource = db.Items.ToList();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            db.Items.Add(new Item(txtNome.Text, double.Parse(txtPreco.Text)));
            db.SaveChanges();
            lbMenu.DataSource = null;
            lbMenu.DataSource = db.Items.ToList();
            lbMenu.SelectedIndex = db.Items.Count() - 1;
            txtNome.Text = "";
            txtPreco.Text = "";
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if(lbMenu.SelectedIndex != -1)
            {
                Item itemRemovido = lbMenu.SelectedItem as Item;
                db.Items.Remove(itemRemovido);
                db.SaveChanges();
                lbMenu.DataSource = null;
                lbMenu.DataSource = db.Items.ToList();
            }
        }
    }
}
