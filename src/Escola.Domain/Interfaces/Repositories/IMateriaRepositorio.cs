using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IMateriaRepositorio
    {
        IList<Materia> GetAll();
        Materia GetById(int id);
        Materia GetByName(string name);
        void Post(Materia materia);
        void Put(Materia materia);
        void Delete(Materia materia);
        public int GetTotal();
    }
}