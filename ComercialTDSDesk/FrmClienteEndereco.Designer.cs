namespace ComercialTDSDesk
{
    partial class FrmClienteEndereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteEndereco));
            pictureBox1 = new PictureBox();
            txtCancelar = new Button();
            button2 = new Button();
            DateNasc = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnSalvar = new Button();
            txtCep = new TextBox();
            txtLogradouro = new TextBox();
            textBox1 = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtUf = new TextBox();
            txtTipoEndereco = new TextBox();
            txtId = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 175);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtCancelar
            // 
            txtCancelar.Location = new Point(170, 206);
            txtCancelar.Name = "txtCancelar";
            txtCancelar.Size = new Size(75, 23);
            txtCancelar.TabIndex = 30;
            txtCancelar.Text = "Cancela&r";
            txtCancelar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(89, 206);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 29;
            button2.Text = "E&ditar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DateNasc
            // 
            DateNasc.AutoSize = true;
            DateNasc.Location = new Point(170, 177);
            DateNasc.Name = "DateNasc";
            DateNasc.Size = new Size(60, 15);
            DateNasc.TabIndex = 28;
            DateNasc.Text = "Da&ta Nasc";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email@Email.com.br";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 27;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(170, 116);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone _______-____";
            txtTelefone.Size = new Size(216, 23);
            txtTelefone.TabIndex = 26;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(170, 87);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(216, 23);
            txtCpf.TabIndex = 25;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(170, 58);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(603, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(190, 23);
            dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(233, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 7);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Imagem";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(8, 206);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Sal&var";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(456, 58);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "Cep";
            txtCep.Size = new Size(216, 23);
            txtCep.TabIndex = 32;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(456, 87);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(216, 23);
            txtLogradouro.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 116);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Numero";
            textBox1.Size = new Size(69, 23);
            textBox1.TabIndex = 36;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(456, 116);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(135, 23);
            txtComplemento.TabIndex = 37;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(456, 145);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro";
            txtBairro.Size = new Size(216, 23);
            txtBairro.TabIndex = 38;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(456, 180);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(141, 23);
            txtCidade.TabIndex = 39;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(603, 180);
            txtUf.Name = "txtUf";
            txtUf.PlaceholderText = "uf";
            txtUf.Size = new Size(69, 23);
            txtUf.TabIndex = 40;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(456, 209);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.PlaceholderText = "Tipo de Endereço";
            txtTipoEndereco.Size = new Size(216, 23);
            txtTipoEndereco.TabIndex = 41;
            // 
            // txtId
            // 
            txtId.Location = new Point(170, 25);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(30, 23);
            txtId.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 25);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Id";
            textBox2.Size = new Size(30, 23);
            textBox2.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(492, 25);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "IdCliente";
            textBox3.Size = new Size(67, 23);
            textBox3.TabIndex = 44;
            // 
            // FrmClienteEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtId);
            Controls.Add(txtTipoEndereco);
            Controls.Add(txtUf);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(textBox1);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCep);
            Controls.Add(pictureBox1);
            Controls.Add(txtCancelar);
            Controls.Add(button2);
            Controls.Add(DateNasc);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmClienteEndereco";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button txtCancelar;
        private Button button2;
        private Label DateNasc;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNome;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnSalvar;
        private TextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox textBox1;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUf;
        private TextBox txtTipoEndereco;
        private TextBox txtId;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}