using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PasqualiAPI.Models.Pessoa;
using PasqualiAPI.Services;

namespace PasqualiAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PessoaController : ControllerBase
    {
        private IPessoaService _pessoaService;
        private IMapper _mapper;

        public PessoaController(
            IPessoaService pessoaService,
            IMapper mapper)
        {
            _pessoaService = pessoaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var pessoas = _pessoaService.GetAll().ToList();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pessoa = _pessoaService.GetById(id);
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Create(CreateRequest model)
        {
            _pessoaService.Create(model);
            return Ok(new { message = "Pessoa cadastrada com sucesso" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateRequest model)
        {
            _pessoaService.Update(id, model);
            return Ok(new { message = "Pessoa alterada com sucesso" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pessoaService.Delete(id);
            return Ok(new { message = "Pessoa deletada com sucesso" });
        }
    }
}
