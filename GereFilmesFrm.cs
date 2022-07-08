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
    public partial class GereFilmesFrm : Form
    {
        private CinemaDBContainer db;
        public GereFilmesFrm()
        {
            InitializeComponent();
        }

        private void GereFilmesFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();
            lbFilmes.DataSource = null;
            if(db.Filmes.Count() > 0)
            {
                lbFilmes.DataSource = db.Filmes.ToList();
            }
        }

        private void btnAlterarFilme_Click(object sender, EventArgs e)
        {
            if(lbFilmes.SelectedIndex != -1)
            {
                Filme filmeAlterado = lbFilmes.SelectedItem as Filme;
                filmeAlterado.Titulo = txtEditarTitulo.Text;
                filmeAlterado.Tipo = cboEditarTipo.SelectedItem.ToString();
                filmeAlterado.LimIdade = int.Parse(cboEditarClassEtaria.SelectedItem.ToString());
                filmeAlterado.Duracao = int.Parse(txtEditarDuracao.Text);
                filmeAlterado.Preco = double.Parse(txtEditarPreco.Text);
                db.SaveChanges();

                lbFilmes.DataSource = null;
                lbFilmes.DataSource = db.Filmes.ToList();
                lbFilmes.SelectedItem = filmeAlterado;
            }
 
        }

        private void btnAddFilme_Click(object sender, EventArgs e)
        {
            db.Filmes.Add(new Filme(txtTitulo.Text, cboTipo.SelectedItem.ToString(), int.Parse(cboClassEtaria.SelectedItem.ToString()), int.Parse(txtDuracao.Text), double.Parse(txtPreco.Text)));
            db.SaveChanges();
            lbFilmes.DataSource = null;
            lbFilmes.DataSource = db.Filmes.ToList();
            lbFilmes.SelectedIndex = db.Filmes.Count() - 1;
            txtTitulo.Text = "";
            cboTipo.SelectedIndex = -1;
            cboClassEtaria.SelectedIndex = -1;
            txtDuracao.Text = "";
            txtPreco.Text = "";
        }

        private void lbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbFilmes.SelectedIndex != -1)
            {
                Filme filme = lbFilmes.SelectedItem as Filme;
                txtEditarTitulo.Text = filme.Titulo;
                cboEditarTipo.SelectedItem = filme.Tipo;
                cboEditarClassEtaria.SelectedItem = filme.LimIdade.ToString();
                txtEditarDuracao.Text = filme.Duracao.ToString();
                txtPreco.Text = filme.Preco.ToString();
            }
            
        }

        private void btnRemoveFilme_Click(object sender, EventArgs e)
        {
            Filme filmeRemovido = lbFilmes.SelectedItem as Filme;

            foreach(Sessao sessao in filmeRemovido.Sessoes.ToList())
            {
                foreach(Lugar lugar in sessao.Lugares.ToList())
                {
                    db.Lugares.Remove(lugar);
                }
                db.Sessoes.Remove(sessao);
                db.SaveChanges();
            }

            db.Filmes.Remove(filmeRemovido);
            db.SaveChanges();
            lbFilmes.DataSource = null;
            lbFilmes.DataSource = db.Filmes.ToList();
        }
    }
}
