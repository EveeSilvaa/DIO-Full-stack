using Exemploexplorando.Models;
using System.Globalization; //Alterando a localização do sistema
using Models;
using System.Text.Json.Nodes;
using Newtonsoft.Json;



//deserializando um objeto

string conteudoArquivo =File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Prodiuto: {venda.Produto}, " + 
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}













//DateTime dataAtual = DateTime.Now;

//List<Venda> listaVendas = new List<Venda>();

//Venda v1 = new Venda(1, "material de escritorio", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

//listaVendas.Add(v1);
//listaVendas.Add(v2);


//string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

//File.WriteAllText("Arquivos/vendas.json", serializado);

//Console.WriteLine(serializado);



//int numero = 20;
//bool ehPar = false;

//Ultilizando o IF Ternário 
//ehPar = numero % 2 == 0;
//Console.writeLine($"O numero {numero} é" + (ehPar ? "par" : "ímpar"));

//if (numero % 2 == 0)
//{
    //Console.writeLine($"O número {numero} é par");
//}
//else
//{
   // Console.WriteLine($"O número {numero} é ímpar");
//}

//Pessoa p1 = new Pessoa("Maria", "Silva");

//(string nome, string sobrenome) = p1;

//Console.WriteLine($"{nome} {sobrenome}");

//testando o método
//LeituraArquivo arquivo = new LeituraArquivo();

//Descarte de uma informação
//quando não esta usando uma informação voce usa o underling(_) ex: quantidadesLinhas
//var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

//if (sucesso)
//{
    //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
    //foreach(string linha in linhasArquivo)
    //{
       // Console.WriteLine(linha);
    //}
//}
//else
//{
    //Console.WriteLine("Não foi possivel ler o arquivo");
//}

//como declarar uma tupla
//(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Maria", "Silva", 64.0M);

//Outras maneiras de declarar uma tupla
//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Maria", "Silva", 64.0M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Maria", "Silva", 64.0M);//unica desvatagem-> Não consegue nomear o objeto

//Console.WriteLine($"Id: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");

//Criando um dicionario
//Dictionary<string, string> estados = new Dictionary<string, string>();

//Adicionando itens no dicionario
//estados.Add("SP", "Sao Paulo");
//estados.Add("RJ", "Rio de Janeiro");
//estados.Add("MG", "Minas Gerais");

//Pode ser declarada de duas formas
//foreach(KeyValuePair<string, string> item in estados){
//foreach (var item in estados)
//{
    //Console.WriteLine($"Chave item {item.Key} e valor do item {item.Value}");
//}


//Removendo um item do dicionario pela chave
//estados.Remove("SP");

//Alterando o valor de um item do dicionario, a chave nao pode ser alterada.
//estados["RJ"] = "Rio de Janeiro - Copacabana";


//Verificando se a chave ja existe no dicionario
//string chave = "MG";
//Console.WriteLine($"Verificando a chave: {chave}");

//if (estados.ContainsKey(chave))
//{
    //Console.WriteLine($"Valor existente: {chave}");
//}
//else
//{
 //Console.WriteLine($"Valor não existe. É seguro adicionar a chave {chave}");
//}

//Imprimindo um valor pela chave
//Console.WriteLine(estados["MG"]);







//Criando variavel para pilha
// Stack<int> pilha = new Stack<int>();


// //Adicionando na pilha
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }


// //Removendo da pilha
// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }







// //Criando uma fila
// Queue<int> fila = new Queue<int>();

// //Adiciona na fila
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// //Remove da fila
// Console.WriteLine($"Removendo da fila {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }



// //Tratativa de erro com Try Catch
// try
// {
//     //Realizando a leitura de um arquivo texto.
//     string[] strings = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string string1 in strings)
//     {
//         Console.WriteLine(string1);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");

// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");

// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica {ex.Message}");

// }
// finally 
// {
//     Console.WriteLine("Chegou até aqui");
// }



// //Utilizando conversão de data com tratamento de exceção TryParse
// string dataString = "2022-10-22 18:00";
// variavel, formato da data   , conversão local             , estilo da data     , saida.
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// if (sucesso)
// {
// Console.WriteLine($"Conversão realizada com sucesso, Data: {data}");
// }
// else
// {
// Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);


// //Trabalhando com DataTime
// DateTime data = DateTime.Now;

// //Data e hora completa
// Console.WriteLine(data);

// //Data formatada
// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

// //Formatar para pegar apenas a data
// Console.WriteLine(data.ToShortDateString());

// //Formatar para pegar apenas a hora
// Console.WriteLine(data.ToShortTimeString());



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valor = 11158.23M;

// //A letra ":C" pega a moeda corrente e faz a conversao monetaria.
// Console.WriteLine($"{valor:C}");


// //Outra forma de formatar a localização
// Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));


// Console.WriteLine(valor.ToString("C2")); //C2 moeda, localização corrente + casas decimais
// Console.WriteLine(valor.ToString("N2")); //N2 numero + casas decimais

// double porcetagem = .1425;
// //formatando com porcentagem
// Console.WriteLine(porcetagem.ToString("P"));

// int numeros = 123456;
// //formatação personalizada
// Console.WriteLine(numeros.ToString("##-##-##"));

// Pessoa p1 = new Pessoa(nome:"Diogo", sobrenome:"Sousa");
// Pessoa p2 = new Pessoa(nome:"Jorge", sobrenome:"Santos");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// p1.Nome = "Maria";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;
// p1.Apresentar();


//Pessoa p1 = new Pessoa();
//p1.Nome = "Buta";
//p1.Idade = 20;  // sinal de igual esta chamando o valor 
//p1.Apresentar();
