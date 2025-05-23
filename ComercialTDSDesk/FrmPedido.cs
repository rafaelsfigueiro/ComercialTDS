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
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = $"{Program.UsuarioLogado.Id}";
        }

        private void FrmPedido_Load_1(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Length > 4)
            {
                var cliente = Cliente.ObterPorId(int.Parse(txtIdCliente.Text));
                if (cliente.Id > 0)
                {
                    txtNomeCliente.Text = cliente.Nome;
                }


            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(Program.UsuarioLogado, Cliente.ObterPorId(int.Parse(txtIdCliente.Text)));
            pedido.Inserir();
            if (pedido.Id > 0)
            {
                txtIdPedido.Text = pedido.Id.ToString();
                grbIndentificacao.Enabled = false;
                grbItens.Enabled = true;
            }
        }

        private void grbIndentificacao_Enter(object sender, EventArgs e)
        {

        }

        private void grbItens_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {
            var produto = Produto.ObterPorCodBar(txtCodBar.Text);
            
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 6)
            { 
                var produto = Produto.ObterPorCodBar(txtCodBar.Text);
                if (produto.Id > 0)
                {
                    produto = Produto.ObterPorId(int.Parse(txtCodBar.Text));
                    
                }
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString ("R$ ##.00");

            }
        }
    }
}
