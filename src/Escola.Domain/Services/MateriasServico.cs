using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Interfaces.Repositories;

using Escola.Domain.Exceptions;

namespace Escola.Domain.Services
{
    public class MateriasServico : IMateriaServico
    {
        private readonly IMateriaRepositorio _materiaRepositorio;

        public MateriasServico(IMateriaRepositorio materiaRespositorio)
        {
            _materiaRepositorio = materiaRespositorio;
        }

        public IList<MateriaDTO> GetAll()
        {
            return _materiaRepositorio.GetAll().Select(x => new MateriaDTO(x)).ToList();
        }

        public MateriaDTO GetById(int id)
        {
            return new MateriaDTO(_materiaRepositorio.GetById(id));
        }
        public MateriaDTO GetByName(string name)
        {
            return new MateriaDTO(_materiaRepositorio.GetByName(name));
        }


        public int GetTotal()
        {
            return _materiaRepositorio.GetTotal();
        }

        public void Post(MateriaDTO materia)
        {
            _materiaRepositorio.Post(new Materia(materia));
        }
        public void Put(MateriaDTO materia)
        {
            var materiaDB = _materiaRepositorio.GetById(materia.Id);
            materiaDB.Update(materia);
            _materiaRepositorio.Put(materiaDB);
        }
        public void Delete(int id)
        {
            var materia = _materiaRepositorio.GetById(id);
            _materiaRepositorio.Delete(materia);
        }
    }
}