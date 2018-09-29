using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoAutoEscola
{
    public partial class AdicionarFuncionario : Form
    {
        private MySqlConnection minhaConexao;

        private string formataData(string dataBR)
        {
            String tempDia, tempMes, tempAno;
            tempDia = dataBR;
            tempMes = dataBR;
            tempAno = dataBR;
            tempDia = tempDia.Substring(0, 2);
            tempMes = tempMes.Substring(3, 2);
            tempAno = tempAno.Substring(6, 4);

            String dataUS = tempAno + "/" + tempMes + "/" + tempDia;
            return dataUS;
        }

        public AdicionarFuncionario()
        {
            InitializeComponent();

            minhaConexao = new MySqlConnection("Persist Security Info = False; server=localhost;user id=root; pwd=mysql; database=projeto");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            mkbCpf.Clear();
            mkbRg.Clear();
            mkbDataNasc.Clear();
            txtLagradouro.Clear();
            txtNumero.Clear();
            txtCompl.Clear();
            mkbCep.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            mkbTelRes.Clear();
            mkbTelRec.Clear();
            mkbTelCel.Clear();
            mkbTelCelRec.Clear();
            txtDefSenha.Clear();
            txtDefUser.Clear();
            cmbUf.Text = "";
            txtCidade.Text = "";
            //
            cmbProfissaoFunc.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProfissaoFunc.SelectedItem == "Recepcionista")
            {
                MessageBox.Show("Escolheu Recepcionista", "Erro!!");
            }
            else if (cmbProfissaoFunc.SelectedItem == "Funcionário")
            {
                MessageBox.Show("Escolheu Funcionario!", "Erro!!");
            }
            else
            {
                MessageBox.Show("Escolha uma opção!","Erro!!");
            }
        }
    }
}
