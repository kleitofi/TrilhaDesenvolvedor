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
    public partial class Lancamentos : Form
    {
        public Lancamentos()
        {
            InitializeComponent();
            new Sql().ListPessoas(txtCbxPessoa);
        }

        private void Lancamentos_Load(object sender, EventArgs e)
        {

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Sql().ListPessoas(txtCbxPessoa,txtCbxCategoria.Text.ToString());
        }

        private void txtCbxPessoa_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }
    }
}
