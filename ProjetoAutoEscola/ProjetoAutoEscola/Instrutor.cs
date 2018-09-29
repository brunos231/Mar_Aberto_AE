using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoAutoEscola
{
    class Instrutor: Usuario
    {
        


        String categoria_especial;

        public String Categoria_especial
        {
            get { return categoria_especial; }
            set { categoria_especial = value; }
        }
        String valor_aula;

        public String Valor_aula
        {
            get { return valor_aula; }
            set { valor_aula = value; }
        }
    }
}
