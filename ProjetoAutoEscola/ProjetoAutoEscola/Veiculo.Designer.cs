namespace ProjetoAutoEscola
{
    partial class Veiculo
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adicionar Novo Veículo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(381, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(134, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(257, 327);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 55;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.AutoSize = true;
            this.btnMarca.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Location = new System.Drawing.Point(45, 120);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(115, 17);
            this.btnMarca.TabIndex = 57;
            this.btnMarca.Text = "Marca do Veículo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(45, 225);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(103, 17);
            this.lblAno.TabIndex = 58;
            this.lblAno.Text = "Ano do Veículo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(45, 261);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(110, 17);
            this.lblPlaca.TabIndex = 59;
            this.lblPlaca.Text = "Placa do Veículo:";
            this.lblPlaca.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(45, 154);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(101, 17);
            this.lblCor.TabIndex = 60;
            this.lblCor.Text = "Cor do Veículo:";
            this.lblCor.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(178, 222);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(134, 24);
            this.txtAno.TabIndex = 61;
            this.txtAno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(178, 258);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(134, 24);
            this.txtPlaca.TabIndex = 62;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(178, 151);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(248, 24);
            this.txtCor.TabIndex = 63;
            this.txtCor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(178, 117);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 24);
            this.txtMarca.TabIndex = 64;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(178, 82);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(248, 24);
            this.txtTipo.TabIndex = 68;
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.AutoSize = true;
            this.lblTipoVeiculo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVeiculo.Location = new System.Drawing.Point(45, 85);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(104, 17);
            this.lblTipoVeiculo.TabIndex = 65;
            this.lblTipoVeiculo.Text = "Tipo de Veículo:";
            this.lblTipoVeiculo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(45, 189);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(117, 17);
            this.lblModelo.TabIndex = 57;
            this.lblModelo.Text = "Modelo do Veículo";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(178, 186);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(134, 24);
            this.txtModelo.TabIndex = 64;
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 386);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipoVeiculo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label6);
            this.Name = "Veiculo";
            this.Text = "Auto Escola Mar Aberto - Cadastrar novo Veículo";
            this.Load += new System.EventHandler(this.Veiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label btnMarca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
    }
}