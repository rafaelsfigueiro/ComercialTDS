using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtSigla.Text != string.Empty)
                {

                    Nivel nivel = new(txtNome.Text, txtSigla.Text);
                    nivel.Inserir();
                    if (nivel.Id > 0)
                    {
                        MessageBox.Show($"Nível cadastrado com sucesso ");
                        FrmNivel_Load(sender, e);
                    }
                }
                else
                {
                    Nivel nivel = new(int.Parse(txtID.Text), txtNome.Text, txtSigla.Text);
                    if (nivel.Atualizar())
                    {
                        MessageBox.Show($"Nível atualizado com sucesso ");
                        btnGravar.Enabled = false;

                    }
                }

            }
            CarrefaGrid();
            LimpaControles();
        }

        private void LimpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtSigla.Clear();
            
        }
        private void CarrefaGrid()
        {
           
        }
        private void FrmNivel_Load(object sender, EventArgs e)
        {
            CarrefaGrid();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvNiveis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperando o indice da linha do grid
            int Linha = DgvNiveis.CurrentRow.Index;
            // Recuperando o id do nivel na coluna, oculta, Id (0)
            int id = Convert.ToInt32(DgvNiveis.Rows[Linha].Cells[0].Value);
            // obter o objeto nivel
            Nivel nivel = Nivel.ObterPorId(id);
            // Atribuindo o dados aos controles
            txtID.Text = nivel.Id.ToString();
            txtNome.Text = nivel.Nome;
            txtSigla.Text = nivel.Sigla;
            txtNome.ReadOnly = true;
            txtSigla.ReadOnly = true;
            btnEditar.Enabled = true;


            //MessageBox.Show($"{nivel.Id}{nivel.Nome}{nivel.Sigla}");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtSigla.ReadOnly = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
