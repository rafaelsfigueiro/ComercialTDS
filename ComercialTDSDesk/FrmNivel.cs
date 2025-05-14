using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void DgvNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new(txtNome.Text, txtSigla.Text);
            nivel.Inserir();
            if (nivel.Id > 0)
            {
                MessageBox.Show($"Nível cadastrado com sucesso ");
                FrmNivel_Load(sender, e);
            }
        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {
            var niveis = Nivel.ObterLista();
            int linha = 0;
            DgvNiveis.Rows.Clear();
            foreach (var nivel in niveis)
            {
                DgvNiveis.Rows.Add();
                DgvNiveis.Rows[linha].Cells[0].Value = nivel.Id;
                DgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
                DgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;
                linha++;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
