using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //Abstract informa que classe só pode ser herdada 
    //não pode ser instanciada
    public abstract class Conta
    {
        //Protected informa atributo é protegido 
        //mas que pode ser alterado pelas classes filhas
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + Saldo);
        }
    }
}
// o metdod protected, ele significa que está protegido contra alterações externas com exceção das suas classes
