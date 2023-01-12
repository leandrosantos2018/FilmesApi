using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdcionaFilme([FromBody] CreateFilmeDto filmeDto)

        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
           
            _context.Filmes.Add(filme);
            _context.SaveChanges();
          return  CreatedAtAction(nameof(REcuperaFilmeById), new { id = filme.Id },
                filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip  = 0, [FromQuery] int take = 50)

        {
            return _context.Filmes.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult REcuperaFilmeById(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(Filme => Filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }


        [HttpDelete("{id}")]
        public IActionResult DescartarFilmeById(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(Filme => Filme.Id == id);
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            if (filme == null) return NotFound();
            return Ok(filme);
        }

      

        //[HttpPut("{id}")]
        //public IActionResult DescartarFilme(int id)
        //{
        //    var filme = _context.Filmes.FirstOrDefault(Filme => Filme.Id == id);
        //    _context.Filmes.
        //    _context.SaveChanges();
        //    if (filme == null) return NotFound();
        //    return Ok(filme);
        //}
    }

 }

