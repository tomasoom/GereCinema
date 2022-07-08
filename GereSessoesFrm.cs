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
    public partial class GereSessoesFrm : Form
    {
        private CinemaDBContainer db;
        public GereSessoesFrm()
        {
            InitializeComponent();
        }

        private void GereSessoesFrm_Load(object sender, EventArgs e)
        {
            db = new CinemaDBContainer();

            if (db.Salas.Count() > 0)
            {
                lbSalas.DataSource = null;
                lbSalas.DataSource = db.Salas.ToList();
            }


            if (db.Sessoes.Count() > 0)
            {
                lbSessoes.DataSource = null;
                lbSessoes.DataSource = db.Sessoes.ToList();
            }



            if (db.Filmes.Count() > 0)
            {
                lbFilmes.DataSource = null;
                lbFilmes.DataSource = db.Filmes.ToList();
            }

            lbSessoes.DataSource = null;
            lbSessoes.DataSource = db.Sessoes.ToList();

        }

        private void btnAddSessao_Click(object sender, EventArgs e)
        {
            if (lbSalas.SelectedIndex != -1 && lbFilmes.SelectedIndex != -1)
            {
                Sala sala = lbSalas.SelectedItem as Sala;
                Filme filme = lbFilmes.SelectedItem as Filme;

                bool disponivel = false;


                DateTime DataInicialSessaoAdicionada = dtpDataInicio.Value.Date;
                //DataInicialSessaoAdicionada.AddHours(int.Parse(nudHoras.Value.ToString()));
                //DataInicialSessaoAdicionada.AddMinutes(int.Parse(nudMinutos.Value.ToString()));
                TimeSpan ts1 = new TimeSpan(int.Parse(nudHoras.Value.ToString()), int.Parse(nudMinutos.Value.ToString()), 0);
                DataInicialSessaoAdicionada += ts1;

                int horasFinalSessao = filme.Duracao / 60;
                int minutosFinalSessao = filme.Duracao % 60;
                DateTime DataFinalSessaoAdicionada = DataInicialSessaoAdicionada;
                TimeSpan ts2 = new TimeSpan(horasFinalSessao, minutosFinalSessao, 0);
               //DataFinalSessaoAdicionada.AddHours(horasFinalSessao);
                //DataFinalSessaoAdicionada.AddMinutes(minutosFinalSessao);
                DataFinalSessaoAdicionada += ts2;

                if (db.Sessoes.Count() > 0)
                {
                    foreach (Sessao sessao in db.Sessoes.ToList())
                    {
                        DateTime DataInicialSessao = sessao.DataInicio;
                        DateTime DataFinalSessao = DataInicialSessao;
                        int horasSessao = sessao.Filme.Duracao / 60;
                        int minutosSessao = sessao.Filme.Duracao % 60;
                        //DataFinalSessao.AddHours(horasSessao);
                        //DataFinalSessao.AddMinutes(minutosSessao);
                        TimeSpan ts3 = new TimeSpan(horasSessao, minutosSessao, 0);
                        DataFinalSessao += ts3;

                        bool overlap = DataInicialSessaoAdicionada < DataFinalSessao && DataInicialSessao < DataFinalSessaoAdicionada;

                        if (sala == sessao.Sala && overlap)
                        {
                            disponivel = false;
                        }
                        else
                        {
                            disponivel = true;
                        }
                    }
                }

                else
                {
                    disponivel = true;
                }


                if (disponivel)
                {
                    Sessao sessaoAdicionada = new Sessao(DataInicialSessaoAdicionada, sala, filme);
                    db.Sessoes.Add(sessaoAdicionada);
                    for (int linha = 1; linha <= sessaoAdicionada.Sala.Largura; linha++)
                    {
                        for(int coluna = 1; coluna <= sessaoAdicionada.Sala.Comprimento; coluna++)
                        {
                            Lugar lugar = new Lugar(linha, coluna);
                            lugar.Sessao = sessaoAdicionada;
                            db.Lugares.Add(lugar);
                        }
                    }
                    

                    db.SaveChanges();
                    lbSessoes.DataSource = null;
                    lbSessoes.DataSource = db.Sessoes.ToList();
                }
                else
                {
                    MessageBox.Show("Não é possível adicionar sessão");
                }
            }

        }
    


        private void btnRemoveSessao_Click(object sender, EventArgs e)
        {
            if(lbSessoes.SelectedIndex != -1)
            {
                Sessao sessaoRemovida = lbSessoes.SelectedItem as Sessao;
                foreach(Lugar lugar in sessaoRemovida.Lugares.ToList())
                {
                    db.Lugares.Remove(lugar);
                }
                db.Sessoes.Remove(sessaoRemovida);
                db.SaveChanges();
                lbSessoes.DataSource = null;
                lbSessoes.DataSource = db.Sessoes.ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(db.Sessoes.Count() > 0)
            {
                List<Sessao> listaSessoes = new List<Sessao>();
                listaSessoes = db.Sessoes.ToList();
                foreach(Sessao sessao in listaSessoes)
                {
                    
                    int horas = sessao.Filme.Duracao / 60;
                    int minutos = sessao.Filme.Duracao % 60;
                    TimeSpan ts = new TimeSpan(horas, minutos, 0);

                    if (DateTime.Now > sessao.DataInicio + ts)
                    {
                        db.Sessoes.Remove(sessao);
                        
                    }
                }
                db.SaveChanges();
                lbSessoes.DataSource = null;
                lbSessoes.DataSource = db.Sessoes.ToList();
            } 
        }
    }
}
