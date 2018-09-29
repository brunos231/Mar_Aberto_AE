using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjetoAutoEscola
{
    public partial class User : Component
    {
        private String nome;
        private String rg;
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private DateTime data_nascimento;

        public DateTime Data_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }
        private String endereco_residencial;

        public String Endereco_residencial
        {
            get { return endereco_residencial; }
            set { endereco_residencial = value; }
        }
        private String tel_residencial;

        public String Tel_residencial
        {
            get { return tel_residencial; }
            set { tel_residencial = value; }
        }
        private String tel_recado;

        public String Tel_recado
        {
            get { return tel_recado; }
            set { tel_recado = value; }
        }
        private String tel_celular;

        public String Tel_celular
        {
            get { return tel_celular; }
            set { tel_celular = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public User()
        {
            InitializeComponent();

        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return nome;
        }

        public void setRg(String rg)
        {
            this.rg = rg;
        }

        public String getRg()
        {
            return rg;
        }

        
        public User(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
    }
}
