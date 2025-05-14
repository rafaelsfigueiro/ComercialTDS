namespace ComercialTDSDesk
{
    partial class FrmNivel
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
            btnGravar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DgvNiveis = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            cndNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvNiveis).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(156, 222);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(327, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(246, 222);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(156, 65);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 3;
            txtID.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(156, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(156, 129);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(246, 23);
            txtSigla.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 102);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "Sigla";
            // 
            // DgvNiveis
            // 
            DgvNiveis.AllowUserToAddRows = false;
            DgvNiveis.AllowUserToDeleteRows = false;
            DgvNiveis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNiveis.Columns.AddRange(new DataGridViewColumn[] { clnID, cndNome, clnSigla });
            DgvNiveis.Location = new Point(408, 65);
            DgvNiveis.Name = "DgvNiveis";
            DgvNiveis.ReadOnly = true;
            DgvNiveis.RowHeadersVisible = false;
            DgvNiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvNiveis.Size = new Size(280, 180);
            DgvNiveis.TabIndex = 9;
            DgvNiveis.CellContentClick += DgvNiveis_CellContentClick;
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
            cndNome.Width = 178;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvNiveis);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "FrmNivel";
            Text = "Cadastro de Nivel";
            Load += FrmNivel_Load;
            ((System.ComponentModel.ISupportInitialize)DgvNiveis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Button btnEditar;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtSigla;
        private Label label2;
        private Label label3;
        private DataGridView DgvNiveis;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn cndNome;
        private DataGridViewTextBoxColumn clnSigla;
    }
}