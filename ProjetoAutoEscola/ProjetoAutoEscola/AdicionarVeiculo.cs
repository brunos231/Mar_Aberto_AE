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
    public partial class AdicionarVeiculo : Form
    {
        public AdicionarVeiculo()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtTipo.Clear();
            txtMarca.Clear();
            txtCor.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtPlaca.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo 'tipo'.");
            }
            else
            {
                if (txtMarca.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o campo 'marca'.");
                }
                else
                {
                    if (txtCor.Text == "")
                    {
                        MessageBox.Show("Por favor, preencha o campo 'cor'.");
                    }
                    else
                    {
                        if (txtModelo.Text == "")
                        {
                            MessageBox.Show("Por favor, preencha o campo 'modelo'.");
                        }
                        else
                        {
                            if (txtPlaca.Text == "")
                            {
                                MessageBox.Show("Por favor, preencha o campo 'placa'.");
                            }
                            else
                            {
                                if (txtTipo.Text == "")
                                {
                                    MessageBox.Show("Por favor, preencha o campo 'tipo'.");
                                }
                                else
                                {
                                    MessageBox.Show("Veículo cadastrado com sucesso!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {
            txtTipo.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
