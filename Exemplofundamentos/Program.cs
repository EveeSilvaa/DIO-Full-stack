using Exemplofundamentos.Models;



//array é uma variavel que armazena varios valores
//int[] arrayInteiros = new int[3];

//arrayInteiros[0] = 72;
//arrayInteiros[1] = 64;
//arrayInteiros[2] = 50;
//arrayInteiros[3] = 1;


//trabalhando com listas
//List<string> listaString = new List<string>();

//listaString.Add("SP");
//listaString.Add("BA");
//listaString.Add("PA");
//listaString.

//Console.writeLine("Pecorrendo a lista com o For");
//for (int contador = 0; contador < listaString.Count; contador++)
//{
   //Console.writeLine($"Posicão Nº {contador} - {listaString[contador]}");
//}

//Console.writeLine("Pecorrendo a lista com FOREACH");
//int contadorForeach = 0;
//foreach (string item in listaString)
//{
    //Console.writeLine($"Posicão Nº {contadorForeach} - {item}");
    //contadorForeach++;
//}



//copiando um array para o outro
//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//redimensionando um array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Console.WriteLine("pecorrendo o Array com FOR, o FOR vc precisa declarar um contador e declarar ate onde ele vai");
//for(int contador = 0; contador< arrayInteiros.Length; contador++)
//{
   //Console.writeLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
//}


//Console.WriteLine("pecorrendo o Array com o FOREACH, ja no FOREACH voce nao precisa de um contador pois ele joga cadavalor em na variavel");

//int contadorForeach = 0;
//foreach (int valor in arrayInteiros)
//{
   //Console.WriteLine($"Posicão Nº {contadorForeach} - {valor}");
   //contadorForeach++; 
//}



//Pessoa pessoal = new Pessoa();
//pessoal.Nome = "Buta";
//pessoal.Idade = 20;
//pessoal.Apresentar();

//string opcao;
//bool exibirMenu = false

//while (exibirMenu)
//{
    //Console.clear();
   // Console.writeLine("Digite a sua opção:");
    //Console.writeLine("1 - Cadastrar cliente");
    //Console.writeLine("2 - Buscar Cliente");
    //Console.WriteLine("3 - Apagar Cliente");
    //Console.writeLine("4 - Encerrar");

    //opcao = Console.ReadLine();

    //switch (opcao)
    //{
        
        //case "1":
        //Console.writeLine("Cadastro de Cliente");
        //break;

        //case "2":
       //Console.writeLine("Busca de cliente");
        //break;

        //case "3":
        //Console.writeLine("Apagar cliente");
       // break;

        //case "4":
        //Console.writeLine("Encerrar");
        //exibirMenu = false
       // Environment.Exist(0);
        //break;
    //}
//}

//Console.writeLine("O programa encerrou"); //menu interativo



//int soma, numero = 0;

//do 
//{
    //Console.writeLine("Digite um número (0 para parar)");
    //numero = Convert.ToInt32(Console.ReadLine());

    //soma += numero; //Executa o código primeiro, e depois faz a verificação condicional para continuar o laço

//} while (numero 1= 0);

//Console.writeLine($"Total da soma dos números digitados é: {soma}");





//int numero = 5;
//int contador = 1;


//while (contador <= 10)
//{
   //Console.writeLine($"{contador + 1}* Execução: {numero} x {contador} = {numero * contador}"); 
  // contador++;

   //if (contador == 6)
   //{
    //break; //interrompe  o fluxo do loop
  // }
//}




//int numero = 10;

//Console.writeLine($*{numero} x 1 = {numero * 1}*);

//for(int contador = 0; contador <= 10; contador++)
//{
   // Console.writeLine($"{numero} x {contador} = {numero * contador}");
//}




//Calculadora calc = new Calculadora();

//calc.Somar(10, 30);
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);

//int quantidadeEmEstoque = 3;
//int quantidadeCompra = 4;
//bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

//Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
//Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//if (possivelVenda)
//{
   // Console.WriteLine("Venda Realizada.");
//}
//else
//{
   // Console.WriteLine("Desculpe, Não temos a quantidade desejada em estoque.");
//}




//int inteiro = 5;
//string a = inteiro.ToString();

//new Pessoa().ToString

//int a = 5; 
//double b = a;

//long a = long.MaxValue;
//int b = Convert.ToInt32(a);

//int a = int.MaxValue;
//long b = a;

//double a = 4 / 2 + 2;

//string a = "15";

//int b = Convert.ToInt32(a);


//Console.WriteLine(b);

// Cast - Casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");

//int a = 10;
//int b = 20;

//int c = a + b;




// DataTime dataAtual = DataTime.now.AddDays(5);
// Console.writeLine(dataAtual).ToString("dd/mm/yyyy mm:mm"));


//c = c - 5; // 30 + 5

//c += 5;

// c = c - 5
//c |*= 5;
