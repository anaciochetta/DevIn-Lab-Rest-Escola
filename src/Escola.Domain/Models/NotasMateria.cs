using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class NotasMateria
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public virtual Materia Materia { get; set; }
        public int BoletimId { get; set; }
        public virtual Boletim Boletim { get; set; }
        public int Nota { get; set; }
    }
}