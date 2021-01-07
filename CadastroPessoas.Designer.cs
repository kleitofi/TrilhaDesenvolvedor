namespace TrilhaDesenvolvedor
{
    partial class frmCadastroPessoas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPessoas));
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtMasCep = new System.Windows.Forms.MaskedTextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtMasCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtMasBaseSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlExibirSenha = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtMasDataNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasDataNascFilho = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoFilho = new System.Windows.Forms.ComboBox();
            this.txtNomeFilho = new System.Windows.Forms.TextBox();
            this.lFilhos = new System.Windows.Forms.Label();
            this.dgvFilhos = new System.Windows.Forms.DataGridView();
            this.panelFilhos = new System.Windows.Forms.Panel();
            this.btnAddFilho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).BeginInit();
            this.panelFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(170, 39);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(81, 14);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 39);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(229, 84);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 14);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(135, 130);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 14);
            this.lblEndereco.TabIndex = 13;
            this.lblEndereco.Text = "Endereco:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(14, 130);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 14);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "Cep:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(14, 84);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 14);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(151, 220);
            this.lblSalarioBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(84, 14);
            this.lblSalarioBase.TabIndex = 17;
            this.lblSalarioBase.Text = "Salário Base:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(325, 39);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 14);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(14, 220);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 14);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(17, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(173, 58);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(147, 22);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(138, 149);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(223, 22);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtMasCep
            // 
            this.txtMasCep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasCep.Location = new System.Drawing.Point(17, 149);
            this.txtMasCep.Mask = "00,000-000";
            this.txtMasCep.Name = "txtMasCep";
            this.txtMasCep.Size = new System.Drawing.Size(86, 22);
            this.txtMasCep.TabIndex = 6;
            this.txtMasCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Advogados",
            "Cozinheiros",
            "Vendedores"});
            this.cbxCategoria.Location = new System.Drawing.Point(17, 239);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(129, 22);
            this.cbxCategoria.TabIndex = 12;
            // 
            // txtMasCPF
            // 
            this.txtMasCPF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasCPF.Location = new System.Drawing.Point(17, 104);
            this.txtMasCPF.Mask = "000,000,000-00";
            this.txtMasCPF.Name = "txtMasCPF";
            this.txtMasCPF.Size = new System.Drawing.Size(116, 22);
            this.txtMasCPF.TabIndex = 3;
            this.txtMasCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasCPF.Leave += new System.EventHandler(this.txtMasCPF_Leave);
            // 
            // txtMasBaseSalario
            // 
            this.txtMasBaseSalario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasBaseSalario.Location = new System.Drawing.Point(154, 239);
            this.txtMasBaseSalario.Mask = "$ 9,999.00";
            this.txtMasBaseSalario.Name = "txtMasBaseSalario";
            this.txtMasBaseSalario.Size = new System.Drawing.Size(94, 22);
            this.txtMasBaseSalario.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gold;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Location = new System.Drawing.Point(499, 523);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 35);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbxSexo
            // 
            this.cbxSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSexo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Recusar dizer"});
            this.cbxSexo.Location = new System.Drawing.Point(328, 58);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(103, 22);
            this.cbxSexo.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(369, 150);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(62, 22);
            this.txtNumero.TabIndex = 8;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(366, 130);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 14);
            this.lblNum.TabIndex = 39;
            this.lblNum.Text = "Número:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(17, 194);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(175, 22);
            this.txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(14, 175);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 14);
            this.lblBairro.TabIndex = 41;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(197, 175);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(25, 14);
            this.lblUF.TabIndex = 43;
            this.lblUF.Text = "UF:";
            // 
            // cbxUF
            // 
            this.cbxUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUF.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Recusar dizer"});
            this.cbxUF.Location = new System.Drawing.Point(200, 194);
            this.cbxUF.Margin = new System.Windows.Forms.Padding(4);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxUF.Size = new System.Drawing.Size(48, 22);
            this.cbxUF.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(256, 194);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 22);
            this.txtCidade.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(252, 175);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 14);
            this.lblCidade.TabIndex = 45;
            this.lblCidade.Text = "Cidade:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlExibirSenha);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.cbxCidade);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.lblSobrenome);
            this.panel1.Controls.Add(this.txtMasDataNascFunc);
            this.panel1.Controls.Add(this.cbxUF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblUF);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.cbxSexo);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.btnCarregar);
            this.panel1.Controls.Add(this.lblSalarioBase);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtMasCep);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.txtMasCPF);
            this.panel1.Controls.Add(this.txtMasBaseSalario);
            this.panel1.Controls.Add(this.btnBuscaCep);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 278);
            this.panel1.TabIndex = 48;
            // 
            // pnlExibirSenha
            // 
            this.pnlExibirSenha.BackColor = System.Drawing.SystemColors.Window;
            this.pnlExibirSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExibirSenha.BackgroundImage")));
            this.pnlExibirSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlExibirSenha.Location = new System.Drawing.Point(573, 239);
            this.pnlExibirSenha.Name = "pnlExibirSenha";
            this.pnlExibirSenha.Size = new System.Drawing.Size(28, 20);
            this.pnlExibirSenha.TabIndex = 53;
            this.pnlExibirSenha.Click += new System.EventHandler(this.pnlExibirSenha_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(436, 219);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 14);
            this.lblSenha.TabIndex = 51;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(439, 238);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(134, 22);
            this.txtSenha.TabIndex = 52;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCidade
            // 
            this.cbxCidade.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(258, 186);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(175, 22);
            this.cbxCidade.TabIndex = 50;
            this.cbxCidade.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 29);
            this.panel3.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 50;
            this.label4.Text = "(1) - Dados do Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nome:";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(439, 39);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(162, 150);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 38;
            this.picBox.TabStop = false;
            // 
            // txtMasDataNascFunc
            // 
            this.txtMasDataNascFunc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasDataNascFunc.Location = new System.Drawing.Point(140, 104);
            this.txtMasDataNascFunc.Mask = "00/00/0000";
            this.txtMasDataNascFunc.Name = "txtMasDataNascFunc";
            this.txtMasDataNascFunc.Size = new System.Drawing.Size(85, 22);
            this.txtMasDataNascFunc.TabIndex = 4;
            this.txtMasDataNascFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasDataNascFunc.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nascimento:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(252, 219);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 14);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnCarregar.Image")));
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(439, 194);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(162, 22);
            this.btnCarregar.TabIndex = 14;
            this.btnCarregar.Text = "     Carregar Imagem";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(255, 238);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(176, 22);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLogin_MouseDoubleClick);
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCep.Image = global::TrilhaDesenvolvedor.Properties.Resources.icoPesquisaCep;
            this.btnBuscaCep.Location = new System.Drawing.Point(109, 149);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(22, 22);
            this.btnBuscaCep.TabIndex = 6;
            this.btnBuscaCep.UseMnemonic = false;
            this.btnBuscaCep.UseVisualStyleBackColor = false;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rbNao);
            this.panel4.Controls.Add(this.rbSim);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 29);
            this.panel4.TabIndex = 50;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Checked = true;
            this.rbNao.Location = new System.Drawing.Point(146, 4);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(46, 18);
            this.rbNao.TabIndex = 53;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(96, 4);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(44, 18);
            this.rbSim.TabIndex = 52;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 51;
            this.label5.Text = "(2) - Filhos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sexo:";
            // 
            // txtMasDataNascFilho
            // 
            this.txtMasDataNascFilho.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasDataNascFilho.Location = new System.Drawing.Point(285, 59);
            this.txtMasDataNascFilho.Mask = "00/00/0000";
            this.txtMasDataNascFilho.Name = "txtMasDataNascFilho";
            this.txtMasDataNascFilho.Size = new System.Drawing.Size(85, 22);
            this.txtMasDataNascFilho.TabIndex = 1;
            this.txtMasDataNascFilho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasDataNascFilho.ValidatingType = typeof(System.DateTime);
            // 
            // cbxSexoFilho
            // 
            this.cbxSexoFilho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSexoFilho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSexoFilho.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSexoFilho.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbxSexoFilho.FormattingEnabled = true;
            this.cbxSexoFilho.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Recusar dizer"});
            this.cbxSexoFilho.Location = new System.Drawing.Point(377, 59);
            this.cbxSexoFilho.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSexoFilho.Name = "cbxSexoFilho";
            this.cbxSexoFilho.Size = new System.Drawing.Size(102, 22);
            this.cbxSexoFilho.TabIndex = 2;
            // 
            // txtNomeFilho
            // 
            this.txtNomeFilho.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFilho.Location = new System.Drawing.Point(17, 59);
            this.txtNomeFilho.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFilho.Name = "txtNomeFilho";
            this.txtNomeFilho.Size = new System.Drawing.Size(261, 22);
            this.txtNomeFilho.TabIndex = 0;
            // 
            // lFilhos
            // 
            this.lFilhos.AutoSize = true;
            this.lFilhos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFilhos.Location = new System.Drawing.Point(14, 39);
            this.lFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFilhos.Name = "lFilhos";
            this.lFilhos.Size = new System.Drawing.Size(39, 14);
            this.lFilhos.TabIndex = 19;
            this.lFilhos.Text = "Filho:";
            // 
            // dgvFilhos
            // 
            this.dgvFilhos.AllowUserToAddRows = false;
            this.dgvFilhos.AllowUserToDeleteRows = false;
            this.dgvFilhos.AllowUserToOrderColumns = true;
            this.dgvFilhos.BackgroundColor = System.Drawing.Color.White;
            this.dgvFilhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilhos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvFilhos.Location = new System.Drawing.Point(17, 86);
            this.dgvFilhos.MultiSelect = false;
            this.dgvFilhos.Name = "dgvFilhos";
            this.dgvFilhos.ReadOnly = true;
            this.dgvFilhos.Size = new System.Drawing.Size(584, 117);
            this.dgvFilhos.TabIndex = 24;
            // 
            // panelFilhos
            // 
            this.panelFilhos.BackColor = System.Drawing.Color.White;
            this.panelFilhos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilhos.Controls.Add(this.dgvFilhos);
            this.panelFilhos.Controls.Add(this.lFilhos);
            this.panelFilhos.Controls.Add(this.txtNomeFilho);
            this.panelFilhos.Controls.Add(this.btnAddFilho);
            this.panelFilhos.Controls.Add(this.cbxSexoFilho);
            this.panelFilhos.Controls.Add(this.txtMasDataNascFilho);
            this.panelFilhos.Controls.Add(this.label1);
            this.panelFilhos.Controls.Add(this.label2);
            this.panelFilhos.Enabled = false;
            this.panelFilhos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFilhos.Location = new System.Drawing.Point(12, 296);
            this.panelFilhos.Name = "panelFilhos";
            this.panelFilhos.Size = new System.Drawing.Size(620, 221);
            this.panelFilhos.TabIndex = 49;
            // 
            // btnAddFilho
            // 
            this.btnAddFilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilho.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilho.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFilho.Image")));
            this.btnAddFilho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFilho.Location = new System.Drawing.Point(486, 58);
            this.btnAddFilho.Name = "btnAddFilho";
            this.btnAddFilho.Size = new System.Drawing.Size(115, 22);
            this.btnAddFilho.TabIndex = 3;
            this.btnAddFilho.Text = "    Adicionar";
            this.btnAddFilho.UseVisualStyleBackColor = true;
            this.btnAddFilho.Click += new System.EventHandler(this.btnAddFilho_Click);
            // 
            // frmCadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFilhos);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroPessoas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Pessoas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhos)).EndInit();
            this.panelFilhos.ResumeLayout(false);
            this.panelFilhos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtMasCep;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.MaskedTextBox txtMasCPF;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.MaskedTextBox txtMasBaseSalario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtMasDataNascFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFilhos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMasDataNascFilho;
        private System.Windows.Forms.ComboBox cbxSexoFilho;
        private System.Windows.Forms.Button btnAddFilho;
        private System.Windows.Forms.TextBox txtNomeFilho;
        private System.Windows.Forms.Label lFilhos;
        private System.Windows.Forms.Panel panelFilhos;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlExibirSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
    }
}

