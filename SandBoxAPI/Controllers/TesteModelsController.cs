using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Data;
using SandBoxAPI.Models;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteModelsController : ControllerBase
    {
        private readonly SandBoxAPIContext _context;

        public TesteModelsController(SandBoxAPIContext context)
        {
            _context = context;
        }

        // GET: api/TesteModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TesteModel>>> GetTesteModel()
        {
            return await _context.TesteModel.ToListAsync();
        }

        // GET: api/TesteModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TesteModel>> GetTesteModel(int id)
        {
            var testeModel = await _context.TesteModel.FindAsync(id);

            if (testeModel == null)
            {
                return NotFound();
            }

            return testeModel;
        }

        // PUT: api/TesteModels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTesteModel(int id, TesteModel testeModel)
        {
            if (id != testeModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(testeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TesteModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TesteModels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TesteModel>> PostTesteModel(TesteModel testeModel)
        {
            _context.TesteModel.Add(testeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTesteModel", new { id = testeModel.Id }, testeModel);
        }

        // DELETE: api/TesteModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TesteModel>> DeleteTesteModel(int id)
        {
            var testeModel = await _context.TesteModel.FindAsync(id);
            if (testeModel == null)
            {
                return NotFound();
            }

            _context.TesteModel.Remove(testeModel);
            await _context.SaveChangesAsync();

            return testeModel;
        }

        private bool TesteModelExists(int id)
        {
            return _context.TesteModel.Any(e => e.Id == id);
        }
    }
}
