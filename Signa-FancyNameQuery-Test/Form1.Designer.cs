namespace Signa_FancyNameQuery_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposedlistView1 otherwise, false.</param>
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listPessoas = new System.Windows.Forms.ListView();
            this.colunaId = new System.Windows.Forms.ColumnHeader();
            this.colunaNome = new System.Windows.Forms.ColumnHeader();
            this.colunaCpf = new System.Windows.Forms.ColumnHeader();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMontarLista = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCpfCnpjPessoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnSalvarAlteracoes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listPessoas);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnMontarLista);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta de Nome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listPessoas
            // 
            this.listPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.listPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNome,
            this.colunaCpf});
            this.listPessoas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPessoas.ForeColor = System.Drawing.Color.White;
            this.listPessoas.Location = new System.Drawing.Point(3, 18);
            this.listPessoas.Name = "listPessoas";
            this.listPessoas.Size = new System.Drawing.Size(520, 244);
            this.listPessoas.TabIndex = 26;
            this.listPessoas.UseCompatibleStateImageBehavior = false;
            this.listPessoas.View = System.Windows.Forms.View.Details;
            this.listPessoas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listPessoas_ItemSelectionChanged);
            // 
            // colunaId
            // 
            this.colunaId.DisplayIndex = 1;
            this.colunaId.Text = "Código";
            this.colunaId.Width = 120;
            // 
            // colunaNome
            // 
            this.colunaNome.DisplayIndex = 2;
            this.colunaNome.Text = "Nome Fantasia";
            this.colunaNome.Width = 155;
            // 
            // colunaCpf
            // 
            this.colunaCpf.DisplayIndex = 0;
            this.colunaCpf.Text = "CPF/CNPJ";
            this.colunaCpf.Width = 180;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(93, 317);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(308, 43);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMontarLista
            // 
            this.btnMontarLista.Location = new System.Drawing.Point(93, 268);
            this.btnMontarLista.Name = "btnMontarLista";
            this.btnMontarLista.Size = new System.Drawing.Size(308, 43);
            this.btnMontarLista.TabIndex = 0;
            this.btnMontarLista.Text = "Montar Lista";
            this.btnMontarLista.UseVisualStyleBackColor = true;
            this.btnMontarLista.Click += new System.EventHandler(this.btnMontarLista_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalvarAlteracoes);
            this.tabPage2.Controls.Add(this.txtCpfCnpjPessoa);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNomePessoa);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCodigoPessoa);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCpfCnpjPessoa
            // 
            this.txtCpfCnpjPessoa.Enabled = false;
            this.txtCpfCnpjPessoa.Location = new System.Drawing.Point(65, 202);
            this.txtCpfCnpjPessoa.Name = "txtCpfCnpjPessoa";
            this.txtCpfCnpjPessoa.ReadOnly = true;
            this.txtCpfCnpjPessoa.Size = new System.Drawing.Size(352, 23);
            this.txtCpfCnpjPessoa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ/CPF";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(271, 109);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(146, 23);
            this.txtNomePessoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCodigoPessoa
            // 
            this.txtCodigoPessoa.Enabled = false;
            this.txtCodigoPessoa.Location = new System.Drawing.Point(65, 109);
            this.txtCodigoPessoa.Name = "txtCodigoPessoa";
            this.txtCodigoPessoa.ReadOnly = true;
            this.txtCodigoPessoa.Size = new System.Drawing.Size(146, 23);
            this.txtCodigoPessoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(65, 263);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(352, 46);
            this.btnSalvarAlteracoes.TabIndex = 6;
            this.btnSalvarAlteracoes.Text = "Gravar";
            this.btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoes.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Signa Consulta Nome Fantasia - Teste Prático";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView listPessoas;
        private Button btnLimpar;
        private Button btnMontarLista;
        private TabPage tabPage2;
        private ColumnHeader colunaCpf;
        private ColumnHeader columnHeader2;
        private ColumnHeader colunaId;
        private ColumnHeader colunaNome;
        private TextBox txtCodigoPessoa;
        private Label label1;
        private TextBox txtCpfCnpjPessoa;
        private Label label3;
        private TextBox txtNomePessoa;
        private Label label2;
        private Button btnSalvarAlteracoes;
    }
}