using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
      protected decimal saldo;

      public abstract void Creditar(decimal valor);

      public void ExibirSaldo()
      {
        Console.WriteLine("O seu saldo é: " + saldo); 
      }
    }
}
// o metdod protected, ele significa que está protegido contra alterações externas com exceção das suas classes
