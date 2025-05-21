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
    public partial class FrmUsuario : Form
    {
        private void CarregaNivel()
        {
            List<Nivel> lista = Nivel.ObterLista(); // Este método precisa retornar List<Nivel>
            MessageBox.Show("Qtd usuários: " + lista.Count);
            cmbNivel.DataSource = lista;
            cmbNivel.DisplayMember = "Nome"; // o que aparece visualmente
            cmbNivel.ValueMember = "Id";     // valor usado para identificação
            cmbNivel.SelectedIndex = -1;     // nada selecionado inicialmente
        }
        private void CarregaGrid()
        {
            var Lista = Usuario.ObterLista();

            // Verifica se retornou dados
            if (Lista == null || Lista.Count == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado.");
                return;
            }

            dgvUsuarios.Rows.Clear();

            foreach (var item in Lista)
            {
                int linha = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = item.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = item.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = item.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = item.Nivel != null ? item.Nivel.Nome : "Sem nível";
            }
        }
        public void LimpaControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cmbNivel.SelectedIndex = -1;

        }
        //Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem; // pega o nivel selecionado
        //Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado);
        //usuario.Inserir();
        //MessageBox.Show("Usuario inserido com sucesso");
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
           CarregaNivel();
            CarregaGrid();
            LimpaControles();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbNivel.SelectedValue.ToString());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)

            {

                // INSERIR

                if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty && cmbNivel.SelectedItem != null)

                {

                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, nivelSelecionado, true);

                    usuario.Inserir();

                    if (usuario.Id > 0)

                    {

                        MessageBox.Show("Usuário cadastrado com sucesso!");

                        //btnGravar.Enabled = false;

                    }

                }

                CarregaGrid();     // Método que você deve ter para atualizar a grade

                // Método para limpar os campos

            }

            else

            {

                // ATUALIZAR

                if (cmbNivel.SelectedItem != null)

                {

                    Nivel nivelSelecionado = (Nivel)cmbNivel.SelectedItem;

                    Usuario usuario = new(

                                int.Parse(txtID.Text),

                                txtNome.Text,

                                txtEmail.Text,

                                txtSenha.Text,

                                nivelSelecionado,

                                true

                            );

                    if (usuario.Atualizar())

                    {

                        MessageBox.Show("Usuário atualizado com sucesso!");

                        //btnGravar.Enabled = false;

                    }

                }

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {

                List<Nivel> lista = Nivel.ObterLista(); // Este método precisa retornar List<Nivel>

                MessageBox.Show("Qtd usuários: " + lista.Count);

                cmbNivel.DataSource = lista;

                cmbNivel.DisplayMember = "Nome"; // o que aparece visualmente

                cmbNivel.ValueMember = "Id";     // valor usado para identificação

                cmbNivel.SelectedIndex = -1;     // nada selecionado inicialmente

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }



        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // recuperando o indice da linha do gride 

            int linha = dgvUsuarios.CurrentRow.Index;

            // recuperando o id do nivel na coluna, oculda, ID (0)

            int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);

            var usuario = Usuario.ObterPorId(id);

            // //obter  o objeto nivel

            // preenche os campos com os dados do usuario

            txtID.Text = usuario.Id.ToString();

            txtNome.Text = usuario.Nome;

            txtEmail.Text = usuario.Email;

            txtSenha.Text = usuario.Senha;

            cmbNivel.SelectedValue = usuario.Nivel.Id;

            //desabilita os campos

            txtNome.ReadOnly = true;

            txtEmail.ReadOnly = true;

            cmbNivel.Enabled = false;

            btnEditar.Enabled = true;


        }
    }
}
