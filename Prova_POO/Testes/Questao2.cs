using Prova_POO.Questao_1;
using Prova_POO.Questao_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    public class Questao2
    {
        public static void rodar()
        {
            Console.WriteLine("---------- Questão 2  ----------");
            Usuario professor = new Professor();
            Usuario aluno = new Aluno();
            Bibliotecario.efetivarEmprestimo(professor, new Livro("Livro teste 1", "Eu mesmo", 2017));
            Bibliotecario.efetivarEmprestimo(aluno, new Livro("Livro teste 2", "Eu mesmo", 2017));
            Console.ReadKey();
        }
    }
}
