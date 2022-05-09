using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FbBackend.Data;
using FbBackend.Models;

namespace FbBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly FbContext _context;

        public MarketController(FbContext context)
        {
            _context = context;
        }

        // GET: api/Market
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketData>>> GetMarketData()
        {
            return await _context.MarketData.ToListAsync();
        }

        // GET: api/Market/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MarketData>> GetMarketData(int id)
        {
            var marketData = await _context.MarketData.FindAsync(id);

            if (marketData == null)
            {
                return NotFound();
            }

            return marketData;
        }

        // PUT: api/Market/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarketData(int id, MarketData marketData)
        {
            if (id != marketData.Id)
            {
                return BadRequest();
            }

            _context.Entry(marketData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarketDataExists(id))
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

        // POST: api/Market
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MarketData>> PostMarketData(MarketData marketData)
        {
            _context.MarketData.Add(marketData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarketData", new { id = marketData.Id }, marketData);
        }

        // DELETE: api/Market/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MarketData>> DeleteMarketData(int id)
        {
            var marketData = await _context.MarketData.FindAsync(id);
            if (marketData == null)
            {
                return NotFound();
            }

            _context.MarketData.Remove(marketData);
            await _context.SaveChangesAsync();

            return marketData;
        }

        private bool MarketDataExists(int id)
        {
            return _context.MarketData.Any(e => e.Id == id);
        }
    }
}
