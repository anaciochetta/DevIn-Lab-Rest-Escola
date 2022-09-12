using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;


namespace Escola.Domain.DTO
{
    public class MateriaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<NotasMateria> NotasMaterias { get; set; }

        public MateriaDTO(Materia materia)
        {
            Id = materia.Id;
            Nome = materia.Nome;
            NotasMaterias = materia.NotasMaterias;
        }

        public MateriaDTO() { }
    }
}