using Prova_POO.Questao_1;
using Prova_POO.Questao_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Questao3
    {
        public static void Rodar()
        {
            string matricula = String.Empty;
            int matriculaInt = 0;
            bool result = false;
            Usuario usuario;

            Console.WriteLine("Entre com o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o email");
            string email = Console.ReadLine();
            Console.WriteLine("Entre com a matricula");
            matricula = Console.ReadLine();
            result = int.TryParse(matricula, out matriculaInt);
            while (!result)
            {
                Console.WriteLine("Valor passado não é um número");
                Console.WriteLine("Entre com a matricula");
                matricula = Console.ReadLine();
                result = int.TryParse(matricula, out matriculaInt);
            }
            if(matriculaInt  < 100 || matriculaInt > 999)
            {
                throw new MatriculaForaException("Matrícula fora da margem cadastrada!");
            }
            if (matriculaInt >= 201 && matriculaInt <= 300)
            {
                Console.WriteLine("Efetivar empréstimo");
                usuario = new Professor();
                Bibliotecario.efetivarEmprestimo(usuario, new Livro("Livro teste 1", "Eu mesmo", 2017));
            }
            else if (matriculaInt >= 301 && matriculaInt <= 999)
            {
                Console.WriteLine("Efetivar empréstimo");
                usuario = new Aluno();
                Bibliotecario.efetivarEmprestimo(usuario, new Livro("Livro teste 1", "Eu mesmo", 2017));
            }
            else
            {
                Console.WriteLine("Bibliotecário não pega livro emprestado.");
            }
            Console.ReadKey();
        }
    }
}
