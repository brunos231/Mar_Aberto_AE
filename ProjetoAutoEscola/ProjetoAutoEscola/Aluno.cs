using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoAutoEscola
{
    class Aluno: Usuario
    {
        String tipo_pagamento;

        
        public String Tipo_pagamento
        {
            get { return tipo_pagamento; }
            set { tipo_pagamento = value; }
        }
        String categoria;

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        String profissao;
        public string Situacao_prova;

        public String Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

    }
}
