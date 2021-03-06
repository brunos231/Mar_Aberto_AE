﻿namespace ProjetoAutoEscola
{
    partial class AdicionarAluno
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mkbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mkbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mkbRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtLagradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.gbEndeResid = new System.Windows.Forms.GroupBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.cmbQuitadoStatus = new System.Windows.Forms.ComboBox();
            this.lblQuitadoStatus = new System.Windows.Forms.Label();
            this.cmbParcela = new System.Windows.Forms.ComboBox();
            this.lblParc = new System.Windows.Forms.Label();
            this.txtDescont = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.txtDefSenha = new System.Windows.Forms.TextBox();
            this.txtDefUser = new System.Windows.Forms.TextBox();
            this.cmbCategoriaAluno = new System.Windows.Forms.ComboBox();
            this.lblDefSenha = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDefUser = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mkbTelRec = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mkbTelCelRec = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.mkbTelCel = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mkbTelRes = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndeResid.SuspendLayout();
            this.gbDetalhes.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(540, 698);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(193, 698);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mkbDataNasc
            // 
            this.mkbDataNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbDataNasc.Location = new System.Drawing.Point(559, 89);
            this.mkbDataNasc.Mask = "00/00/0000";
            this.mkbDataNasc.Name = "mkbDataNasc";
            this.mkbDataNasc.Size = new System.Drawing.Size(114, 24);
            this.mkbDataNasc.TabIndex = 4;
            this.mkbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(307, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 19);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Adicionar Novo Aluno";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(417, 92);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(136, 17);
            this.lblDtNasc.TabIndex = 23;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(74, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 24);
            this.txtNome.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(361, 698);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(36, 92);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 17);
            this.lblCpf.TabIndex = 30;
            this.lblCpf.Text = "CPF:";
            // 
            // mkbCpf
            // 
            this.mkbCpf.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCpf.Location = new System.Drawing.Point(79, 89);
            this.mkbCpf.Mask = "000.000.000-00";
            this.mkbCpf.Name = "mkbCpf";
            this.mkbCpf.Size = new System.Drawing.Size(109, 24);
            this.mkbCpf.TabIndex = 2;
            // 
            // mkbRg
            // 
            this.mkbRg.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbRg.Location = new System.Drawing.Point(252, 89);
            this.mkbRg.Mask = "00.000.000-99";
            this.mkbRg.Name = "mkbRg";
            this.mkbRg.Size = new System.Drawing.Size(109, 24);
            this.mkbRg.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(215, 92);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 17);
            this.lblRG.TabIndex = 32;
            this.lblRG.Text = "RG:";
            // 
            // txtLagradouro
            // 
            this.txtLagradouro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLagradouro.Location = new System.Drawing.Point(100, 38);
            this.txtLagradouro.Name = "txtLagradouro";
            this.txtLagradouro.Size = new System.Drawing.Size(400, 24);
            this.txtLagradouro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Lagradouro:";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.label1);
            this.gbDadosPessoais.Controls.Add(this.txtMatricula);
            this.gbDadosPessoais.Controls.Add(this.txtNome);
            this.gbDadosPessoais.Controls.Add(this.lblNome);
            this.gbDadosPessoais.Controls.Add(this.mkbDataNasc);
            this.gbDadosPessoais.Controls.Add(this.mkbRg);
            this.gbDadosPessoais.Controls.Add(this.lblDtNasc);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblCpf);
            this.gbDadosPessoais.Controls.Add(this.mkbCpf);
            this.gbDadosPessoais.Location = new System.Drawing.Point(18, 41);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(760, 138);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(444, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nº Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(536, 45);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(137, 20);
            this.txtMatricula.TabIndex = 33;
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
            this.gbEndeResid.Location = new System.Drawing.Point(18, 182);
            this.gbEndeResid.Name = "gbEndeResid";
            this.gbEndeResid.Size = new System.Drawing.Size(760, 144);
            this.gbEndeResid.TabIndex = 2;
            this.gbEndeResid.TabStop = false;
            this.gbEndeResid.Text = "Endereço Residêncial";
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
            this.cmbUf.Location = new System.Drawing.Point(697, 82);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(57, 24);
            this.cmbUf.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(663, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "UF:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // mkbCep
            // 
            this.mkbCep.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCep.Location = new System.Drawing.Point(384, 82);
            this.mkbCep.Mask = "00000-000";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(81, 24);
            this.mkbCep.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(532, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(126, 24);
            this.txtBairro.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "CEP:";
            // 
            // txtCompl
            // 
            this.txtCompl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompl.Location = new System.Drawing.Point(264, 82);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(59, 24);
            this.txtCompl.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(79, 82);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 24);
            this.txtNumero.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Número:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(514, 41);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 17);
            this.lblCidade.TabIndex = 34;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(574, 38);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(184, 24);
            this.txtCidade.TabIndex = 6;
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.txtValor);
            this.gbDetalhes.Controls.Add(this.cmbQuitadoStatus);
            this.gbDetalhes.Controls.Add(this.lblQuitadoStatus);
            this.gbDetalhes.Controls.Add(this.cmbParcela);
            this.gbDetalhes.Controls.Add(this.lblParc);
            this.gbDetalhes.Controls.Add(this.txtDescont);
            this.gbDetalhes.Controls.Add(this.lblDesc);
            this.gbDetalhes.Controls.Add(this.lblVal);
            this.gbDetalhes.Controls.Add(this.cmbPagamento);
            this.gbDetalhes.Controls.Add(this.txtDefSenha);
            this.gbDetalhes.Controls.Add(this.txtDefUser);
            this.gbDetalhes.Controls.Add(this.cmbCategoriaAluno);
            this.gbDetalhes.Controls.Add(this.lblDefSenha);
            this.gbDetalhes.Controls.Add(this.lblCategoria);
            this.gbDetalhes.Controls.Add(this.label6);
            this.gbDetalhes.Controls.Add(this.lblDefUser);
            this.gbDetalhes.Controls.Add(this.lblPagamento);
            this.gbDetalhes.Location = new System.Drawing.Point(18, 503);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(760, 173);
            this.gbDetalhes.TabIndex = 21;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // cmbQuitadoStatus
            // 
            this.cmbQuitadoStatus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuitadoStatus.FormattingEnabled = true;
            this.cmbQuitadoStatus.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbQuitadoStatus.Location = new System.Drawing.Point(663, 58);
            this.cmbQuitadoStatus.Name = "cmbQuitadoStatus";
            this.cmbQuitadoStatus.Size = new System.Drawing.Size(70, 24);
            this.cmbQuitadoStatus.TabIndex = 25;
            // 
            // lblQuitadoStatus
            // 
            this.lblQuitadoStatus.AutoSize = true;
            this.lblQuitadoStatus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitadoStatus.Location = new System.Drawing.Point(597, 61);
            this.lblQuitadoStatus.Name = "lblQuitadoStatus";
            this.lblQuitadoStatus.Size = new System.Drawing.Size(60, 17);
            this.lblQuitadoStatus.TabIndex = 60;
            this.lblQuitadoStatus.Text = "Quitada:";
            // 
            // cmbParcela
            // 
            this.cmbParcela.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x"});
            this.cmbParcela.Location = new System.Drawing.Point(494, 58);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.Size = new System.Drawing.Size(70, 24);
            this.cmbParcela.TabIndex = 24;
            // 
            // lblParc
            // 
            this.lblParc.AutoSize = true;
            this.lblParc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParc.Location = new System.Drawing.Point(393, 61);
            this.lblParc.Name = "lblParc";
            this.lblParc.Size = new System.Drawing.Size(95, 17);
            this.lblParc.TabIndex = 58;
            this.lblParc.Text = "Parcelado em:";
            // 
            // txtDescont
            // 
            this.txtDescont.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescont.Location = new System.Drawing.Point(382, 22);
            this.txtDescont.Name = "txtDescont";
            this.txtDescont.Size = new System.Drawing.Size(121, 24);
            this.txtDescont.TabIndex = 22;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(272, 25);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(104, 17);
            this.lblDesc.TabIndex = 55;
            this.lblDesc.Text = "Valor desconto:";
            this.lblDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.Location = new System.Drawing.Point(25, 25);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(74, 17);
            this.lblVal.TabIndex = 55;
            this.lblVal.Text = "Valor total:";
            this.lblVal.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "A Vista",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Boleto Bancário",
            "Parcelado"});
            this.cmbPagamento.Location = new System.Drawing.Point(183, 62);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(175, 24);
            this.cmbPagamento.TabIndex = 23;
            this.cmbPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbPagamento_SelectedIndexChanged);
            // 
            // txtDefSenha
            // 
            this.txtDefSenha.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefSenha.Location = new System.Drawing.Point(526, 141);
            this.txtDefSenha.Name = "txtDefSenha";
            this.txtDefSenha.Size = new System.Drawing.Size(161, 24);
            this.txtDefSenha.TabIndex = 31;
            // 
            // txtDefUser
            // 
            this.txtDefUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefUser.Location = new System.Drawing.Point(184, 141);
            this.txtDefUser.Name = "txtDefUser";
            this.txtDefUser.Size = new System.Drawing.Size(174, 24);
            this.txtDefUser.TabIndex = 30;
            // 
            // cmbCategoriaAluno
            // 
            this.cmbCategoriaAluno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaAluno.FormattingEnabled = true;
            this.cmbCategoriaAluno.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "A e B",
            ""});
            this.cmbCategoriaAluno.Location = new System.Drawing.Point(184, 101);
            this.cmbCategoriaAluno.Name = "cmbCategoriaAluno";
            this.cmbCategoriaAluno.Size = new System.Drawing.Size(174, 24);
            this.cmbCategoriaAluno.TabIndex = 26;
            this.cmbCategoriaAluno.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaAluno_SelectedIndexChanged);
            // 
            // lblDefSenha
            // 
            this.lblDefSenha.AutoSize = true;
            this.lblDefSenha.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefSenha.Location = new System.Drawing.Point(437, 144);
            this.lblDefSenha.Name = "lblDefSenha";
            this.lblDefSenha.Size = new System.Drawing.Size(51, 17);
            this.lblDefSenha.TabIndex = 53;
            this.lblDefSenha.Text = "Senha:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(25, 101);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(71, 17);
            this.lblCategoria.TabIndex = 53;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-397, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Usuário:";
            // 
            // lblDefUser
            // 
            this.lblDefUser.AutoSize = true;
            this.lblDefUser.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefUser.Location = new System.Drawing.Point(25, 144);
            this.lblDefUser.Name = "lblDefUser";
            this.lblDefUser.Size = new System.Drawing.Size(58, 17);
            this.lblDefUser.TabIndex = 53;
            this.lblDefUser.Text = "Usuário:";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(25, 65);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(132, 17);
            this.lblPagamento.TabIndex = 53;
            this.lblPagamento.Text = "Tipo de Pagamento:";
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
            this.groupBox4.Location = new System.Drawing.Point(18, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 155);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contato";
            // 
            // mkbTelRec
            // 
            this.mkbTelRec.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelRec.Location = new System.Drawing.Point(177, 109);
            this.mkbTelRec.Mask = "(00) 0000-0000";
            this.mkbTelRec.Name = "mkbTelRec";
            this.mkbTelRec.Size = new System.Drawing.Size(122, 24);
            this.mkbTelRec.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(174, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "Telefone Residêncial Recado:";
            // 
            // mkbTelCelRec
            // 
            this.mkbTelCelRec.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelCelRec.Location = new System.Drawing.Point(552, 109);
            this.mkbTelCelRec.Mask = "(00) 00000-0000";
            this.mkbTelCelRec.Name = "mkbTelCelRec";
            this.mkbTelCelRec.Size = new System.Drawing.Size(122, 24);
            this.mkbTelCelRec.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(549, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 17);
            this.label18.TabIndex = 50;
            this.label18.Text = "Telefone Celular Recado:";
            // 
            // mkbTelCel
            // 
            this.mkbTelCel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelCel.Location = new System.Drawing.Point(385, 109);
            this.mkbTelCel.Mask = "(00) 00000-0000";
            this.mkbTelCel.Name = "mkbTelCel";
            this.mkbTelCel.Size = new System.Drawing.Size(122, 24);
            this.mkbTelCel.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(382, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 48;
            this.label17.Text = "Telefone Celular:";
            // 
            // mkbTelRes
            // 
            this.mkbTelRes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelRes.Location = new System.Drawing.Point(17, 109);
            this.mkbTelRes.Mask = "(00) 0000-0000";
            this.mkbTelRes.Name = "mkbTelRes";
            this.mkbTelRes.Size = new System.Drawing.Size(122, 24);
            this.mkbTelRes.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "Telefone Residêncial:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(127, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(564, 24);
            this.txtEmail.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(105, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 20);
            this.txtValor.TabIndex = 61;
            // 
            // AdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 741);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.gbEndeResid);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdicionarAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Adicionar Nova Aluno";
            this.Load += new System.EventHandler(this.AdicionarAluno_Load);
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndeResid.ResumeLayout(false);
            this.gbEndeResid.PerformLayout();
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mkbDataNasc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mkbCpf;
        private System.Windows.Forms.MaskedTextBox mkbRg;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtLagradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.GroupBox gbEndeResid;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mkbCep;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mkbTelCelRec;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox mkbTelCel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mkbTelRes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mkbTelRec;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbCategoriaAluno;
        private System.Windows.Forms.TextBox txtDefUser;
        private System.Windows.Forms.Label lblDefSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDefUser;
        private System.Windows.Forms.TextBox txtDefSenha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cmbQuitadoStatus;
        private System.Windows.Forms.Label lblQuitadoStatus;
        private System.Windows.Forms.ComboBox cmbParcela;
        private System.Windows.Forms.Label lblParc;
        private System.Windows.Forms.TextBox txtDescont;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtValor;
    }
}