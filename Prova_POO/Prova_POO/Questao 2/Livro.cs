using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_2
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string nome, string autor, int anoPublicacao)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.AnoPublicacao = anoPublicacao;
        }
    }
}
