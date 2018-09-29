using System;
using System.Windows.Forms;

namespace ProjetoAutoEscola
{

    public partial class Principal : Form
    {
        AdicionarAluno addAluno = new AdicionarAluno();
        AdicionarFuncionario addFunc = new AdicionarFuncionario();
        AdicionarInstrutor addIndtrutor = new AdicionarInstrutor();
        BuscarUsuario bscUser = new BuscarUsuario();
        AdicionarVeiculo addVei = new AdicionarVeiculo();
        BuscarVeiculo bscVei = new BuscarVeiculo();
        //veiculos
        AdicionarVeiculo addVeic = new AdicionarVeiculo();
        BuscarVeiculo bscVeic = new BuscarVeiculo();
        //aulas
        AulaRealizada aulaR = new AulaRealizada();
        SituacaoProva statusP = new SituacaoProva();
        //calendario
        Calendario calendario = new Calendario();
        //sobre
        Sobre sobre = new Sobre();
        DateTime data = DateTime.Now;
        //notificação
        Notificacao notificacao = new Notificacao();

        public Principal()
        {
            InitializeComponent();
        }

      

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bscUser.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bscUser.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addVeic.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            bscVeic.ShowDialog();
        }

        private void aulasReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aulaR.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bscVeic.ShowDialog();
        }

        private void provaRealizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusP.ShowDialog();
        }

        private void situaçãoDaProvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuCalendario_Click(object sender, EventArgs e)
        {
            calendario.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sobre.ShowDialog();
        }

        private void menuNotificacao_Click(object sender, EventArgs e)
        {

        }

        private void menuNotificacao_Click_1(object sender, EventArgs e)
        {
            notificacao.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAluno.ShowDialog();
        }

        private void instrutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addIndtrutor.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFunc.ShowDialog();
        }



    }
}
