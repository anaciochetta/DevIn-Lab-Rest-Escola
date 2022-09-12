using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Services
{
    public interface IMateriaServico
    {
        public IList<MateriaDTO> GetAll();
        MateriaDTO GetById(int id);
        MateriaDTO GetByName(string name);
        void Post(MateriaDTO materia);
        void Put(MateriaDTO materia);
        void Delete(int id);
        public int GetTotal();
    }
}