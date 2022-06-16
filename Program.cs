using System;

namespace Aluno
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(1234, "Amanda", 1);
            Aluno aluno2 = new Aluno(2341, "Bernardo", 3);
            Aluno aluno3 = new Aluno(3412, "Camila", 2);
            Aluno aluno4 = new Aluno(4123, "Daniel", 4);

            Console.WriteLine($"O curso de {aluno1.nome} custará R${aluno1.calcularMensalidade(aluno1.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {aluno2.nome} custará R${aluno2.calcularMensalidade(aluno2.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {aluno3.nome} custará R${aluno3.calcularMensalidade(aluno3.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {aluno4.nome} custará R${aluno4.calcularMensalidade(aluno4.codCurso)} ao mês.");

            AlunoPos alunopos1 = new AlunoPos(1234, "Eduarda", 1, 120.00);
            AlunoPos alunopos2 = new AlunoPos(2341, "Felipe", 3, 80.00);
            AlunoPos alunopos3 = new AlunoPos(3412, "Giovana", 2, 300.00);
            AlunoPos alunopos4 = new AlunoPos(4123, "Hugo", 4, 10.00);

            Console.WriteLine($"O curso de {alunopos1.nome} custará R${alunopos1.calcularMensalidade(alunopos1.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {alunopos2.nome} custará R${alunopos2.calcularMensalidade(alunopos2.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {alunopos3.nome} custará R${alunopos3.calcularMensalidade(alunopos3.codCurso)} ao mês.");
            Console.WriteLine($"O curso de {alunopos4.nome} custará R${alunopos4.calcularMensalidade(alunopos4.codCurso)} ao mês.");
        }
    }
}