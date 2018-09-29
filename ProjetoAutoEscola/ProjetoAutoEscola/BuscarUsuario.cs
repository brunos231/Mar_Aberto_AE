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
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
        {
            InitializeComponent();
        }

    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String buscarUser = txtBuscar.Text;
            MessageBox.Show("Digitado: " + buscarUser + "\nCount: " + lsbListaDeUsers.Items.Count
                +"\nConteudo da lista: "+lsbListaDeUsers.Items.Count);
            int n = lsbListaDeUsers.Items.Count;
            for (int i = 0; i >= n; i++)
            {
                MessageBox.Show("Item da lista: " + i);
            }

            

            /*
            if (lsbListaDeUsers.Items.Contains(buscarUser))
            {
                MessageBox.Show("FOI: " + lsbListaDeUsers.Items.IndexOf(buscarUser));
            }
            else
            {
                MessageBox.Show("FOI: NÃO");
            }
            
            try {
                for (int i = 0; i >= lsbListaDeUsers.Items.Count - 1; i++)
                {
                    MessageBox.Show("Item: " + i);
                    lsbListaDeUsers.Items.RemoveAt(i);
                }
            } finally {
                //lsbListaDeUsers.EndUpdate();
            }
            */
            
            //int index = lsbListaDeUsers.Items.IndexOf(buscarUser());
            //MessageBox.Show("Indice na lista: " + index + "\nBuscando a palavrinha: " + buscarUser());
            //lsbListaDeUsers.Refresh();

            //String buscarUser = txtBuscar.Text;
            //MessageBox.Show("Show: "+buscarUser);
            //lsbListaDeUsers.Items.Contains(buscarUser);
            //lsbListaDeUsers.Items.Add(buscarUser);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            String findUser = txtBuscar.ToString();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            String buscarUser = txtBuscar.ToString();
            lsbListaDeUsers.Items.Contains(buscarUser);
            //lsbListaDeUsers.Refresh();
        }

        private void lsbListaDeUsers_DoubleClick(object sender, EventArgs e)
        {
            String curItem = lsbListaDeUsers.SelectedItem.ToString();
            MessageBox.Show("Coisar: " + curItem);
            // Find the string in ListBox2.
            //int index = listBox2.FindString(curItem);
            // If the item was not found in ListBox 2 display a message box, 
            // otherwise select it in ListBox2.
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            int i = lsbListaDeUsers.SelectedIndex;
            if (i > -1)
            {
                string Valor = lsbListaDeUsers.Items[i].ToString();
                DialogResult dialogResult = MessageBox.Show("Tem certeza que você realmente deseja excluir esse usuário?", "Excluir Usuário", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lsbListaDeUsers.Items.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("Impossível excluir esse usuário!");
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int v = lsbListaDeUsers.SelectedIndex;
            //AlterarUsuario altUser = new AlterarUsuario();
            
        }

        private void lsbListaDeUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
