using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Drawing.Imaging;

namespace TrilhaDesenvolvedor
{
    public partial class frmCadastroPessoas : Form
    {
        byte[] foto;
        Bitmap bmp;
        Pessoa pessoaOld;
        Pessoa pessoaNew;
        Filho filhoOld;
        Filho filhoNew;        
        Form pai;
        List<Filho> listFilho = new List<Filho>();        
        public frmCadastroPessoas(Form formPai)
        {
            pai = formPai;
            InitializeComponent();          

            pessoaOld = new Pessoa()
            {
                Nome = txtNome.Text.ToString(),
                Sobrenome = txtSobrenome.Text.ToString(),
                Sexo = cbxSexo.Text.ToString(),
                DataNascimento = Convert.ToDateTime(txtMasDataNascFunc.Text.ToString() == "  /  /" ? DateTime.Now.ToString("dd/MM/yyyy") : txtMasDataNascFunc.Text.ToString()),
                CPF = txtMasCPF.Text.ToString(),
                Email = txtEmail.Text.ToString(),
                Cep = txtMasCep.Text.ToString(),
                Endereco = txtEndereco.Text.ToString(),
                EndNumero = txtNumero.Text.ToString(),
                Categoria = cbxCategoria.Text.ToString(),
                SalarioBase = new Pessoa().ConvertSalario(txtMasBaseSalario.Text.ToString()),
                Bairro = txtBairro.Text.ToString(),
                Cidade = txtCidade.Text.ToString(),
                UF = cbxUF.Text.ToString(),
                Login = txtLogin.Text.ToString(),
                Senha = txtLogin.Text.ToString(),
                Imagem = foto
            };

            filhoOld = new Filho()
            {
                Nome = txtNomeFilho.Text.ToString(),
                DataNascimento = Convert.ToDateTime(txtMasDataNascFilho.Text.ToString() == "  /  /" ? DateTime.Now.ToString("dd/MM/yyyy") : txtMasDataNascFilho.Text.ToString()),                
                Sexo = cbxSexoFilho.Text.ToString()
            };     
        }
        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = $"http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtMasCep.Text);

                ds.ReadXml(xml);

                string logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString();
                string uf = ds.Tables[0].Rows[0]["uf"].ToString();
                string cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                string bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                string tipo_logradouro = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();

                txtEndereco.Text = $"{tipo_logradouro} {logradouro}, {bairro}, {cidade}-{uf}";

