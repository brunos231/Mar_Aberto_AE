namespace ProjetoAutoEscola
{
    partial class BuscarUsuario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbBusca = new System.Windows.Forms.GroupBox();
            this.rdbNomeRg = new System.Windows.Forms.RadioButton();
            this.rdbNomeUser = new System.Windows.Forms.RadioButton();
            this.rdbNomePessoa = new System.Windows.Forms.RadioButton();
            this.rdbNumeroMatricula = new System.Windows.Forms.RadioButton();
            this.lblDigite = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lsbListaDeUsers = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(646, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 29);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 19);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Buscar Usuário";
            // 
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.rdbNomeRg);
            this.grbBusca.Controls.Add(this.rdbNomeUser);
            this.grbBusca.Controls.Add(this.rdbNomePessoa);
            this.grbBusca.Controls.Add(this.rdbNumeroMatricula);
            this.grbBusca.Controls.Add(this.lblDigite);
            this.grbBusca.Controls.Add(this.txtBuscar);
            this.grbBusca.Controls.Add(this.btnBuscar);
            this.grbBusca.Location = new System.Drawing.Point(27, 54);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(760, 129);
            this.grbBusca.TabIndex = 61;
            this.grbBusca.TabStop = false;
            this.grbBusca.Text = "Buscar Usuário";
            // 
            // rdbNomeRg
            // 
            this.rdbNomeRg.AutoSize = true;
            this.rdbNomeRg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeRg.Location = new System.Drawing.Point(666, 85);
            this.rdbNomeRg.Name = "rdbNomeRg";
            this.rdbNomeRg.Size = new System.Drawing.Size(42, 20);
            this.rdbNomeRg.TabIndex = 58;
            this.rdbNomeRg.TabStop = true;
            this.rdbNomeRg.Text = "RG";
            this.rdbNomeRg.UseVisualStyleBackColor = true;
            // 
            // rdbNomeUser
            // 
            this.rdbNomeUser.AutoSize = true;
            this.rdbNomeUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeUser.Location = new System.Drawing.Point(232, 85);
            this.rdbNomeUser.Name = "rdbNomeUser";
            this.rdbNomeUser.Size = new System.Drawing.Size(124, 20);
            this.rdbNomeUser.TabIndex = 37;
            this.rdbNomeUser.TabStop = true;
            this.rdbNomeUser.Text = "Nome de Usuário";
            this.rdbNomeUser.UseVisualStyleBackColor = true;
            // 
            // rdbNomePessoa
            // 
            this.rdbNomePessoa.AutoSize = true;
            this.rdbNomePessoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomePessoa.Location = new System.Drawing.Point(45, 85);
            this.rdbNomePessoa.Name = "rdbNomePessoa";
            this.rdbNomePessoa.Size = new System.Drawing.Size(121, 20);
            this.rdbNomePessoa.TabIndex = 37;
            this.rdbNomePessoa.TabStop = true;
            this.rdbNomePessoa.Text = "Nome de Pessoa";
            this.rdbNomePessoa.UseVisualStyleBackColor = true;
            // 
            // rdbNumeroMatricula
            // 
            this.rdbNumeroMatricula.AutoSize = true;
            this.rdbNumeroMatricula.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNumeroMatricula.Location = new System.Drawing.Point(465, 85);
            this.rdbNumeroMatricula.Name = "rdbNumeroMatricula";
            this.rdbNumeroMatricula.Size = new System.Drawing.Size(115, 20);
            this.rdbNumeroMatricula.TabIndex = 36;
            this.rdbNumeroMatricula.TabStop = true;
            this.rdbNumeroMatricula.Text = "Nº de matricula";
            this.rdbNumeroMatricula.UseVisualStyleBackColor = true;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigite.Location = new System.Drawing.Point(15, 42);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(58, 17);
            this.lblDigite.TabIndex = 34;
            this.lblDigite.Text = "Usuário:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(76, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(564, 24);
            this.txtBuscar.TabIndex = 35;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
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
            this.lsbListaDeUsers.Location = new System.Drawing.Point(12, 202);
            this.lsbListaDeUsers.Name = "lsbListaDeUsers";
            this.lsbListaDeUsers.Size = new System.Drawing.Size(793, 340);
            this.lsbListaDeUsers.TabIndex = 62;
            this.lsbListaDeUsers.SelectedIndexChanged += new System.EventHandler(this.lsbListaDeUsers_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(546, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(206, 564);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 29);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(376, 564);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 29);
            this.btnExcluir.TabIndex = 65;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 605);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lsbListaDeUsers);
            this.Controls.Add(this.grbBusca);
            this.Controls.Add(this.lblTitle);
            this.Name = "BuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Buscar Usuário";
            this.grbBusca.ResumeLayout(false);
            this.grbBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbBusca;
        private System.Windows.Forms.RadioButton rdbNomePessoa;
        private System.Windows.Forms.RadioButton rdbNumeroMatricula;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox lsbListaDeUsers;
        private System.Windows.Forms.RadioButton rdbNomeRg;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdbNomeUser;

    }
}