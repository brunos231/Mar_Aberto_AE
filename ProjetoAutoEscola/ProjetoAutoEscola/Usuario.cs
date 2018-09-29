using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoAutoEscola
{
    class Usuario
    {
        public Usuario(String nome) { 
        }

        String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        String rg;

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        DateTime data_nascimento;

        public DateTime Data_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }
        String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        String complemento;

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        int cep;

        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        String bairro;

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        String uf;

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        String telefone_residencial;

        public String Telefone_residencial
        {
            get { return telefone_residencial; }
            set { telefone_residencial = value; }
        }
        String telefone_recado;

        public String Telefone_recado
        {
            get { return telefone_recado; }
            set { telefone_recado = value; }
        }
        String telefone_celular;

        public String Telefone_celular
        {
            get { return telefone_celular; }
            set { telefone_celular = value; }
        }
        String telefone_cel_recado;

        public String Telefone_cel_recado
        {
            get { return telefone_cel_recado; }
            set { telefone_cel_recado = value; }
        }
        String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        String login;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
