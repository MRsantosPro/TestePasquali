using System.ComponentModel.DataAnnotations;

namespace PasqualiAPI.Models.Pessoa
{
    public class CreateRequest
    {        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Renda { get; set; }

    }
}
