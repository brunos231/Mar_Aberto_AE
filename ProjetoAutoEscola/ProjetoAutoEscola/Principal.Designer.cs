namespace ProjetoAutoEscola
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblNome = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVeiculo = new System.Windows.Forms.ToolStripDropDownButton();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAula = new System.Windows.Forms.ToolStripDropDownButton();
            this.aulasReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provaRealizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalendario = new System.Windows.Forms.ToolStripButton();
            this.menuNotificacao = new System.Windows.Forms.ToolStripButton();
            this.menuSobre = new System.Windows.Forms.ToolStripButton();
            this.menuLogout = new System.Windows.Forms.ToolStripButton();
            this.gbBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(149, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "User name";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(789, 149);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Bla bla bla 1",
            "Bla bla bla 2"});
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 420);
            this.listBox1.TabIndex = 3;
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.listBox1);
            this.gbBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBox.Location = new System.Drawing.Point(33, 234);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(576, 448);
            this.gbBox.TabIndex = 5;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "Últimas Notificações";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuVeiculo,
            this.menuAula,
            this.menuCalendario,
            this.menuNotificacao,
            this.menuSobre,
            this.menuLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 54);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "menuTotal";
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuUsuario.Font = new System.Drawing.Font("Tahoma", 10F);
            this.menuUsuario.Image = ((System.Drawing.Image)(resources.GetObject("menuUsuario.Image")));
            this.menuUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(66, 51);
            this.menuUsuario.Text = "Usuário";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.instrutorToolStripMenuItem,
            this.funcionárioToolStripMenuItem});
            this.adicionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripMenuItem.Image")));
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // instrutorToolStripMenuItem
            // 
            this.instrutorToolStripMenuItem.Name = "instrutorToolStripMenuItem";
            this.instrutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instrutorToolStripMenuItem.Text = "Instrutor";
            this.instrutorToolStripMenuItem.Click += new System.EventHandler(this.instrutorToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem.Image")));
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // menuVeiculo
            // 
            this.menuVeiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.editarToolStripMenuItem1,
            this.excluirToolStripMenuItem1});
            this.menuVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("menuVeiculo.Image")));
            this.menuVeiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuVeiculo.Name = "menuVeiculo";
            this.menuVeiculo.Size = new System.Drawing.Size(63, 51);
            this.menuVeiculo.Text = "Veículo";
            this.menuVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adicionarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripMenuItem1.Image")));
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(145, 36);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem1.Image")));
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(145, 36);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click_1);
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripMenuItem1.Image")));
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(145, 36);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            this.excluirToolStripMenuItem1.Click += new System.EventHandler(this.excluirToolStripMenuItem1_Click);
            // 
            // menuAula
            // 
            this.menuAula.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aulasReToolStripMenuItem,
            this.provaRealizadaToolStripMenuItem});
            this.menuAula.Image = ((System.Drawing.Image)(resources.GetObject("menuAula.Image")));
            this.menuAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAula.Name = "menuAula";
            this.menuAula.Size = new System.Drawing.Size(52, 51);
            this.menuAula.Text = "Aulas";
            this.menuAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aulasReToolStripMenuItem
            // 
            this.aulasReToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aulasReToolStripMenuItem.Image")));
            this.aulasReToolStripMenuItem.Name = "aulasReToolStripMenuItem";
            this.aulasReToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.aulasReToolStripMenuItem.Text = "Aulas Realizadas";
            this.aulasReToolStripMenuItem.Click += new System.EventHandler(this.aulasReToolStripMenuItem_Click);
            // 
            // provaRealizadaToolStripMenuItem
            // 
            this.provaRealizadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("provaRealizadaToolStripMenuItem.Image")));
            this.provaRealizadaToolStripMenuItem.Name = "provaRealizadaToolStripMenuItem";
            this.provaRealizadaToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.provaRealizadaToolStripMenuItem.Text = "Prova Realizada";
            this.provaRealizadaToolStripMenuItem.Click += new System.EventHandler(this.provaRealizadaToolStripMenuItem_Click);
            // 
            // menuCalendario
            // 
            this.menuCalendario.Image = ((System.Drawing.Image)(resources.GetObject("menuCalendario.Image")));
            this.menuCalendario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCalendario.Name = "menuCalendario";
            this.menuCalendario.Size = new System.Drawing.Size(75, 51);
            this.menuCalendario.Text = "Calendário";
            this.menuCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCalendario.Click += new System.EventHandler(this.menuCalendario_Click);
            // 
            // menuNotificacao
            // 
            this.menuNotificacao.Image = ((System.Drawing.Image)(resources.GetObject("menuNotificacao.Image")));
            this.menuNotificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNotificacao.Name = "menuNotificacao";
            this.menuNotificacao.Size = new System.Drawing.Size(84, 51);
            this.menuNotificacao.Text = "Notificações";
            this.menuNotificacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuNotificacao.Click += new System.EventHandler(this.menuNotificacao_Click_1);
            // 
            // menuSobre
            // 
            this.menuSobre.Image = ((System.Drawing.Image)(resources.GetObject("menuSobre.Image")));
            this.menuSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(48, 51);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSobre.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Image = ((System.Drawing.Image)(resources.GetObject("menuLogout.Image")));
            this.menuLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(56, 51);
            this.menuLogout.Text = "Logout";
            this.menuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuLogout.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 604);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblNome);
            this.Name = "Principal";
            this.Text = "Auto Escola Mar Aberto - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbBox.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton menuVeiculo;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton menuCalendario;
        private System.Windows.Forms.ToolStripDropDownButton menuAula;
        private System.Windows.Forms.ToolStripMenuItem aulasReToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provaRealizadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton menuSobre;
        private System.Windows.Forms.ToolStripButton menuLogout;
        private System.Windows.Forms.ToolStripButton menuNotificacao;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
    }
}