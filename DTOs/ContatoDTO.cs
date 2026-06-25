using System.ComponentModel.DataAnnotations;

namespace AgendaApi.DTOs
{
    // Representa os dados recebidos da API e faz a validação deles
    public class ContatoDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O telefone principal é obrigatório.")]
        [MinLength(8, ErrorMessage = "O telefone principal deve ter no mínimo 8 caracteres.")]
        public string Tel1 { get; set; } = string.Empty;

        public string Tel2 { get; set; } = string.Empty;

        public string Detalhes { get; set; } = string.Empty;
    }
}