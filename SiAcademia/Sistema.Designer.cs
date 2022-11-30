namespace SiAcademia
{
    partial class Sistema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.menu = new System.Windows.Forms.TabControl();
            this.clientesListar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveCliente = new System.Windows.Forms.Button();
            this.lblBuscaCliente = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.btnAddPlanos = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbPlanos = new System.Windows.Forms.ComboBox();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPageAlterar = new System.Windows.Forms.TabPage();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.cbAlteraPlanos = new System.Windows.Forms.ComboBox();
            this.txtAlteraCidade = new System.Windows.Forms.TextBox();
            this.txtAlteraEndereco = new System.Windows.Forms.TextBox();
            this.txtAlteraEmail = new System.Windows.Forms.TextBox();
            this.txtAlteraTelefone = new System.Windows.Forms.TextBox();
            this.txtAlteraCpf = new System.Windows.Forms.TextBox();
            this.txtAlteraNascimento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmsgerro = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.NomeAcademia = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.clientesListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageAlterar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.clientesListar);
            this.menu.Controls.Add(this.tabPageCadastrar);
            this.menu.Controls.Add(this.tabPageAlterar);
            this.menu.Location = new System.Drawing.Point(132, 69);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(741, 389);
            this.menu.TabIndex = 1;
            // 
            // clientesListar
            // 
            this.clientesListar.Controls.Add(this.btnAlterar);
            this.clientesListar.Controls.Add(this.btnRemoveCliente);
            this.clientesListar.Controls.Add(this.lblBuscaCliente);
            this.clientesListar.Controls.Add(this.txtBusca);
            this.clientesListar.Controls.Add(this.dgClientes);
            this.clientesListar.Location = new System.Drawing.Point(4, 24);
            this.clientesListar.Name = "clientesListar";
            this.clientesListar.Size = new System.Drawing.Size(733, 361);
            this.clientesListar.TabIndex = 2;
            this.clientesListar.Text = "Listar";
            this.clientesListar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(594, 19);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 36);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveCliente
            // 
            this.btnRemoveCliente.FlatAppearance.BorderSize = 0;
            this.btnRemoveCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCliente.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCliente.Image")));
            this.btnRemoveCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCliente.Location = new System.Drawing.Point(474, 18);
            this.btnRemoveCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCliente.Name = "btnRemoveCliente";
            this.btnRemoveCliente.Size = new System.Drawing.Size(128, 39);
            this.btnRemoveCliente.TabIndex = 15;
            this.btnRemoveCliente.Text = "Remover";
            this.btnRemoveCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveCliente.UseVisualStyleBackColor = true;
            this.btnRemoveCliente.Click += new System.EventHandler(this.btnRemoveCliente_Click);
            // 
            // lblBuscaCliente
            // 
            this.lblBuscaCliente.AutoSize = true;
            this.lblBuscaCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscaCliente.Location = new System.Drawing.Point(15, 30);
            this.lblBuscaCliente.Name = "lblBuscaCliente";
            this.lblBuscaCliente.Size = new System.Drawing.Size(50, 17);
            this.lblBuscaCliente.TabIndex = 2;
            this.lblBuscaCliente.Text = "Cliente:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(71, 27);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(396, 23);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgClientes
            // 
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.GridColor = System.Drawing.Color.White;
            this.dgClientes.Location = new System.Drawing.Point(29, 62);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.Size = new System.Drawing.Size(653, 277);
            this.dgClientes.TabIndex = 0;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.Controls.Add(this.btnAddPlanos);
            this.tabPageCadastrar.Controls.Add(this.txtNome);
            this.tabPageCadastrar.Controls.Add(this.cbPlanos);
            this.tabPageCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabPageCadastrar.Controls.Add(this.txtCidade);
            this.tabPageCadastrar.Controls.Add(this.txtEndereco);
            this.tabPageCadastrar.Controls.Add(this.txtEmail);
            this.tabPageCadastrar.Controls.Add(this.txtTelefone);
            this.tabPageCadastrar.Controls.Add(this.txtCpf);
            this.tabPageCadastrar.Controls.Add(this.txtNascimento);
            this.tabPageCadastrar.Controls.Add(this.lblPlano);
            this.tabPageCadastrar.Controls.Add(this.lblCidade);
            this.tabPageCadastrar.Controls.Add(this.lblEndereco);
            this.tabPageCadastrar.Controls.Add(this.lblEmail);
            this.tabPageCadastrar.Controls.Add(this.lblTelefone);
            this.tabPageCadastrar.Controls.Add(this.lblNascimento);
            this.tabPageCadastrar.Controls.Add(this.lblCpf);
            this.tabPageCadastrar.Controls.Add(this.lblNome);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 24);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(733, 361);
            this.tabPageCadastrar.TabIndex = 1;
            this.tabPageCadastrar.Text = "Cadastrar";
            this.tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAddPlanos
            // 
            this.btnAddPlanos.Image = global::SiAcademia.Properties.Resources.add;
            this.btnAddPlanos.Location = new System.Drawing.Point(661, 257);
            this.btnAddPlanos.Name = "btnAddPlanos";
            this.btnAddPlanos.Size = new System.Drawing.Size(34, 34);
            this.btnAddPlanos.TabIndex = 36;
            this.btnAddPlanos.UseVisualStyleBackColor = true;
            this.btnAddPlanos.Click += new System.EventHandler(this.btnAddPlanos_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(459, 23);
            this.txtNome.TabIndex = 35;
            // 
            // cbPlanos
            // 
            this.cbPlanos.FormattingEnabled = true;
            this.cbPlanos.Location = new System.Drawing.Point(199, 262);
            this.cbPlanos.Name = "cbPlanos";
            this.cbPlanos.Size = new System.Drawing.Size(459, 23);
            this.cbPlanos.TabIndex = 34;
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfirmaCadastro.Image")));
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(326, 296);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(142, 34);
            this.BtnConfirmaCadastro.TabIndex = 33;
            this.BtnConfirmaCadastro.Text = "Cadastrar";
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(199, 233);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(459, 23);
            this.txtCidade.TabIndex = 31;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(199, 204);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(459, 23);
            this.txtEndereco.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(199, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(459, 23);
            this.txtEmail.TabIndex = 29;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(199, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(459, 23);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(199, 88);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(459, 23);
            this.txtCpf.TabIndex = 27;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(199, 117);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(459, 23);
            this.txtNascimento.TabIndex = 26;
            this.txtNascimento.TextChanged += new System.EventHandler(this.txtNascimento_TextChanged);
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(80, 270);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(42, 15);
            this.lblPlano.TabIndex = 24;
            this.lblPlano.Text = "Planos";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(79, 241);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 23;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(79, 212);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 15);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(79, 154);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(79, 125);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblNascimento.TabIndex = 19;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(79, 96);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 15);
            this.lblCpf.TabIndex = 18;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome ";
            // 
            // tabPageAlterar
            // 
            this.tabPageAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabPageAlterar.Controls.Add(this.label8);
            this.tabPageAlterar.Controls.Add(this.label7);
            this.tabPageAlterar.Controls.Add(this.label6);
            this.tabPageAlterar.Controls.Add(this.label5);
            this.tabPageAlterar.Controls.Add(this.label4);
            this.tabPageAlterar.Controls.Add(this.label3);
            this.tabPageAlterar.Controls.Add(this.label2);
            this.tabPageAlterar.Controls.Add(this.label1);
            this.tabPageAlterar.Controls.Add(this.txtAlteraNome);
            this.tabPageAlterar.Controls.Add(this.cbAlteraPlanos);
            this.tabPageAlterar.Controls.Add(this.txtAlteraCidade);
            this.tabPageAlterar.Controls.Add(this.txtAlteraEndereco);
            this.tabPageAlterar.Controls.Add(this.txtAlteraEmail);
            this.tabPageAlterar.Controls.Add(this.txtAlteraTelefone);
            this.tabPageAlterar.Controls.Add(this.txtAlteraCpf);
            this.tabPageAlterar.Controls.Add(this.txtAlteraNascimento);
            this.tabPageAlterar.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlterar.Name = "tabPageAlterar";
            this.tabPageAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterar.Size = new System.Drawing.Size(733, 361);
            this.tabPageAlterar.TabIndex = 3;
            this.tabPageAlterar.Text = "Alterar";
            this.tabPageAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(326, 296);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(117, 33);
            this.btnConfirmaAlteracao.TabIndex = 52;
            this.btnConfirmaAlteracao.Text = "Alterar";
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Planos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(199, 59);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraNome.TabIndex = 43;
            // 
            // cbAlteraPlanos
            // 
            this.cbAlteraPlanos.FormattingEnabled = true;
            this.cbAlteraPlanos.Location = new System.Drawing.Point(199, 262);
            this.cbAlteraPlanos.Name = "cbAlteraPlanos";
            this.cbAlteraPlanos.Size = new System.Drawing.Size(459, 23);
            this.cbAlteraPlanos.TabIndex = 42;
            // 
            // txtAlteraCidade
            // 
            this.txtAlteraCidade.Location = new System.Drawing.Point(199, 232);
            this.txtAlteraCidade.Name = "txtAlteraCidade";
            this.txtAlteraCidade.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraCidade.TabIndex = 41;
            // 
            // txtAlteraEndereco
            // 
            this.txtAlteraEndereco.Location = new System.Drawing.Point(199, 202);
            this.txtAlteraEndereco.Name = "txtAlteraEndereco";
            this.txtAlteraEndereco.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraEndereco.TabIndex = 40;
            // 
            // txtAlteraEmail
            // 
            this.txtAlteraEmail.Location = new System.Drawing.Point(199, 172);
            this.txtAlteraEmail.Name = "txtAlteraEmail";
            this.txtAlteraEmail.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraEmail.TabIndex = 39;
            // 
            // txtAlteraTelefone
            // 
            this.txtAlteraTelefone.Location = new System.Drawing.Point(199, 141);
            this.txtAlteraTelefone.Name = "txtAlteraTelefone";
            this.txtAlteraTelefone.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraTelefone.TabIndex = 38;
            // 
            // txtAlteraCpf
            // 
            this.txtAlteraCpf.Location = new System.Drawing.Point(199, 84);
            this.txtAlteraCpf.Name = "txtAlteraCpf";
            this.txtAlteraCpf.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraCpf.TabIndex = 37;
            // 
            // txtAlteraNascimento
            // 
            this.txtAlteraNascimento.Location = new System.Drawing.Point(199, 112);
            this.txtAlteraNascimento.Name = "txtAlteraNascimento";
            this.txtAlteraNascimento.Size = new System.Drawing.Size(459, 23);
            this.txtAlteraNascimento.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblmsgerro);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.NomeAcademia);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(-3, -8);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(908, 60);
            this.panel1.TabIndex = 4;
            // 
            // lblmsgerro
            // 
            this.lblmsgerro.AutoSize = true;
            this.lblmsgerro.ForeColor = System.Drawing.Color.Black;
            this.lblmsgerro.Location = new System.Drawing.Point(60, 14);
            this.lblmsgerro.Name = "lblmsgerro";
            this.lblmsgerro.Size = new System.Drawing.Size(12, 15);
            this.lblmsgerro.TabIndex = 11;
            this.lblmsgerro.Text = "*";
            this.lblmsgerro.Click += new System.EventHandler(this.lblmsgerro_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnFechar.Image = global::SiAcademia.Properties.Resources.cancel;
            this.btnFechar.Location = new System.Drawing.Point(822, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(52, 38);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // NomeAcademia
            // 
            this.NomeAcademia.AutoSize = true;
            this.NomeAcademia.BackColor = System.Drawing.Color.DarkMagenta;
            this.NomeAcademia.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeAcademia.Location = new System.Drawing.Point(417, 14);
            this.NomeAcademia.Name = "NomeAcademia";
            this.NomeAcademia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NomeAcademia.Size = new System.Drawing.Size(141, 25);
            this.NomeAcademia.TabIndex = 1;
            this.NomeAcademia.Text = "Champions Gym";
            this.NomeAcademia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomeAcademia.UseMnemonic = false;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::SiAcademia.Properties.Resources.gym;
            this.Logo.Location = new System.Drawing.Point(8, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(35, 33);
            this.Logo.TabIndex = 0;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Sistema_Load_1);
            this.menu.ResumeLayout(false);
            this.clientesListar.ResumeLayout(false);
            this.clientesListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageAlterar.ResumeLayout(false);
            this.tabPageAlterar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl menu;
        private TabPage tabPageCadastrar;
        private TextBox txtNome;
        private ComboBox cbPlanos;
        private Button BtnConfirmaCadastro;
        private TextBox txtCidade;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtNascimento;
        private Label lblPlano;
        private Label lblCidade;
        private Label lblEndereco;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNascimento;
        private Label lblCpf;
        private Label lblNome;
        private TabPage tabPageAlterar;
        private TabPage clientesListar;
        private Button btnAlterar;
        private Button btnRemoveCliente;
        private Label lblBuscaCliente;
        private TextBox txtBusca;
        private DataGridView dgClientes;
        private Panel panel1;
        private Label lblmsgerro;
        private Button btnFechar;
        private Label NomeAcademia;
        private Panel Logo;
        private TextBox txtAlteraNome;
        private ComboBox cbAlteraPlanos;
        private TextBox txtAlteraCidade;
        private TextBox txtAlteraEndereco;
        private TextBox txtAlteraEmail;
        private TextBox txtAlteraTelefone;
        private TextBox txtAlteraCpf;
        private TextBox txtAlteraNascimento;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnConfirmaAlteracao;
        private Button btnAddPlanos;
    }
}