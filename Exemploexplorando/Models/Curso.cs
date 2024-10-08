using System.Security.Cryptography.X509Certificates;

{
    Public string Nome {get; set;}
    Public List<Pesssoa> Alunos { get; set; }

    public void AdicionarAluno(Pssoa aluno)
    {
        Alunos.Add(aluno);
    }
    public int obterQuantidadeDeAlunoMatriculado()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        Console.writeLine($"Alunos do curso de: {Nome}");
        foreach (Pessoa aluno in Alunos)
        {
            Console.WriteLine(aluno.NomeCompleto);
        }
    }
}
