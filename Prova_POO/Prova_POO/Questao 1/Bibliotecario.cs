using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class Bibliotecario : Usuario
    {
        public void setFuncao(string funcao)
        {
            this.Funcao = funcao;
        }

        public string getFuncao()
        {
            return this.Funcao;
        }

        public string mostrarPapel()
        {
            return String.Empty;
        }
    }
}
