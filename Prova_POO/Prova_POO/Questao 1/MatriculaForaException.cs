using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO.Questao_1
{
    public class MatriculaForaException : Exception
    {
        public MatriculaForaException() : base() { }
        public MatriculaForaException(string message) : base(message) { }
    }
}
