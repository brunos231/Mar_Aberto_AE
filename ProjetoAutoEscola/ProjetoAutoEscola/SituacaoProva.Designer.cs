namespace ProjetoAutoEscola
{
    partial class SituacaoProva
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.cmbAluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.cmbCatego = new System.Windows.Forms.ComboBox();
            this.mkbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(268, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 19);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Situação da Prova";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.Location = new System.Drawing.Point(20, 102);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(71, 17);
            this.lblCateg.TabIndex = 65;
            this.lblCateg.Text = "Categoria:";
            this.lblCateg.Click += new System.EventHandler(this.lblPercurso_Click);
            // 
            // cmbAluno
            // 
            this.cmbAluno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAluno.FormattingEnabled = true;
            this.cmbAluno.Items.AddRange(new object[] {
            "Vanessa",
            "Bruno",
            "Victor"});
            this.cmbAluno.Location = new System.Drawing.Point(167, 62);
            this.cmbAluno.Name = "cmbAluno";
            this.cmbAluno.Size = new System.Drawing.Size(459, 24);
            this.cmbAluno.TabIndex = 68;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(20, 65);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(47, 17);
            this.lblAluno.TabIndex = 67;
            this.lblAluno.Text = "Aluno:";
            // 
            // cmbCatego
            // 
            this.cmbCatego.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatego.FormattingEnabled = true;
            this.cmbCatego.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "A e B"});
            this.cmbCatego.Location = new System.Drawing.Point(167, 99);
            this.cmbCatego.Name = "cmbCatego";
            this.cmbCatego.Size = new System.Drawing.Size(459, 24);
            this.cmbCatego.TabIndex = 68;
            // 
            // mkbDataNasc
            // 
            this.mkbDataNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbDataNasc.Location = new System.Drawing.Point(167, 138);
            this.mkbDataNasc.Mask = "00/00/0000";
            this.mkbDataNasc.Name = "mkbDataNasc";
            this.mkbDataNasc.Size = new System.Drawing.Size(100, 24);
            this.mkbDataNasc.TabIndex = 69;
            this.mkbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(20, 141);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(101, 17);
            this.lblDtNasc.TabIndex = 70;
            this.lblDtNasc.Text = "Data da prova:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 185);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(132, 17);
            this.lblStatus.TabIndex = 70;
            this.lblStatus.Text = "Resultado da Prova:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(407, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(155, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(283, 242);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 73;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cmbResult
            // 
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Aprovado",
            "Reprovado"});
            this.cmbResult.Location = new System.Drawing.Point(172, 183);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(111, 21);
            this.cmbResult.TabIndex = 75;
            // 
            // SituacaoProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 293);
            this.ControlBox = false;
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mkbDataNasc);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.cmbCatego);
            this.Controls.Add(this.cmbAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.lblTitle);
            this.Name = "SituacaoProva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Situação da Prova";
            this.Load += new System.EventHandler(this.SituacaoProva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ComboBox cmbAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cmbCatego;
        private System.Windows.Forms.MaskedTextBox mkbDataNasc;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbResult;
    }
}