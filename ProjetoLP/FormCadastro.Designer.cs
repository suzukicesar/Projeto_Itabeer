namespace ProjetoLP
{
    partial class FormCadastro
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
            this.components = new System.ComponentModel.Container();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultarFilt = new System.Windows.Forms.Button();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbl_funcao = new System.Windows.Forms.Label();
            this.lbl_setor = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.trabalholpviiiDataSet1 = new ProjetoLP.TRABALHOLPVIIIDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalholpviiiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(417, 278);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 48);
            this.btnAlterar.TabIndex = 120;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 119;
            this.label2.Text = "Consultar";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(99, 355);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(312, 20);
            this.txtConsulta.TabIndex = 118;
            // 
            // btnConsultarFilt
            // 
            this.btnConsultarFilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFilt.Location = new System.Drawing.Point(545, 341);
            this.btnConsultarFilt.Name = "btnConsultarFilt";
            this.btnConsultarFilt.Size = new System.Drawing.Size(117, 48);
            this.btnConsultarFilt.TabIndex = 117;
            this.btnConsultarFilt.Text = "Consultar Filtrado";
            this.btnConsultarFilt.UseVisualStyleBackColor = true;
            this.btnConsultarFilt.Click += new System.EventHandler(this.btnConsultarFilt_Click);
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(610, 143);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(49, 20);
            this.txtUf.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 115;
            this.label1.Text = "UF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 201);
            this.dataGridView1.TabIndex = 114;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(417, 341);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 48);
            this.btnConsultar.TabIndex = 113;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(462, 213);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 48);
            this.btnSair.TabIndex = 112;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(103, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 48);
            this.btnLimpar.TabIndex = 111;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(281, 213);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 48);
            this.btnCadastrar.TabIndex = 110;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(425, 176);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(234, 20);
            this.txtFuncao.TabIndex = 109;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(103, 176);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(223, 20);
            this.txtSetor.TabIndex = 108;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(502, 81);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(157, 20);
            this.txtTelefone.TabIndex = 107;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(103, 143);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(444, 20);
            this.txtCidade.TabIndex = 106;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(610, 113);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(49, 20);
            this.txtNum.TabIndex = 105;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(103, 113);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(444, 20);
            this.txtEndereco.TabIndex = 104;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 103;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(502, 47);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(157, 20);
            this.txtCpf.TabIndex = 102;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 101;
            // 
            // lbl_funcao
            // 
            this.lbl_funcao.AutoSize = true;
            this.lbl_funcao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcao.Location = new System.Drawing.Point(357, 175);
            this.lbl_funcao.Name = "lbl_funcao";
            this.lbl_funcao.Size = new System.Drawing.Size(65, 21);
            this.lbl_funcao.TabIndex = 100;
            this.lbl_funcao.Text = "Função";
            // 
            // lbl_setor
            // 
            this.lbl_setor.AutoSize = true;
            this.lbl_setor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setor.Location = new System.Drawing.Point(43, 175);
            this.lbl_setor.Name = "lbl_setor";
            this.lbl_setor.Size = new System.Drawing.Size(50, 21);
            this.lbl_setor.TabIndex = 99;
            this.lbl_setor.Text = "Setor";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(419, 80);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(77, 21);
            this.lbl_telefone.TabIndex = 98;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(30, 142);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 21);
            this.lbl_cidade.TabIndex = 97;
            this.lbl_cidade.Text = "Cidade";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(568, 112);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(30, 21);
            this.lbl_numero.TabIndex = 96;
            this.lbl_numero.Text = "Nº";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(12, 112);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 21);
            this.lbl_endereco.TabIndex = 95;
            this.lbl_endereco.Text = "Endereço";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(34, 80);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 21);
            this.lbl_email.TabIndex = 94;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(458, 45);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(38, 21);
            this.lbl_cpf.TabIndex = 93;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(36, 46);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 21);
            this.lbl_name.TabIndex = 92;
            this.lbl_name.Text = "Nome";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(194, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(304, 23);
            this.lbl_titulo.TabIndex = 91;
            this.lbl_titulo.Text = "Cadastro de Funcionários Itabeer";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.Location = new System.Drawing.Point(99, 292);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(65, 21);
            this.lbl_cod.TabIndex = 121;
            this.lbl_cod.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(170, 293);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 20);
            this.txtCodigo.TabIndex = 122;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(545, 278);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 48);
            this.btnExcluir.TabIndex = 123;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // trabalholpviiiDataSet1
            // 
            this.trabalholpviiiDataSet1.DataSetName = "TRABALHOLPVIIIDataSet";
            this.trabalholpviiiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 608);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnConsultarFilt);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl_funcao);
            this.Controls.Add(this.lbl_setor);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalholpviiiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultarFilt;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbl_funcao;
        private System.Windows.Forms.Label lbl_setor;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private TRABALHOLPVIIIDataSet trabalholpviiiDataSet1;
        private System.Windows.Forms.Button btnExcluir;
    }
}