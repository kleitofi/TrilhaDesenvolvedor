using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrilhaDesenvolvedor
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }       
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string EndNumero { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Categoria { get; set; }
        public double SalarioBase { get; set; }
        public byte[] Imagem { get; set; }
        public bool Filhos { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public double ConvertSalario(string Valor)
        {
            var Salario = String.Join("", System.Text.RegularExpressions.Regex.Split(Valor, @"[^\d]"));
            return Convert.ToDouble(Salario == "" ? "0" : String.Join("", System.Text.RegularExpressions.Regex.Split(Valor, @"[^\d]")));                        
        }
        public void ListPropriedades(object obj) 
        {
            foreach (var item in obj.GetType().GetProperties())
            {
                Console.WriteLine(item.Name + " | " + item.GetValue(obj));
            }
        }
        public bool PropriedadesNull(Pessoa p)
        {
            string Propriedades = "";
            if (this.Nome == p.Nome)
            {
                Propriedades += "•Nome" + "\n";
            }
            if (this.Sobrenome == p.Sobrenome)
            {
                Propriedades += "•Sobrenome" + "\n";
            }
            if (this.Sexo == p.Sexo)
            {
                Propriedades += "•Sexo" + "\n";
            }
            if (this.DataNascimento == p.DataNascimento)
            {
                Propriedades += "•Data Nascimento" + "\n";
            }
            if (this.CPF == p.CPF)
            {
                Propriedades += "•CPF" + "\n";
            }
            if (this.Email == p.Email)
            {
                Propriedades += "•Email" + "\n";
            }
            if (this.Cep == p.Cep)
            {
                Propriedades += "•Cep" + "\n";
            }
            if (this.Endereco == p.Endereco)
            {
                Propriedades += "•Endereço" + "\n";
            }
            if (this.EndNumero == p.EndNumero)
            {
                Propriedades += "•Numero Endereço" + "\n";
            }
            if (this.Bairro == p.Bairro)
            {
                Propriedades += "•Bairro" + "\n";
            }
            if (this.UF == p.UF)
            {
                Propriedades += "•UF" + "\n";
            }
            if (this.Cidade == p.Cidade)
            {
                Propriedades += "•Cidade" + "\n";
            }
            if (this.Categoria == p.Categoria)
            {
                Propriedades += "•Categoria" + "\n";
            }
            if (this.SalarioBase == p.SalarioBase)
            {
                Propriedades += "•Salário Base" + "\n";
            }
            if (this.Imagem == p.Imagem)
            {
                Propriedades += "•Foto" + "\n";
            }
            if (this.Login == p.Login)
            {
                Propriedades += "•Login" + "\n";
            }
            if (this.Senha == p.Senha)
            {
                Propriedades += "•Senha" + "\n";
            }
            if (Propriedades == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Por favor, Preencher os campos:\n{Propriedades}", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }            
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else 
            {
                Pessoa p = (Pessoa)obj;
                if (this.Nome == p.Nome &&
                    this.Sobrenome == p.Sobrenome &&
                    this.Sexo == p.Sexo &&
                    this.DataNascimento == p.DataNascimento &&
                    this.CPF == p.CPF &&
                    this.Email == p.Email &&
                    this.Cep == p.Cep &&
                    this.Endereco == p.Endereco &&
                    this.EndNumero == p.EndNumero &&
                    this.Bairro == p.Bairro &&
                    this.UF == p.UF &&
                    this.Cidade == p.Cidade &&
                    this.Categoria == p.Categoria &&
                    this.SalarioBase == p.SalarioBase)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }            
        }
    }
}
