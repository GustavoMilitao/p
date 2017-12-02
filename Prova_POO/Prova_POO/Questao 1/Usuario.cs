using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class Usuario
    {
        protected string Nome;
        protected string Email { get; set; }
        public int Matricula { get; set; }
        protected string Funcao;
        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }
    }
}
