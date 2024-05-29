using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examplefundamentals.Common.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        { Console.WriteLine($"Hello, my name is {Name}, \n I am {Age} years old"); }
    }
}