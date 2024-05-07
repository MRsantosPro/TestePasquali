using System.ComponentModel.DataAnnotations;

namespace PasqualiAPI.Entities
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Renda { get; set; }
    }
}
