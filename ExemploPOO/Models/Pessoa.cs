using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        // public Pessoa()
        // {

        // }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        //A palavra Virtual informa que esse método pode ser sobrescrito
        //pela clase filha que está herdando dessa classe
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
//encapsulamento protege uma classe e define limites para alteração de suas propriedades, expõem só o necessario
//a palavra "virtua" significa que um metodo pode ser subscrito 
