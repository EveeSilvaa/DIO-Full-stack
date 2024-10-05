using System.Security.Cryptography.X509Certificates;

{
    Public string Nome {get; set;}
    Public List<Pesssoa> Alunos { get; set; }

    public void AdicionarAluno(Pssoa aluno)
    {
        Aluno.add(aluno);
    }
}