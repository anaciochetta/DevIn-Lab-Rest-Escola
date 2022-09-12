using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Microsoft.Extensions.Caching.Memory;
using Escola.Domain.Exceptions;
using Escola.Domain.Models;
using Escola.Api.Config;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly IMateriaServico _materiasServico;

        public MateriasController(IMateriaServico materiaServico)
        {
            _materiasServico = materiaServico;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var materias = _materiasServico.GetAll();
            return Ok(materias);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var materias = _materiasServico.GetById(id);
            return Ok(materias);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var materias = _materiasServico.GetByName(name);
            return Ok(materias);
        }
    }
}