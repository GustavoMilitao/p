using Prova_POO.Questao_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class Bibliotecario : Usuario, IEmprestimo
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

        public static void efetivarEmprestimo(Usuario _usuario, Livro livro)
        {
            if ((_usuario.Matricula) >= 201 && (_usuario.Matricula <= 300))
            {
                Console.WriteLine("empréstimo para Professores \n");
                Professor professor = (Professor)_usuario;
                professor.LivrosEmprestados.Add(livro);
                Console.WriteLine("livro: " + livro.Nome + " Autor:" + livro.Autor + "Ano:" + livro.AnoPublicacao);
                Console.WriteLine("Devolução daqui à: " + professor.limiteDias() + " Dias");
            }
            else if ((_usuario.Matricula) >= 301 && (_usuario.Matricula <= 999))
            {
                Console.WriteLine("empréstimo para Alunos \n");
                Aluno aluno = (Aluno)_usuario;
                aluno.LivrosEmprestados.Add(livro);
                Console.WriteLine("livro: " + livro.Nome + " Autor:" + livro.Autor + "Ano:" + livro.AnoPublicacao);
                Console.WriteLine("Devolução daqui à: " + aluno.limiteDias() + " Dias");
            }
        }
    }
}
