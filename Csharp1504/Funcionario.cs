using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1504
{
    class Funcionario : Pessoa
    {
        protected int registro;
        protected double salario;

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite seu registro: ");
            this.registro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu salario: ");
            this.salario = double.Parse(Console.ReadLine());
        }
    }
}
