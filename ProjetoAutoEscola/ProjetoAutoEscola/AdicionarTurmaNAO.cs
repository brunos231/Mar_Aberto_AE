using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoAutoEscola
{
    public partial class AdicionarTurmaNAO : Form
    {
        public AdicionarTurmaNAO()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeTurmo.Clear();
            txtmHoraInicio.Clear();
            txtmHoraFim.Clear();
            txtmDataFim.Clear();
            txtmDataInicio.Clear();
            
            this.Hide();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeTurmo.Clear();
            txtmHoraInicio.Clear();
            txtmHoraFim.Clear();
            txtmDataFim.Clear();
            txtmDataInicio.Clear();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
