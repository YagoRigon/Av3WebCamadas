using Av3.Controllers;
using Av3.Data;
using Av3.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Web.Providers.Entities;
using DbContext = Av3.Data.DbContext;


namespace Av3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class DisciplinaController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public DisciplinaController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<JsonResult> ListaDisciplina()
        {
            var data = await _dbContext.Disciplinas.ToListAsync();
            return new JsonResult(new { data });
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> ListaDisciplina(Int64 codigo)
        {
            var _id = codigo;
            return Ok(new
            {
                success = true,
                data = await _dbContext.Disciplinas.FirstOrDefaultAsync(e => e.Id == _id)
            });
        }

        [HttpPost]
        public async Task<JsonResult> InsertDisciplina([FromBody] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.Disciplinas.AddAsync(disciplina);
                await _dbContext.SaveChangesAsync();

                return new JsonResult(new { disciplina });
            }
            return new JsonResult(new { ModelState });
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDisciplina(Disciplina disciplina)
        {
            _dbContext.Disciplinas.Update(disciplina);
            await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                Sucess = true,
                data = disciplina
            });
        }

        [HttpDelete("{codigo}")]
        public async Task<JsonResult> DeleteDisciplina(int _id)
        {
            var remove = _dbContext.Disciplinas.FirstOrDefault(e => e.Id == _id);
            _dbContext.Disciplinas.Remove(remove);
            await _dbContext.SaveChangesAsync();

            return new JsonResult(new { remove });
        }
    }
}

