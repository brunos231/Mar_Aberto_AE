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
    public partial class SituacaoProva : Form
    {

        private MySqlConnection minhaConexao;
        private MySqlCommand meuComando;

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

        public SituacaoProva()
        {
            InitializeComponent();

            minhaConexao = new MySqlConnection("Persist Security Info = False; server=localhost;user id=root; pwd=mysql; database=projeto");
        }

        private void lblPercurso_Click(object sender, EventArgs e)
        {

        }

        private void txtPercurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbReprovado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAprovado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dataFormatada = formataData(mkbDataNasc.Text);

            try
            {
                minhaConexao.Open();
                if (minhaConexao.State == ConnectionState.Open)
                {
                    meuComando = new MySqlCommand("INSERT INTO prova (categori, dt_prova, resultado, nome_aluno) VALUES ('" + cmbCatego.SelectedItem.ToString() + "', '" + dataFormatada + "', '" + cmbResult.SelectedItem.ToString() + "', '" + cmbAluno.SelectedItem.ToString() + "')", minhaConexao);
                    meuComando.ExecuteNonQuery();

                    MessageBox.Show("Prova Cadastrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Prova não cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Sem conexão com o Banco de Dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                minhaConexao.Close();
            }
                
        }

        private void SituacaoProva_Load(object sender, EventArgs e)
        {
            
            
                
                minhaConexao.Open();

                MySqlCommand meuComando1 = new MySqlCommand();
                meuComando1.Connection = minhaConexao;
                meuComando1.CommandText = "SELECT nome FROM aluno";
                MySqlDataReader dr = meuComando1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbAluno.DataSource = dt;
                cmbAluno.DisplayMember = "nome";
                cmbAluno.DataSource = dt;

                minhaConexao.Close();
        }
    }
}
