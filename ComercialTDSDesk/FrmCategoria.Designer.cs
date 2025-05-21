namespace ComercialTDSDesk
{
    partial class FrmCategoria
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
            label2 = new Label();
            txtSigla = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 148);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 16;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 119);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Nome";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(83, 140);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(246, 23);
            txtSigla.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 13;
            // 
            // txtID
            // 
            txtID.Location = new Point(83, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 12;
            txtID.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(173, 239);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(83, 239);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "&Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtSigla;
        private TextBox txtNome;
        private TextBox txtID;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnGravar;
    }
}