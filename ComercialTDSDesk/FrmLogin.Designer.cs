﻿namespace ComercialTDSDesk
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            chkExibeSenha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(247, 271);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(392, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(247, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Email";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(247, 210);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(220, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // chkExibeSenha
            // 
            chkExibeSenha.AutoSize = true;
            chkExibeSenha.Location = new Point(447, 214);
            chkExibeSenha.Name = "chkExibeSenha";
            chkExibeSenha.Size = new Size(15, 14);
            chkExibeSenha.TabIndex = 4;
            chkExibeSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 55);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 5;
            label1.Text = "Comercial TDS System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 146);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 6;
            label2.Text = "Acesso ao Sistema";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkExibeSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        public Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private CheckBox chkExibeSenha;
        private Label label1;
        private Label label2;
    }
}