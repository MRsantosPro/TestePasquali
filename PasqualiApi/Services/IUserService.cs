using PasqualiAPI.Entities;
using PasqualiAPI.Models.Pessoa;


namespace  PasqualiAPI.Services
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa GetById(int id);
        void Create(CreateRequest model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
    }
}
