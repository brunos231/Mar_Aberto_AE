namespace ProjetoAutoEscola
{
    partial class RegistrarPagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAlunos = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Location = new System.Drawing.Point(31, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 129);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Aluno";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(524, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(135, 20);
            this.radioButton3.TabIndex = 58;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nome de professor";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(45, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 20);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nome de aluno";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(266, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 20);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nº de matricula";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Buscar:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(75, 39);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(564, 24);
            this.textBox8.TabIndex = 35;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(657, 36);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 57;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Registrar Pagamento de Aluno";
            // 
            // lbAlunos
            // 
            this.lbAlunos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlunos.FormattingEnabled = true;
            this.lbAlunos.ItemHeight = 16;
            this.lbAlunos.Items.AddRange(new object[] {
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS",
            "NOME DA PESSOA QUE TEM QUE PAGAR  >> MOSTRA O VALOR QUE TEM PAGAR ESSE CARALHO  >" +
                "> MOSTRA SE ESTA ATRASADO E TALS"});
            this.lbAlunos.Location = new System.Drawing.Point(31, 229);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(760, 260);
            this.lbAlunos.TabIndex = 64;
            this.lbAlunos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbAlunos.DoubleClick += new System.EventHandler(this.lbAlunos_DoubleClick);
            this.lbAlunos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAlunos_MouseDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(364, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RegistrarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 578);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarPagamento";
            this.Text = "Auto Escola Mar Aberto - Registrar Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Button btnCancelar;
    }
}