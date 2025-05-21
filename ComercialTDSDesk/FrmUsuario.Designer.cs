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
            txtSigla = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            DgvNiveis = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            cndNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            cndSenha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvNiveis).BeginInit();
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
            // txtSigla
            // 
            txtSigla.Location = new Point(74, 79);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(201, 23);
            txtSigla.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(74, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 23);
            txtNome.TabIndex = 13;
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
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(185, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(23, 207);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "&Salvar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 17;
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
            // textBox2
            // 
            textBox2.Location = new Point(74, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 19;
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
            // DgvNiveis
            // 
            DgvNiveis.AllowUserToAddRows = false;
            DgvNiveis.AllowUserToDeleteRows = false;
            DgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnID, cndNome, clnEmail, cndSenha });
            DgvNiveis.Location = new Point(281, 50);
            DgvNiveis.Name = "DgvNiveis";
            DgvNiveis.ReadOnly = true;
            DgvNiveis.RowHeadersVisible = false;
            DgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvNiveis.Size = new Size(392, 180);
            DgvNiveis.TabIndex = 21;
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
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvNiveis);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)DgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private TextBox txtSigla;
        private TextBox txtNome;
        private TextBox txtID;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private DataGridView DgvNiveis;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn cndNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn cndSenha;
    }
}