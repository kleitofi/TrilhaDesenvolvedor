using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrilhaDesenvolvedor
{
    public class Filho
    {
        public int IdPai { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public bool PropriedadesNull(Filho f)
        {
            string Propriedades = "";
            if (this.Nome == f.Nome)
            {
                Propriedades += "•Nome" + "\n";
            }
            if (this.DataNascimento == f.DataNascimento)
            {
                Propriedades += "•Data Nascimento" + "\n";
            }
            if (this.Sexo == f.Sexo)
            {
                Propriedades += "•Sexo" + "\n";
            }
            if (Propriedades == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Por favor, Preencher os campos (Filhos):\n{Propriedades}", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public void ListPropriedades(object obj)
        {
            foreach (var item in obj.GetType().GetProperties())
            {
                Console.WriteLine(item.Name + " | " + item.GetValue(obj));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Filho f = (Filho)obj;
                if (this.Nome == f.Nome &&                    
                    this.Sexo == f.Sexo &&
                    this.DataNascimento == f.DataNascimento) 
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
