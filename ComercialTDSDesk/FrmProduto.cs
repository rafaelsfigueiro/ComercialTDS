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
            byte[] imgBytes;
            MemoryStream ms = new();
            picImagem.Image.Save(ms, picImagem.Image.RawFormat);
            imgBytes = ms.ToArray();


            Produto produto = new();

            produto.Inserir();
            if (produto.Id > 0)
                MessageBox.Show($"Produto {produto.Id}Gravado com Sucesso!");
        }

        private void FrmProduto_Enter(object sender, EventArgs e)
        {
            nudEstoqueMinimo.Select(0, 9);
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
