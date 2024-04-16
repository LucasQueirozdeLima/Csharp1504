using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            p1.cadastrar();
            p2.cadastrar("nome", "email");
            p2.cadastrar("nome", "email","telefone");

            Console.ReadKey();
        }
    }
}
