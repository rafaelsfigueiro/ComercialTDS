namespace ComercialTDSDesk
{
    partial class FrmUsuario
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
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvUsuarios = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            cndNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            cndSenha = new DataGridViewTextBoxColumn();
            cmbNivel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "&Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 58);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 15;
            label4.Text = "&Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 23);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtSigla_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 23);
            txtNome.TabIndex = 13;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(74, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 12;
            txtID.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(104, 207);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(185, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(23, 207);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(74, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(201, 23);
            txtSenha.TabIndex = 17;
            txtSenha.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 128);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 18;
            label1.Text = "&Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 170);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 20;
            label2.Text = "Nive&l";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnID, cndNome, clnEmail, cndSenha });
            dgvUsuarios.Location = new Point(291, 50);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(392, 180);
            dgvUsuarios.TabIndex = 21;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Visible = false;
            // 
            // cndNome
            // 
            cndNome.Frozen = true;
            cndNome.HeaderText = "Nome";
            cndNome.Name = "cndNome";
            cndNome.ReadOnly = true;
            cndNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 140;
            // 
            // cndSenha
            // 
            cndSenha.Frozen = true;
            cndSenha.HeaderText = "Senha";
            cndSenha.Name = "cndSenha";
            cndSenha.ReadOnly = true;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(74, 167);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(163, 23);
            cmbNivel.TabIndex = 22;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbNivel);
            Controls.Add(dgvUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtID;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn cndNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn cndSenha;
        private ComboBox cmbNivel;
    }
}