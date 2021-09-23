using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksSharingOnlineAPI.Models;

namespace BooksSharingOnlineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookModelContext _context;

        public BooksController(BookModelContext context)
        {
            _context = context;
        }

        // GET: api/BookModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBookModels()
        {
            return await _context.BookModels.ToListAsync();
        }

        // GET: api/BookModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookModel>> GetBookModel(int id)
        {
            var bookModel = await _context.BookModels.FindAsync(id);

            if (bookModel == null)
            {
                return NotFound();
            }

            return bookModel;
        }

        // PUT: api/BookModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookModel(int id, BookModel bookModel)
        {
            if (id != bookModel.BookId)
            {
                return BadRequest();
            }

            _context.Entry(bookModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookModelExists(id))
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

        // POST: api/BookModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookModel>> PostBookModel(BookModel bookModel)
        {
            _context.BookModels.Add(bookModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookModel", new { id = bookModel.BookId }, bookModel);
        }

        // DELETE: api/BookModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookModel(int id)
        {
            var bookModel = await _context.BookModels.FindAsync(id);
            if (bookModel == null)
            {
                return NotFound();
            }

            _context.BookModels.Remove(bookModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookModelExists(int id)
        {
            return _context.BookModels.Any(e => e.BookId == id);
        }
    }
}
