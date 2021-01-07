namespace TrilhaDesenvolvedor
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblInvalido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.pnlExibirSenha = new System.Windows.Forms.Panel();
            this.plExibirSenha = new System.Windows.Forms.Panel();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.linkCadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersao.Location = new System.Drawing.Point(332, 400);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersao.Size = new System.Drawing.Size(153, 13);
            this.lblVersao.TabIndex = 26;
            this.lblVersao.Text = "Developed by Rubens Teixeira";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSenha.Location = new System.Drawing.Point(98, 238);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(299, 27);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.Text = "Digite sua senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(98, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 27);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "Informe seu e-mail de acesso";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblInvalido
            // 
            this.lblInvalido.AutoSize = true;
            this.lblInvalido.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalido.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblInvalido.Location = new System.Drawing.Point(160, 269);
            this.lblInvalido.Name = "lblInvalido";
            this.lblInvalido.Size = new System.Drawing.Size(182, 18);
            this.lblInvalido.TabIndex = 20;
            this.lblInvalido.Text = "Credenciais incorretas!";
            this.lblInvalido.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(99, 156);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 18);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(134, 41);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(228, 45);
            this.lblBemVindo.TabIndex = 21;
            this.lblBemVindo.Text = "Bem vindo!";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(99, 217);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 18);
            this.lblSenha.TabIndex = 19;
            this.lblSenha.Text = "Senha:";
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Gold;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcessar.Location = new System.Drawing.Point(142, 292);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(220, 50);
            this.btnAcessar.TabIndex = 27;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // pnlExibirSenha
            // 
            this.pnlExibirSenha.BackColor = System.Drawing.SystemColors.Window;
            this.pnlExibirSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlExibirSenha.BackgroundImage")));
            this.pnlExibirSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlExibirSenha.Location = new System.Drawing.Point(367, 242);
            this.pnlExibirSenha.Name = "pnlExibirSenha";
            this.pnlExibirSenha.Size = new System.Drawing.Size(27, 20);
            this.pnlExibirSenha.TabIndex = 28;
            this.pnlExibirSenha.Click += new System.EventHandler(this.pnlExibirSenha_Click);
            // 
            // plExibirSenha
            // 
            this.plExibirSenha.BackColor = System.Drawing.SystemColors.Window;
            this.plExibirSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plExibirSenha.BackgroundImage")));
            this.plExibirSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plExibirSenha.Location = new System.Drawing.Point(366, 244);
            this.plExibirSenha.Name = "plExibirSenha";
            this.plExibirSenha.Size = new System.Drawing.Size(27, 16);
            this.plExibirSenha.TabIndex = 18;
            this.plExibirSenha.Click += new System.EventHandler(this.plExibirSenha_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrar.Location = new System.Drawing.Point(114, 354);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(136, 18);
            this.lblCadastrar.TabIndex = 29;
            this.lblCadastrar.Text = "Não possui acesso?";
            // 
            // linkCadastrar
            // 
            this.linkCadastrar.AutoSize = true;
            this.linkCadastrar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.linkCadastrar.LinkColor = System.Drawing.Color.Black;
            this.linkCadastrar.Location = new System.Drawing.Point(253, 354);
            this.linkCadastrar.Name = "linkCadastrar";
            this.linkCadastrar.Size = new System.Drawing.Size(139, 18);
            this.linkCadastrar.TabIndex = 30;
            this.linkCadastrar.TabStop = true;
            this.linkCadastrar.Text = "Cadastre-se aqui.";
            this.linkCadastrar.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrar_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 422);
            this.Controls.Add(this.linkCadastrar);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.pnlExibirSenha);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblInvalido);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.plExibirSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Enter += new System.EventHandler(this.btnAcessar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel plExibirSenha;
        private System.Windows.Forms.Label lblInvalido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Panel pnlExibirSenha;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.LinkLabel linkCadastrar;
    }
}