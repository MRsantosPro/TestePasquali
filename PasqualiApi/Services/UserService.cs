using AutoMapper;
using PasqualiAPI.Entities;
using PasqualiAPI.Helpers;
using PasqualiAPI.Models.Pessoa;



namespace PasqualiAPI.Services
{
    public class PessoaService : IPessoaService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public PessoaService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _context.Pessoas;
        }

        public Pessoa GetById(int id)
        {
            return getPessoa(id);
        }

        public void Create(CreateRequest model)
        {
           
            if (_context.Pessoas.Any(x => x.Cpf == model.Cpf))
                throw new AppException("CPF '" + model.Cpf + "'Já cadastrado");

            var pessoa = _mapper.Map<Pessoa>(model);

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateRequest model)
        {
            var pessoa = getPessoa(id);
           
            if (model.Cpf != pessoa.Cpf && _context.Pessoas.Any(x => x.Cpf == model.Cpf))
                throw new AppException("Usuario com o '" + model.Cpf + "' já cadastrado");

            _mapper.Map(model, pessoa);
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pessoa = getPessoa(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        private Pessoa getPessoa(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if (pessoa == null) 
            {
                pessoa = new Pessoa();
            }
            return pessoa;
        }
    }
}
