namespace TrilhaDesenvolvedor
{
    partial class Lancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamentos));
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCbxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCbxPessoa = new System.Windows.Forms.ComboBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtMasBaseSalario = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalVendas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFilho = new System.Windows.Forms.Button();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.txtMasDataNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(250, 39);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(70, 14);
            this.lblCategoria.TabIndex = 17;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCbxCategoria
            // 
            this.txtCbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCbxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCbxCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCbxCategoria.FormattingEnabled = true;
            this.txtCbxCategoria.Items.AddRange(new object[] {
            "Advogados",
            "Cozinheiros",
            "Vendedores"});
            this.txtCbxCategoria.Location = new System.Drawing.Point(253, 58);
            this.txtCbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCbxCategoria.Name = "txtCbxCategoria";
            this.txtCbxCategoria.Size = new System.Drawing.Size(105, 22);
            this.txtCbxCategoria.TabIndex = 16;
            this.txtCbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pessoa:";
            // 
            // txtCbxPessoa
            // 
            this.txtCbxPessoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCbxPessoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCbxPessoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCbxPessoa.FormattingEnabled = true;
            this.txtCbxPessoa.Items.AddRange(new object[] {
            "Advogados",
            "Cozinheiros",
            "Vendedores"});
            this.txtCbxPessoa.Location = new System.Drawing.Point(109, 58);
            this.txtCbxPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCbxPessoa.Name = "txtCbxPessoa";
            this.txtCbxPessoa.Size = new System.Drawing.Size(136, 22);
            this.txtCbxPessoa.TabIndex = 18;
            this.txtCbxPessoa.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.txtCbxPessoa_QueryAccessibilityHelp);
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(362, 39);
            this.lblSalarioBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(84, 14);
            this.lblSalarioBase.TabIndex = 21;
            this.lblSalarioBase.Text = "Salário Base:";
            // 
            // txtMasBaseSalario
            // 
            this.txtMasBaseSalario.Enabled = false;
            this.txtMasBaseSalario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasBaseSalario.Location = new System.Drawing.Point(365, 58);
            this.txtMasBaseSalario.Mask = "$ 9,999.00";
            this.txtMasBaseSalario.Name = "txtMasBaseSalario";
            this.txtMasBaseSalario.Size = new System.Drawing.Size(94, 22);
            this.txtMasBaseSalario.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(102, 91);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 14);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Quantidade:";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(105, 111);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(80, 22);
            this.txtQuant.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(17, 111);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(80, 22);
            this.txtTipo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Vendas:";
            // 
            // txtTotalVendas
            // 
            this.txtTotalVendas.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendas.Location = new System.Drawing.Point(193, 111);
            this.txtTotalVendas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalVendas.Name = "txtTotalVendas";
            this.txtTotalVendas.Size = new System.Drawing.Size(90, 22);
            this.txtTotalVendas.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 184);
            this.dataGridView1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMasDataNascFunc);
            this.panel1.Controls.Add(this.txtCbxPessoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblExemplo);
            this.panel1.Controls.Add(this.btnAddFilho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.txtTotalVendas);
            this.panel1.Controls.Add(this.txtCbxCategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.txtMasBaseSalario);
            this.panel1.Controls.Add(this.lblSalarioBase);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 354);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 29);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Lançamentos";
            // 
            // btnAddFilho
            // 
            this.btnAddFilho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilho.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilho.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFilho.Image")));
            this.btnAddFilho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFilho.Location = new System.Drawing.Point(344, 110);
            this.btnAddFilho.Name = "btnAddFilho";
            this.btnAddFilho.Size = new System.Drawing.Size(115, 22);
            this.btnAddFilho.TabIndex = 29;
            this.btnAddFilho.Text = "    Adicionar";
            this.btnAddFilho.UseVisualStyleBackColor = true;
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplo.Location = new System.Drawing.Point(14, 138);
            this.lblExemplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(445, 13);
            this.lblExemplo.TabIndex = 30;
            this.lblExemplo.Text = "Ex: Vendedor: Dias:[Quantidade] x 8 x [Salário Base] + (5% x Total de vendas) = [" +
    "Salário]";
            // 
            // txtMasDataNascFunc
            // 
            this.txtMasDataNascFunc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasDataNascFunc.Location = new System.Drawing.Point(17, 58);
            this.txtMasDataNascFunc.Mask = "00/00/0000";
            this.txtMasDataNascFunc.Name = "txtMasDataNascFunc";
            this.txtMasDataNascFunc.Size = new System.Drawing.Size(85, 22);
            this.txtMasDataNascFunc.TabIndex = 31;
            this.txtMasDataNascFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMasDataNascFunc.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data:";
            // 
            // Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lancamentos";
            this.Load += new System.EventHandler(this.Lancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox txtCbxCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCbxPessoa;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.MaskedTextBox txtMasBaseSalario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalVendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFilho;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.MaskedTextBox txtMasDataNascFunc;
        private System.Windows.Forms.Label label6;
    }
}