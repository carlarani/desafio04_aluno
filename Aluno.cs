using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Aluno
    {
        public int matricula;
        public string nome;
        public DateTime dataNascimento;
        public byte codCurso;
        public double percentualCobranca;

        public const byte ARQUITETURA = 1;
        public const byte CIENCIADACOMPUTACAO = 2;
        public const byte ENGENHARIA = 3;
        public const byte BIOMEDICINA = 4;

        double valorMensalidade;

        public Aluno(int matricula, string nome, byte codCurso)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.codCurso = codCurso;
        }

        public virtual double calcularMensalidade(byte codCurso)
        {
            switch(codCurso)
            {
                case 1:
                    valorMensalidade = 450.00;
                    break;
                case 2:
                    valorMensalidade = 650.00;
                    break;
                case 3:
                    valorMensalidade = 850.00;
                    break;
                case 4:
                    valorMensalidade = 750.00;
                    break;
            }
            
            return valorMensalidade;
        }
    }
}
