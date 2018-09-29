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
    public partial class AdicionarInstrutor : Form
    {

        private MySqlConnection minhaConexao;
        private MySqlCommand meuComando1, meuComando2, meuComando3, meuComando4;

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
        public AdicionarInstrutor()
        {
            InitializeComponent();
            txtNome.Focus();

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
            cmbCatEspl.Text = "";
            txtValorAula.Clear();
            txtSalario.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mkbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbTelRec.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbTelRes.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbTelCel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mkbTelCelRec.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string dataFormatada = formataData(mkbDataNasc.Text);

            try
            {
                minhaConexao.Open();

                if (minhaConexao.State == ConnectionState.Open)
                {
                    meuComando1 = new MySqlCommand("INSERT INTO instrutor (id_instrut, senha, nome, rg, cpf, dt_nasc, mod_aula, salario, email) VALUES ('" + txtDefUser.Text + "', '" + txtDefSenha.Text + "','" + txtNome.Text + "','" + mkbRg.Text + "', '" + mkbCpf.Text + "', '" + dataFormatada + "', '" + cmbCatEspl.SelectedItem.ToString() + "', '" + txtSalario.Text + "', '" + txtEmail.Text + "')", minhaConexao);
                    meuComando2 = new MySqlCommand("INSERT INTO end_aluno (cep, rua, bairro, uf, cidade, complemetnto) VALUES ('" + mkbCep.Text + "', '" + txtLagradouro.Text + "', '" + txtBairro.Text + "', '" + cmbUf.SelectedItem.ToString() + "', '" + txtCidade.Text + "', '" + txtCompl.Text + "')", minhaConexao);
                    meuComando3 = new MySqlCommand("INSERT INTO telefone_func (tel_resid, tel_resid_rec, celular, cel_recad) VALUES ('" + mkbTelRes.Text + "','" + mkbTelRec.Text + "','" + mkbTelCel.Text + "', '" + mkbTelCelRec.Text + "')", minhaConexao);
                    meuComando4 = new MySqlCommand("INSERT INTO transacao (valor_aulas) VALUES ('" + txtValorAula.Text + "')", minhaConexao);


                    meuComando1.ExecuteNonQuery();
                    meuComando2.ExecuteNonQuery();
                    meuComando3.ExecuteNonQuery();
                    meuComando4.ExecuteNonQuery();


                    MessageBox.Show("Funcionario Cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }

                else
                    MessageBox.Show("Funcionario não cadastrado!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("Erro no envio para o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            finally
            {
                minhaConexao.Close();
            }
        }
    }
}
