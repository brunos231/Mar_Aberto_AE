namespace ProjetoAutoEscola
{
    partial class AdicionarFuncionario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbProfissaoFunc = new System.Windows.Forms.ComboBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.mkbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtLagradouro = new System.Windows.Forms.TextBox();
            this.lblProfissaoFunc = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtDefSenha = new System.Windows.Forms.TextBox();
            this.gbEndeResid = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mkbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDefUser = new System.Windows.Forms.TextBox();
            this.lblDefSenha = new System.Windows.Forms.Label();
            this.mkbTelRec = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mkbTelCelRec = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mkbTelCel = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelRes = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDefUser = new System.Windows.Forms.Label();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.gbEndeResid.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(85, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(609, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(292, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 19);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Adicionar Novo Funcionário";
            // 
            // cmbProfissaoFunc
            // 
            this.cmbProfissaoFunc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfissaoFunc.FormattingEnabled = true;
            this.cmbProfissaoFunc.Items.AddRange(new object[] {
            "Recepcionista",
            "Funcionário"});
            this.cmbProfissaoFunc.Location = new System.Drawing.Point(183, 31);
            this.cmbProfissaoFunc.Name = "cmbProfissaoFunc";
            this.cmbProfissaoFunc.Size = new System.Drawing.Size(175, 24);
            this.cmbProfissaoFunc.TabIndex = 21;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(428, 97);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(136, 17);
            this.lblDtNasc.TabIndex = 23;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // mkbRg
            // 
            this.mkbRg.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbRg.Location = new System.Drawing.Point(263, 94);
            this.mkbRg.Mask = "00.000.000-99";
            this.mkbRg.Name = "mkbRg";
            this.mkbRg.Size = new System.Drawing.Size(109, 24);
            this.mkbRg.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(226, 97);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 17);
            this.lblRG.TabIndex = 32;
            this.lblRG.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Complemento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lagradouro:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(25, 97);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 17);
            this.lblCpf.TabIndex = 30;
            this.lblCpf.Text = "CPF:";
            // 
            // mkbCpf
            // 
            this.mkbCpf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCpf.Location = new System.Drawing.Point(68, 94);
            this.mkbCpf.Mask = "000.000.000-00";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(109, 24);
            this.mkbCpf.TabIndex = 2;
            // 
            // txtLagradouro
            // 
            this.txtLagradouro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagradouro.Location = new System.Drawing.Point(93, 41);
            this.txtLagradouro.Name = "txtLagradouro";
            this.txtLagradouro.Size = new System.Drawing.Size(400, 24);
            this.txtLagradouro.TabIndex = 5;
            // 
            // lblProfissaoFunc
            // 
            this.lblProfissaoFunc.AutoSize = true;
            this.lblProfissaoFunc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfissaoFunc.Location = new System.Drawing.Point(25, 33);
            this.lblProfissaoFunc.Name = "lblProfissaoFunc";
            this.lblProfissaoFunc.Size = new System.Drawing.Size(50, 17);
            this.lblProfissaoFunc.TabIndex = 62;
            this.lblProfissaoFunc.Text = "Cargo:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(170, 641);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(660, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "UF:";
            // 
            // mkbCep
            // 
            this.mkbCep.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCep.Location = new System.Drawing.Point(381, 90);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(81, 24);
            this.mkbCep.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(529, 90);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(126, 24);
            this.txtBairro.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "CEP:";
            // 
            // txtCompl
            // 
            this.txtCompl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompl.Location = new System.Drawing.Point(261, 90);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(59, 24);
            this.txtCompl.TabIndex = 8;
            // 
            // cmbUf
            // 
            this.cmbUf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "",
            "SP",
            "RJ",
            "ALSJASD",
            "ASD",
            "AS",
            "DAS",
            "ASD",
            "AS",
            "D",
            "ASD",
            "AS",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(694, 90);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(57, 24);
            this.cmbUf.TabIndex = 11;
            // 
            // txtDefSenha
            // 
            this.txtDefSenha.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefSenha.Location = new System.Drawing.Point(526, 68);
            this.txtDefSenha.Name = "txtDefSenha";
            this.txtDefSenha.Size = new System.Drawing.Size(161, 24);
            this.txtDefSenha.TabIndex = 31;
            // 
            // gbEndeResid
            // 
            this.gbEndeResid.Controls.Add(this.cmbUf);
            this.gbEndeResid.Controls.Add(this.label10);
            this.gbEndeResid.Controls.Add(this.mkbCep);
            this.gbEndeResid.Controls.Add(this.txtBairro);
            this.gbEndeResid.Controls.Add(this.label9);
            this.gbEndeResid.Controls.Add(this.label8);
            this.gbEndeResid.Controls.Add(this.txtCompl);
            this.gbEndeResid.Controls.Add(this.txtNumero);
            this.gbEndeResid.Controls.Add(this.label7);
            this.gbEndeResid.Controls.Add(this.label5);
            this.gbEndeResid.Controls.Add(this.lblCidade);
            this.gbEndeResid.Controls.Add(this.label3);
            this.gbEndeResid.Controls.Add(this.txtCidade);
            this.gbEndeResid.Controls.Add(this.txtLagradouro);
            this.gbEndeResid.Location = new System.Drawing.Point(10, 180);
            this.gbEndeResid.Name = "gbEndeResid";
            this.gbEndeResid.Size = new System.Drawing.Size(760, 144);
            this.gbEndeResid.TabIndex = 65;
            this.gbEndeResid.TabStop = false;
            this.gbEndeResid.Text = "Endereço Residêncial";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(76, 90);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 24);
            this.txtNumero.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Número:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(507, 44);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 17);
            this.lblCidade.TabIndex = 34;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(567, 41);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(184, 24);
            this.txtCidade.TabIndex = 6;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Controls.Add(this.mkbDataNasc);
            this.gbDadosPessoais.Controls.Add(this.mkbRg);
            this.gbDadosPessoais.Controls.Add(this.lblDtNasc);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.mkbCpf);
            this.gbDadosPessoais.Location = new System.Drawing.Point(10, 39);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(760, 138);
            this.gbDadosPessoais.TabIndex = 64;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome:";
            // 
            // mkbDataNasc
            // 
            this.mkbDataNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbDataNasc.Location = new System.Drawing.Point(570, 94);
            this.mkbDataNasc.Mask = "00/00/0000";
            this.mkbDataNasc.Name = "mkbDataNasc";
            this.mkbDataNasc.Size = new System.Drawing.Size(100, 24);
            this.mkbDataNasc.TabIndex = 4;
            this.mkbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(338, 641);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 70;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtDefUser
            // 
            this.txtDefUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefUser.Location = new System.Drawing.Point(184, 68);
            this.txtDefUser.Name = "txtDefUser";
            this.txtDefUser.Size = new System.Drawing.Size(174, 24);
            this.txtDefUser.TabIndex = 30;
            // 
            // lblDefSenha
            // 
            this.lblDefSenha.AutoSize = true;
            this.lblDefSenha.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefSenha.Location = new System.Drawing.Point(437, 71);
            this.lblDefSenha.Name = "lblDefSenha";
            this.lblDefSenha.Size = new System.Drawing.Size(51, 17);
            this.lblDefSenha.TabIndex = 53;
            this.lblDefSenha.Text = "Senha:";
            // 
            // mkbTelRec
            // 
            this.mkbTelRec.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelRec.Location = new System.Drawing.Point(188, 114);
            this.mkbTelRec.Mask = "(00) 0000-0000";
            this.mkbTelRec.Name = "mkbTelRec";
            this.mkbTelRec.Size = new System.Drawing.Size(122, 24);
            this.mkbTelRec.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(185, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "Telefone Residêncial Recado:";
            // 
            // mkbTelCelRec
            // 
            this.mkbTelCelRec.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelCelRec.Location = new System.Drawing.Point(563, 114);
            this.mkbTelCelRec.Mask = "(00) 00000-0000";
            this.mkbTelCelRec.Name = "mkbTelCelRec";
            this.mkbTelCelRec.Size = new System.Drawing.Size(122, 24);
            this.mkbTelCelRec.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(560, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 17);
            this.label18.TabIndex = 50;
            this.label18.Text = "Telefone Celular Recado:";
            // 
            // mkbTelCel
            // 
            this.mkbTelCel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelCel.Location = new System.Drawing.Point(396, 114);
            this.mkbTelCel.Mask = "(00) 00000-0000";
            this.mkbTelCel.Name = "mkbTelCel";
            this.mkbTelCel.Size = new System.Drawing.Size(122, 24);
            this.mkbTelCel.TabIndex = 15;
            // 
            // mkbTelRes
            // 
            this.mkbTelRes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelRes.Location = new System.Drawing.Point(28, 114);
            this.mkbTelRes.Mask = "(00) 0000-0000";
            this.mkbTelRes.Name = "mkbTelRes";
            this.mkbTelRes.Size = new System.Drawing.Size(122, 24);
            this.mkbTelRes.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(393, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 48;
            this.label17.Text = "Telefone Celular:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(25, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "Telefone Residêncial:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "E-mail:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mkbTelRec);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.mkbTelCelRec);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.mkbTelCel);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.mkbTelRes);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Location = new System.Drawing.Point(10, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 155);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(564, 24);
            this.txtEmail.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(517, 641);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-386, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Usuário:";
            // 
            // lblDefUser
            // 
            this.lblDefUser.AutoSize = true;
            this.lblDefUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefUser.Location = new System.Drawing.Point(25, 71);
            this.lblDefUser.Name = "lblDefUser";
            this.lblDefUser.Size = new System.Drawing.Size(58, 17);
            this.lblDefUser.TabIndex = 53;
            this.lblDefUser.Text = "Usuário:";
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.cmbProfissaoFunc);
            this.gbDetalhes.Controls.Add(this.lblProfissaoFunc);
            this.gbDetalhes.Controls.Add(this.txtDefSenha);
            this.gbDetalhes.Controls.Add(this.txtDefUser);
            this.gbDetalhes.Controls.Add(this.lblDefSenha);
            this.gbDetalhes.Controls.Add(this.label6);
            this.gbDetalhes.Controls.Add(this.lblDefUser);
            this.gbDetalhes.Location = new System.Drawing.Point(10, 501);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(760, 113);
            this.gbDetalhes.TabIndex = 68;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // AdicionarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 676);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbEndeResid);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbDetalhes);
            this.Name = "AdicionarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Adicionar Novo Funcionário";
            this.gbEndeResid.ResumeLayout(false);
            this.gbEndeResid.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbProfissaoFunc;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.MaskedTextBox mkbRg;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.TextBox txtLagradouro;
        private System.Windows.Forms.Label lblProfissaoFunc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.TextBox txtDefSenha;
        private System.Windows.Forms.GroupBox gbEndeResid;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mkbDataNasc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtDefUser;
        private System.Windows.Forms.Label lblDefSenha;
        private System.Windows.Forms.MaskedTextBox mkbTelRec;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mkbTelCelRec;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mkbTelCel;
        private System.Windows.Forms.MaskedTextBox mkbTelRes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDefUser;
        private System.Windows.Forms.GroupBox gbDetalhes;
    }
}