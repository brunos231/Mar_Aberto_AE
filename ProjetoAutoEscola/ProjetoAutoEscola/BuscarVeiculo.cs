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
    public partial class BuscarVeiculo : Form
    {
        public BuscarVeiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int i = lsbListaDeUsers.SelectedIndex;
            if (i > -1)
            {
                string Valor = lsbListaDeUsers.Items[i].ToString();
                DialogResult dialogResult = MessageBox.Show("Tem certeza que você realmente deseja excluir esse veículo?", "Excluir Veículo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lsbListaDeUsers.Items.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("Impossível excluir esse veículo!");
            }
        }
    }
}
