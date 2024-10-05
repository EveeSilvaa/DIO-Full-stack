using exemploexplorando.models;
using Exemploexplorando.models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();





































//Pessoa p1 = new Pessoa();
//p1.Nome = "Buta";
//p1.Idade = 20;  // sinal de igual esta chamando o valor 
//p1.Apresentar();