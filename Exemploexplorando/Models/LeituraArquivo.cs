using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//tuplas em métodos 
namespace Exemploexplorando.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
           //quando nao tiver sucesso ele entra na exeção, nao achar o arquivo usa o try
           try
           {
            string[] linhas = File.ReadAllLines(caminho);
            return(true, linhas, linhas.Count());
           }
           catch(Exception)
           {
            return (false, new string[0], 0);
           }
        }
    }
}
// metodo 'lerArquivo'