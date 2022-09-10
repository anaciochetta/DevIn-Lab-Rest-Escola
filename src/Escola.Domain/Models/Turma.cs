using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Curso { get; set; }
        public List<Aluno> Alunos { get; set; }

    }
}