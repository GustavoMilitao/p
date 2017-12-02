using Prova_POO.Questao_1;
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
            Usuario professor = new Professor();
            Usuario aluno = new Aluno();
            ((Aluno)aluno).efetivarEmprestimo(aluno);
            ((Professor)professor).efetivarEmprestimo(professor);
            Console.ReadKey();
        }
    }
}
