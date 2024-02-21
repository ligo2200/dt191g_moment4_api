using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moment4_api.Models; 

namespace Moment4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly SongContext _context;

        public SongController(SongContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SonginfoModel>> Get()
        {
            return _context.Songs;
        }

        [HttpGet("{id}")]
        public ActionResult<SonginfoModel> Get(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            return song;
        }

        [HttpPost]
        public IActionResult Post(SonginfoModel song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = song.SongId }, song);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, SonginfoModel song)
        {
            if (id != song.SongId)
            {
                return BadRequest();
            }

            _context.Entry(song).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }

            _context.Songs.Remove(song);
            _context.SaveChanges();

            return NoContent();
        }
    }
}