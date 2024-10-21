using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // herança ele puxa os atributos de outra class exemplo aluno esta puxando a herança/ class de pessoa
    {
        public Aluno(string nome) : base(nome)
        {
            
        }
         

       public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e sou uma aluna nota {Nota}!");
        }
    }
}
//quando usa overraido voce está chamando o metodo apresentar, so que o da classe aluno 
