using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServicesTrackerAPI.Models.Bean;
using ServicesTrackerAPI.Models.Context;

namespace ServicesTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly BaseContext _context;

        public ClientsController(BaseContext context)
        {
            _context = context;
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientB>>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientB>> GetClientB(long id)
        {
            var clientB = await _context.Clients.FindAsync(id);

            if (clientB == null)
            {
                return NotFound();
            }

            return clientB;
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientB(long id, ClientB clientB)
        {
            if (id != clientB.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientBExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ClientB>> PostClientB(ClientB clientB)
        {
            _context.Clients.Add(clientB);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientB", new { id = clientB.Id }, clientB);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientB(long id)
        {
            var clientB = await _context.Clients.FindAsync(id);
            if (clientB == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(clientB);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientBExists(long id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
