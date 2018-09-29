namespace ProjetoAutoEscola
{
    partial class AdicionarTurmaNAO
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
            this.btnNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNomeTurmo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtmHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.txtmDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtmDataFim = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.AutoSize = true;
            this.btnNome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.Location = new System.Drawing.Point(57, 82);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(112, 17);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Nome da Turma:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(247, 580);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 29);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNomeTurmo
            // 
            this.txtNomeTurmo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTurmo.Location = new System.Drawing.Point(60, 111);
            this.txtNomeTurmo.Name = "txtNomeTurmo";
            this.txtNomeTurmo.Size = new System.Drawing.Size(485, 24);
            this.txtNomeTurmo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hórario de ínicio de aula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hórario de fim de aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data prevista para fim de aulas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de íncio de aulas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Professor responsável:";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Items.AddRange(new object[] {
            "Vanessa Santana",
            "Daynessa Kelly Key",
            "Victor Sabidão",
            "Lari Fofa Lindeza",
            "Alan Bear",
            "Graziela Cravo e Canela",
            "Bruno Safadhenho"});
            this.cmbProfessor.Location = new System.Drawing.Point(60, 409);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(485, 24);
            this.cmbProfessor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adicionar Nova Turma";
            // 
            // txtmHoraInicio
            // 
            this.txtmHoraInicio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmHoraInicio.Location = new System.Drawing.Point(60, 202);
            this.txtmHoraInicio.Mask = "00:00";
            this.txtmHoraInicio.Name = "txtmHoraInicio";
            this.txtmHoraInicio.Size = new System.Drawing.Size(75, 24);
            this.txtmHoraInicio.TabIndex = 2;
            this.txtmHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtmHoraFim
            // 
            this.txtmHoraFim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmHoraFim.Location = new System.Drawing.Point(357, 202);
            this.txtmHoraFim.Mask = "00:00";
            this.txtmHoraFim.Name = "txtmHoraFim";
            this.txtmHoraFim.Size = new System.Drawing.Size(79, 24);
            this.txtmHoraFim.TabIndex = 3;
            this.txtmHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // txtmDataInicio
            // 
            this.txtmDataInicio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmDataInicio.Location = new System.Drawing.Point(60, 306);
            this.txtmDataInicio.Mask = "00/00/0000";
            this.txtmDataInicio.Name = "txtmDataInicio";
            this.txtmDataInicio.Size = new System.Drawing.Size(100, 24);
            this.txtmDataInicio.TabIndex = 4;
            this.txtmDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtmDataFim
            // 
            this.txtmDataFim.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmDataFim.Location = new System.Drawing.Point(357, 306);
            this.txtmDataFim.Mask = "00/00/0000";
            this.txtmDataFim.Name = "txtmDataFim";
            this.txtmDataFim.Size = new System.Drawing.Size(100, 24);
            this.txtmDataFim.TabIndex = 5;
            this.txtmDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(126, 580);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(371, 580);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reservar Carro:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HB20 ",
            "Fusca Saladão"});
            this.comboBox1.Location = new System.Drawing.Point(60, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(485, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AdicionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 624);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtmDataFim);
            this.Controls.Add(this.txtmDataInicio);
            this.Controls.Add(this.txtmHoraFim);
            this.Controls.Add(this.txtmHoraInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeTurmo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNome);
            this.Name = "AdicionarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Escola Mar Aberto - Adicionar Nova Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNomeTurmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtmHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtmHoraFim;
        private System.Windows.Forms.MaskedTextBox txtmDataInicio;
        private System.Windows.Forms.MaskedTextBox txtmDataFim;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}