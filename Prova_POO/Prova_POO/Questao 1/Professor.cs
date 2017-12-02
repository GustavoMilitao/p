using Prova_POO.Questao_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class Professor : Usuario , Emprestimo
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
            return "Limite de dias : 15";
        }

        public int limiteDias()
        {
            return 15;
        }

        public void efetivarEmprestimo(Usuario _usuario)
        {
            if ((_usuario.Matricula) >= 201 && (_usuario.Matricula <= 300))
            {
                Professor professor = (Professor)_usuario;
                foreach(Livro livro in professor.LivrosEmprestados)
                {
                    Console.WriteLine("livro: " + livro.Nome+ " Autor:" + livro.Autor + "Ano:" + livro.AnoPublicacao);
                    Console.WriteLine("Devolução daqui à: " + professor.limiteDias() + " Dias");
                }
            }
            else if ((_usuario.Matricula) >= 301 && (_usuario.Matricula <= 999))
            {
                Aluno aluno = (Aluno)_usuario;
                foreach (Livro livro in aluno.LivrosEmprestados)
                {
                    Console.WriteLine("livro: " + livro.Nome + " Autor:" + livro.Autor + "Ano:" + livro.AnoPublicacao);
                    Console.WriteLine("Devolução daqui à: " + aluno.limiteDias() + " Dias");
                }
            }
        }
    }
}