                txtEndereco.Text = logradouro;
                txtBairro.Text = bairro;
                txtCidade.Text = cidade;
                cbxUF.Text = uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possivel pesquisar!");
                throw;
            }
        }                
        private void btnAddFilho_Click(object sender, EventArgs e)
        {
            addFilhos();
        }
        private void addFilhos()
        {            
            dgvFilhos.DataSource = "";

            filhoNew = new Filho()
            {
                Nome = txtNomeFilho.Text.ToString(),
                DataNascimento = Convert.ToDateTime(txtMasDataNascFilho.Text.ToString() == "  /  /" ? DateTime.Now.ToString("dd/MM/yyyy") : txtMasDataNascFilho.Text.ToString()),                
                Sexo = cbxSexoFilho.Text.ToString()
            };

            if (filhoNew.PropriedadesNull(filhoOld))
            {
                DateTime dt = DateTime.ParseExact(txtMasDataNascFilho.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var dataNascimento = dt;
                var idade = DateTime.Now.Year - dataNascimento.Year;
                if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

                filhoNew.Idade = idade;

                listFilho.Add(filhoNew);
                dgvFilhos.DataSource = listFilho;
                configDataGridView();
                //new Sql().AddPessoa(pessoaNew);
            }
        }
        class dataGridFilhos
        {
            string nome, nascimento, idade, sexo, excluir;

            public string Nome { get => nome; set => nome = value; }
            public string Nascimento { get => nascimento; set => nascimento = value; }
            public string Idade { get => idade; set => idade = value; }
            public string Sexo { get => sexo; set => sexo = value; }
            public string Excluir { get => excluir; set => excluir = value; }
        }
        public void configDataGridView()
        {
            int contador = 0;
            foreach (var item in new Filho().GetType().GetProperties())
            {
                switch (item.Name)
                {
                    case "IdPai":
                        dgvFilhos.Columns[contador].Width = 200;
                        break;
                    case "Nome":
                        dgvFilhos.Columns[contador].Width = 200;
                        break;                        
                    case "DataNascimento":
                        dgvFilhos.Columns[contador].HeaderText = "Nascimento";
                        dgvFilhos.Columns[contador].Width = 80;
                        dgvFilhos.Columns[contador].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Idade":
                        dgvFilhos.Columns[contador].Width = 80;
                        dgvFilhos.Columns[contador].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Sexo":
                        dgvFilhos.Columns[contador].Width = 80;
                        dgvFilhos.Columns[contador].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Excluir":
                        dgvFilhos.Columns[contador].Width = 80;
                        dgvFilhos.Columns[contador].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;                    
                    default:
                        break;
                }
                //dgvFilhos.Columns[contador++].HeaderText = item;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtMasBaseSalario.ToString());

                pessoaNew = new Pessoa()
                {
                    Nome = txtNome.Text.ToString(),
                    Sobrenome = txtSobrenome.Text.ToString(),
                    Sexo = cbxSexo.Text.ToString(),
                    DataNascimento = Convert.ToDateTime(txtMasDataNascFunc.Text.ToString() == "  /  /" ? DateTime.Now.ToString("dd/MM/yyyy") : txtMasDataNascFunc.Text.ToString()),
                    CPF = txtMasCPF.Text.ToString(),
                    Email = txtEmail.Text.ToString(),
                    Cep = txtMasCep.Text.ToString(),
                    Endereco = txtEndereco.Text.ToString(),
                    EndNumero = txtNumero.Text.ToString(),
                    Categoria = cbxCategoria.Text.ToString(),
                    SalarioBase = new Pessoa().ConvertSalario(txtMasBaseSalario.Text.ToString()),
                    Bairro = txtBairro.Text.ToString(),
                    Cidade = txtCidade.Text.ToString(),
                    UF = cbxUF.Text.ToString(),
                    Filhos = filhosSimNao(),
                    Login = txtLogin.Text.ToString(),
                    Senha = txtSenha.Text.ToString(),
                    Imagem = foto
                };
            if (pessoaNew.PropriedadesNull(pessoaOld))
            {
                new Sql().AddPessoa(pessoaNew,listFilho);
            }           
        }
        //Image imag;        
        private void btnCarregar_Click(object sender, EventArgs e)
        {            
            ofdImagem.Filter = "Imagem (*.jpg *.jpeg *.png)|*.jpeg;*.jpg;*.png";

            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                //Exibir imagem no picBox
                string nome = ofdImagem.FileName;
                Console.WriteLine(nome);
                bmp = new Bitmap(nome);
                picBox.Image = bmp;

                //Salvar imagem
                MemoryStream memory = new MemoryStream();

                bmp.Save(memory, ImageFormat.Bmp);
                foto = memory.ToArray();
                Console.WriteLine(foto.Length);
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
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //txtSenha.Text = txtEmail.Text.ToString();
        }
        private void txtLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtLogin.Enabled)
            {
                txtLogin.Enabled = true;
            }
            else
            {
                txtLogin.Enabled = false;
            }
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Enabled)
            {
                txtLogin.Enabled = false;
            }
            else
            {
                txtLogin.Enabled = true;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = txtEmail.Text.ToString();
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            panelFilhos.Enabled = false;
        }
        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            panelFilhos.Enabled = true;
        }
        private bool filhosSimNao() 
        {
            if (rbSim.Checked)
            {
                return true;
            }else if (rbNao.Checked)
            {
                return false;
            }
            return false;
        }

        private void txtMasCPF_Leave(object sender, EventArgs e)
        {
            if (!ValidaCPF.IsCpf(String.Join("", System.Text.RegularExpressions.Regex.Split(txtMasCPF.ToString(), @"[^\d]")))) 
            {
                MessageBox.Show("CPF Invalido !");
                txtMasCPF.Text = "";
            }
        }
    }
}
