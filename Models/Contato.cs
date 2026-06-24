using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone principal é obrigatório.")]
        [MinLength(8, ErrorMessage = "O telefone principal deve ter no mínimo 8 caracteres.")]
        public string Tel1 { get; set; } = string.Empty;
        public string Tel2 { get; set; } = string.Empty;
        public string Detalhes { get; set; } = string.Empty;
    }
}