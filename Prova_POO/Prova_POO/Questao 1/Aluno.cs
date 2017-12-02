using Prova_POO.Questao_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class Aluno : Usuario
    {
        public List<Livro> LivrosEmprestados { get; set; }

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
            return "Limite de dias : 8";
        }

        public int limiteDias()
        {
            return 8;
        }
    }
}
