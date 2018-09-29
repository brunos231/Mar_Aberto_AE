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
    public partial class Login : Form
    {
        Principal principal = new Principal();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            principal.Show();
            this.Hide();
            string CONFIG = ("Persist Security Info=False;server=localhost;database=autoescola_db;uid=root;server=localhost;database=autoescola_db;uid=root;pwd='oracle'");
            MySqlConnection conexao = new MySqlConnection(CONFIG);
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            conexao.Open();

            if (conexao.State == ConnectionState.Open)
            {
                MessageBox.Show("Salvo com sucesso!");
                comando = new MySqlCommand("INSERT INTO aluno (num_mat, nome) VALUE ('" + random + "', '" + txtNome.Text + "')", conexao);
            }
            else
            {
                MessageBox.Show("Erro");
            }*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskTxtSenha.Clear();
            txtLogin.Clear();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
