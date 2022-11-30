namespace SiAcademia
{
    partial class FrmCadastroPlanos
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomeAcademia = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePlano = new System.Windows.Forms.TextBox();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtDataTermino = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnFechar.Image = global::SiAcademia.Properties.Resources.cancel;
            this.btnFechar.Location = new System.Drawing.Point(509, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(52, 38);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.NomeAcademia);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 45);
            this.panel1.TabIndex = 6;
            // 
            // NomeAcademia
            // 
            this.NomeAcademia.AutoSize = true;
            this.NomeAcademia.BackColor = System.Drawing.Color.DarkMagenta;
            this.NomeAcademia.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeAcademia.Location = new System.Drawing.Point(221, 10);
            this.NomeAcademia.Name = "NomeAcademia";
            this.NomeAcademia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NomeAcademia.Size = new System.Drawing.Size(141, 25);
            this.NomeAcademia.TabIndex = 7;
            this.NomeAcademia.Text = "Champions Gym";
            this.NomeAcademia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomeAcademia.UseMnemonic = false;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::SiAcademia.Properties.Resources.gym;
            this.Logo.Location = new System.Drawing.Point(9, 8);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(35, 33);
            this.Logo.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(36, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 15);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome do Plano";
            // 
            // txtNomePlano
            // 
            this.txtNomePlano.Location = new System.Drawing.Point(132, 99);
            this.txtNomePlano.Name = "txtNomePlano";
            this.txtNomePlano.Size = new System.Drawing.Size(412, 23);
            this.txtNomePlano.TabIndex = 36;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(132, 138);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(412, 23);
            this.txtDataInicio.TabIndex = 37;
            // 
            // txtDataTermino
            // 
            this.txtDataTermino.Location = new System.Drawing.Point(132, 183);
            this.txtDataTermino.Name = "txtDataTermino";
            this.txtDataTermino.Size = new System.Drawing.Size(412, 23);
            this.txtDataTermino.TabIndex = 38;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(132, 226);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(412, 23);
            this.txtValor.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Data de início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data término";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.Image = global::SiAcademia.Properties.Resources.add;
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(242, 256);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(142, 34);
            this.BtnConfirmaCadastro.TabIndex = 43;
            this.BtnConfirmaCadastro.Text = "Cadastrar";
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // FrmCadastroPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 302);
            this.Controls.Add(this.BtnConfirmaCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDataTermino);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtNomePlano);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroPlanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroPlanos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFechar;
        private Panel panel1;
        private Panel Logo;
        private Label NomeAcademia;
        private Label lblNome;
        private TextBox txtNomePlano;
        private TextBox txtDataInicio;
        private TextBox txtDataTermino;
        private TextBox txtValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnConfirmaCadastro;
    }
}