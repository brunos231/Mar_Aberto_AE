namespace ProjetoAutoEscola
{
    partial class Calendario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.cmbCatego = new System.Windows.Forms.ComboBox();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lsbListaDeUsers = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(297, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 19);
            this.lblTitle.TabIndex = 60;
            this.lblTitle.Text = "Calendário";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vanessa",
            "Bruno",
            "Victor"});
            this.comboBox1.Location = new System.Drawing.Point(169, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(519, 24);
            this.comboBox1.TabIndex = 70;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(22, 62);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(47, 17);
            this.lblAluno.TabIndex = 69;
            this.lblAluno.Text = "Aluno:";
            // 
            // cmbCatego
            // 
            this.cmbCatego.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatego.FormattingEnabled = true;
            this.cmbCatego.Items.AddRange(new object[] {
            "Vanessa",
            "Bruno",
            "Victor"});
            this.cmbCatego.Location = new System.Drawing.Point(169, 99);
            this.cmbCatego.Name = "cmbCatego";
            this.cmbCatego.Size = new System.Drawing.Size(519, 24);
            this.cmbCatego.TabIndex = 72;
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateg.Location = new System.Drawing.Point(22, 102);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(71, 17);
            this.lblCateg.TabIndex = 71;
            this.lblCateg.Text = "Categoria:";
            // 
            // lsbListaDeUsers
            // 
            this.lsbListaDeUsers.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbListaDeUsers.FormattingEnabled = true;
            this.lsbListaDeUsers.ItemHeight = 16;
            this.lsbListaDeUsers.Items.AddRange(new object[] {
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "NOME DA PESSOA >> TA DEVENU??? DIA DE AULA >> PROF",
            "Vanessa",
            "Victor",
            "Alan Safadão",
            "Daynessa",
            "Kelly",
            "Larissa ",
            "Princess",
            "Gabriela ",
            "Cravo e Canela",
            "Brunão",
            "manão",
            "Bruno"});
            this.lsbListaDeUsers.Location = new System.Drawing.Point(16, 141);
            this.lsbListaDeUsers.Name = "lsbListaDeUsers";
            this.lsbListaDeUsers.Size = new System.Drawing.Size(672, 260);
            this.lsbListaDeUsers.TabIndex = 73;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(169, 424);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 29);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(339, 424);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 29);
            this.btnExcluir.TabIndex = 76;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(509, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 465);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lsbListaDeUsers);
            this.Controls.Add(this.cmbCatego);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.lblTitle);
            this.Name = "Calendario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Buscar Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.ComboBox cmbCatego;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.ListBox lsbListaDeUsers;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}