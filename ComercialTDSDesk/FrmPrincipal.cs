﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AssociaPanel(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.Size = pnlCentral.Size;
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(form);
            form.Show();
            pnlCentral.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            Hide();
            frmLogin.ShowDialog();
            if (Program.UsuarioLogado.Id > 0)
            {
                tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + "-" + Program.UsuarioLogado.Nivel.Nome;
            }
            Show();
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.btnCancelar.Text = "&Voltar";
            frmLogin.ShowDialog();
            tsslUsuarioLogado.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
        }

        private void clientePrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nivéisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNivel frmNivel = new();
            frmNivel.MdiParent = this;
            frmNivel.Show();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProduto());
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmProdutoListar());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmCategoria());
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociaPanel(new FrmPedido());
        }
    }
}
