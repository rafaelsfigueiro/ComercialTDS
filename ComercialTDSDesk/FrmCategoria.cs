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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                if (txtNome.Text != string.Empty && txtSigla.Text != string.Empty)
                {

                    Categoria categoria = new(txtNome.Text, txtSigla.Text);
                    categoria.Inserir();
                    if (categoria.Id > 0)
                    {
                        MessageBox.Show($"Categoria cadastrado com sucesso ");

                    }
                }
                else
                {
                    Categoria categoria = new(int.Parse(txtID.Text), txtNome.Text, txtSigla.Text);
                    if (categoria.Atualizar())
                    {
                        MessageBox.Show($"Cadastrado atualizado com sucesso ");
                        btnGravar.Enabled = false;

                    }
                }

            }

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
