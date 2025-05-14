using ComercialTDSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialTDSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnCancelar.Text == "&Voltar")
                Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Program.UsuarioLogado = Usuario.EfatuarLogin(txtEmail.Text, txtSenha.Text);
            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var host = Environment.MachineName;
            var user = Environment.UserName;
            MessageBox.Show($"Nome do pc: {host}\nUsuário: {user}");

            foreach (var up in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (up.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    MessageBox.Show($"IP: {up}");
                }
            }

            var ip = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in ip)
            {
                item.GetIPv4Statistics();
            }
                
        }
    }
}
