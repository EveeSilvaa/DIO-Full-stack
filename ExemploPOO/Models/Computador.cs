using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    //todas as classes do .NET herdam do object
    public class Computador 
    {
        public override string ToString()
        {
            return "Método tostring sobrescrito";
        }
    }
}
