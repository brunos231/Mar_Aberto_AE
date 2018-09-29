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
    public partial class RegistrarPagamentoNAO : Form
    {
        public RegistrarPagamentoNAO()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbAlunos_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lbAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbAlunos.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }
    }
}
