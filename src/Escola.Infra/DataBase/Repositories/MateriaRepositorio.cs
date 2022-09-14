using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;

namespace Escola.Infra.DataBase.Repositories
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        private readonly EscolaDBContexto _contexto;

        public MateriaRepositorio(EscolaDBContexto contexto)
        {
            _contexto = contexto;
        }

        public IList<Materia> GetAll()
        {
            return _contexto.Materias.ToList();
        }

        public Materia GetById(int id)
        {
            return _contexto.Materias.Find(id);
        }
        public Materia GetByName(string name)
        {
            return _contexto.Materias.FirstOrDefault(x => x.Nome == name);
        }

        public void Post(Materia materia)
        {
            _contexto.Materias.Add(materia);
            _contexto.SaveChanges();
        }

        public void Delete(Materia materia)
        {
            _contexto.Materias.Remove(materia);
            _contexto.SaveChanges();
        }

        public void Put(Materia materia)
        {
            _contexto.Materias.Update(materia);
            _contexto.SaveChanges();
        }

        public int GetTotal()
        {
            return _contexto.Materias.Count();
        }

    }

}