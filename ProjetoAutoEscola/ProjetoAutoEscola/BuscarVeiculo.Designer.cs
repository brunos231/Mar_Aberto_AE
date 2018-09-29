namespace ProjetoAutoEscola
{
    partial class BuscarVeiculo
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
            this.grbBusca = new System.Windows.Forms.GroupBox();
            this.lblDigite = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lsbListaDeUsers = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusca
            // 
            this.grbBusca.Controls.Add(this.lblDigite);
            this.grbBusca.Controls.Add(this.txtBuscar);
            this.grbBusca.Controls.Add(this.btnBuscar);
            this.grbBusca.Location = new System.Drawing.Point(27, 50);
            this.grbBusca.Name = "grbBusca";
            this.grbBusca.Size = new System.Drawing.Size(760, 82);
            this.grbBusca.TabIndex = 63;
            this.grbBusca.TabStop = false;
            this.grbBusca.Text = "Buscar Veiculo";
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
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(342, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 19);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Buscar Veículo";
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
            this.lsbListaDeUsers.Location = new System.Drawing.Point(10, 150);
            this.lsbListaDeUsers.Name = "lsbListaDeUsers";
            this.lsbListaDeUsers.Size = new System.Drawing.Size(798, 340);
            this.lsbListaDeUsers.TabIndex = 64;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(215, 507);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 29);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(385, 507);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 29);
            this.btnExcluir.TabIndex = 68;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(555, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BuscarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lsbListaDeUsers);
            this.Controls.Add(this.grbBusca);
            this.Controls.Add(this.lblTitle);
            this.Name = "BuscarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Buscar Veículo";
            this.grbBusca.ResumeLayout(false);
            this.grbBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusca;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lsbListaDeUsers;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}