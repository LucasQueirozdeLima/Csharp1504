using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1504
{
    internal class Pessoa
    {
        protected string nome;
        protected string email;
        protected string telefone;

        public virtual void cadastrar()
        {
            Console.WriteLine("Digite seu nome: ");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email: ");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite seu telefone: ");
            this.telefone = Console.ReadLine();
        }
        public void cadastrar(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
        public void cadastrar(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }
    }
}
