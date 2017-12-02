using Prova_POO.Questao_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Questao1
    {
        public static void rodar()
        {
            Usuario professor = new Professor();
            Usuario aluno = new Aluno();
            Console.WriteLine("Eu sou um Aluno - " + ((Aluno)aluno).mostrarPapel());
            Console.WriteLine("Eu sou um professor - " + ((Professor)professor).mostrarPapel());
            Console.ReadKey();
        }
    }
}
