using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrilhaDesenvolvedor
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void plExibirSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                txtSenha.PasswordChar = '•';
            }
            else
            {
                txtSenha.PasswordChar = '\0';
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            this.lblInvalido.Visible = false;
            this.txtEmail.ForeColor = Color.Black;
            if (this.txtEmail.Text == "Informe seu e-mail de acesso")
            {
                this.txtEmail.Text = "";
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
                this.txtEmail.Text = "Informe seu e-mail de acesso";

            if (this.txtEmail.Text == "" || this.txtEmail.Text == "Informe seu e-mail de acesso")
            {
                this.txtEmail.ForeColor = Color.DarkGray;
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            this.lblInvalido.Visible = false;
            this.txtSenha.ForeColor = Color.Black;
            this.txtSenha.PasswordChar = '•';
            if (this.txtSenha.Text == "Digite sua senha")
            {
                this.txtSenha.Text = "";
            }
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtSenha.Text))
            {
                this.txtSenha.Text = "Digite sua senha";
                this.txtSenha.PasswordChar = '\0';
            }
            else
            {
                this.txtSenha.PasswordChar = '•';
            }


            if (this.txtSenha.Text == "" || this.txtSenha.Text == "Digite sua senha")
            {
                this.txtSenha.ForeColor = Color.DarkGray;
            }
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //this.Close();
            //new frmCadastroPessoas(this).Show();

            Program.pessoaLogada = new Pessoa
            {
                //Sexo = "315831",
                //Login = "kleitofi@outlook.com",
                Senha = txtSenha.Text.ToString(),
                Login = txtEmail.Text.ToString()
            };

            if (new Sql().VerificaLogin(Program.pessoaLogada))
            {
                new Lancamentos().ShowDialog();
            }
            else
            {
                lblInvalido.Visible = true;
            }


        }
        private void pnlExibirSenha_Click(object sender, EventArgs e)
        {
            if (this.txtSenha.PasswordChar == '\0')
            {
                this.txtSenha.PasswordChar = '•';
            }
            else
            {
                this.txtSenha.PasswordChar = '\0';
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmCadastroPessoas(this).ShowDialog();
        }
    }
}
