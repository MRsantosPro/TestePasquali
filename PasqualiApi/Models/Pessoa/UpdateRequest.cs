namespace PasqualiAPI.Models.Pessoa
{
    public class UpdateRequest
    {
      
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Renda { get; set; }

        private static string? ReplaceEmptyWithNull(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}
