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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            ofdObterImagem.Filter = "Imagens (*.jpg;*.png)|*.jpg;*png";
            if (ofdObterImagem.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = Image.FromFile(ofdObterImagem.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new();

            using ( ms )
            {
                picImagem.Image.Save(ms, picImagem.Image.RawFormat);

            }
            FrmProduto produto = new(
            txtCodBarras.Text,
            txtDescricao.Text,
            (Double)nudValorUnit.Value,
                txtUnidadeVenda.Text,
                categoria.ObterPorID(),
                (double)nudEstoqueMinimo.Value,
                (double)nudClasseDesconto.Value,
                ms,


                );

            produto.Inserir();
            if (produto.> 0)
                MessageBox.Show($"Produto {produto.id}Gravado com Sucesso!");
        }
    }
}
