using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
                txtValorUnit.Text = produto.ValorUnit.ToString("R$ ##.00");
                label4.Text = $"R${produto.ValorUnit * produto.ClasseDesconto}";

            }
        }

        private void txtIdProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new(

                int.Parse(txtIdPedido.Text),
                Produto.ObterPorId(int.Parse(txtIdProd.Text)),
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)

           );
            ItemPedido.Inserir();
            if (itemPedido.Id > 0)
            {
                CarregarItems();
            }
            private void CarregarItems(int pedidoID)
            {
                var Itens = ItemPedido.ObterListaPorPedidoId(pedidoID);
                dgvItensPedido.Rows.Clear();
                int linha = 0;
                double subTotal, descontos = 0;
                double desconto = 0;

                foreach (var item in Itens)
                {
                    dgvItensPedido.Rows.Add();
                    dgvItensPedido.Rows[linha].Cells[0].Value = $"#{(linha + 1).ToString().PadLeft(2, '0')}";
                    dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBarras;
                    dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                    dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                    dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                    dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                    descontos = +item.Desconto;
                    double totalItem = item.ValorUnit * item.Quantidade - item.Desconto;
                    dgvItensPedido.Rows[linha].Cells[6].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                    subTotal += totalItem; // subTotal = SubTotal + totalItem;
                    linha++;
                }
                txtSubTotal.Text = subTotal.ToString();
                txtSubTotal.Text = subTotal.ToString();
                txtDescontoItem.Text = descontos.ToString();
                txtTotal.Text = (subTotal - descontos).ToString();
            }
        }

        private void txtIdPedido_KeyDown(object sender, KeyEventArgs e)
        {
            // verificar se a tecla enter foi pressionada
            if (e.KeyCode == Keys.Enter)
            {
                var pedido = Pedido.ObterPorId(int.Parse(txtIdPedido.Text));
                if (pedido.Id > 0 && pedido.Status == "A")
                {
                    if (pedido.Status == "A")
                    {
                        grbIndentificacao.Enabled = false;
                        txtNomeCliente.Text = $"{pedido.Cliente.Id} - {pedido.Cliente.Nome}";
                        txtUsuario.Text = $"{pedido.Usuario.Id} - {pedido.Usuario.Nome}";
                        grbItens.Enabled = true;
                        CarregarItens(pedido.Id);
                    }
                    else if (pedido.Status == "F")
                    {
                        var resposta = MessageBox.Show(
                              "O pedido está fechado. \n Deseja reabrir?", // Texto da mensaggem
                              " Pedido", MessageBoxButtons.YesNo, // botão da mensagem
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 // define qual botão será selecionado por padrão
                            );
                        if (resposta == DialogResult.Yes)
                        {
                            pedido.Status = "A"; // reabrir o pedido
                            pedido.Atualizar();
                        }

                    }



                }
            }
        }

        private void txtDescontoPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTotal.Text = (double.Parse(txtSubTotalItens.Text) - double.Parse(txtDescontoPedido.Text)).ToString("##.00");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Pedido pedido = Pedido.ObterPorId(int.Parse(txtDescontoPedido.Text));
            pedido.Desconto = Double.Parse(txtDescontoPedido.Text);
            Pedido.Status = "F"; // Fechar o pedido
            if (pedido.Atualizar())
            { 
              MessageBox.Show($"Pedido{pedido.Id} foi fechado com sucesso.\n");
                
                dgvItensPedido.Rows.Clear();
                txtIdPedido

            }

        }
    }
}
