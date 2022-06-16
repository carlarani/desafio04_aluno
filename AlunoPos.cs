using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class AlunoPos : Aluno
    {
        public byte linhaDePesquisa;
        public string orientador;
        public double bolsaDeEstudos;

        public AlunoPos(int matricula, string nome, byte codCurso, double bolsaDeEstudos) : base(matricula, nome, codCurso)
        {
            this.bolsaDeEstudos = bolsaDeEstudos;
        }

        public double valorMensalidade;

        public override double calcularMensalidade(byte codCurso)
        {
            switch (codCurso)
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

            valorMensalidade = valorMensalidade - bolsaDeEstudos;

            return valorMensalidade;
        }
    }
}
