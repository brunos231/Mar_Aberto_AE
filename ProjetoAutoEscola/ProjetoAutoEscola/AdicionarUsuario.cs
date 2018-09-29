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
    
    public partial class AdicionarAluno : Form 
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
        
        public AdicionarAluno()
        {
            InitializeComponent();
            txtNome.Focus();

             minhaConexao = new MySqlConnection("Persist Security Info = False; server=localhost;user id=root; pwd=mysql; database=projeto");
                
        }
        
        public void CheckarAluno()
        {
            txtValor.Show();
            lblVal.Show();
            lblDesc.Show();
            txtDescont.Show();
            lblPagamento.Show();
            cmbPagamento.Show();
            lblParc.Show();
            cmbParcela.Show();
            lblQuitadoStatus.Show();
            cmbQuitadoStatus.Show();
            lblCategoria.Show();
            cmbCategoriaAluno.Show();
                       
        }


        public void LimparCampos()
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
            cmbPagamento.Text = "";
            cmbCategoriaAluno.Text = "";
            txtCidade.Text = "";
            txtValor.Text = "";
            txtDescont.Text = "";
            
        }

        private void AdicionarAluno_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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
                    meuComando1 = new MySqlCommand("INSERT INTO aluno (num_mat, senha, nome, cpf, rg, email, dt_nasc, id_aluno) VALUES ('"+ txtMatricula.Text +"', '"+ txtDefSenha.Text +"', '" + txtNome.Text + "','" + mkbCpf.Text + "', '" + mkbRg.Text + "', '" + txtEmail.Text + "', '"+ dataFormatada +"', '"+ txtDefUser.Text +"')", minhaConexao);
                    meuComando2 = new MySqlCommand("INSERT INTO end_aluno (cep, rua, bairro, uf, cidade) VALUES ('" + mkbCep.Text + "', '" + txtLagradouro.Text + "', '" + txtBairro.Text + "', '" + cmbUf.SelectedItem.ToString() + "', '" + txtCidade.Text + "')", minhaConexao);
                    meuComando3 = new MySqlCommand("INSERT INTO telefone_alun (tel_resid, tel_resid_rec, celular, cel_recad, num_mat) VALUES ('" + mkbTelRes.Text + "','" + mkbTelRec.Text + "','" + mkbTelCel.Text + "', '" + mkbTelCelRec.Text + "','" + txtMatricula.Text + "' )", minhaConexao);
                    meuComando4 = new MySqlCommand("INSERT INTO transacao (metodo, valor, nro_parcel, desconto, obs) VALUES ('"+ cmbPagamento.SelectedItem.ToString() +"', '"+ txtValor.Text +"', '"+ cmbParcela.SelectedItem.ToString() +"', '"+ txtDescont.Text +"', '"+ cmbQuitadoStatus.SelectedItem.ToString() +"')", minhaConexao);
                    

                    meuComando1.ExecuteNonQuery();
                    meuComando2.ExecuteNonQuery();
                    meuComando3.ExecuteNonQuery();
                    meuComando4.ExecuteNonQuery();
                    

                    MessageBox.Show("Usuario cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }

                else
                    MessageBox.Show("Usuario não cadastrado!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void label21_Click(object sender, EventArgs e)
        {

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      

        private void cmbProfissaoFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProfissaoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoriaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
