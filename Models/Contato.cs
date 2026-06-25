using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Models
{
    // Representa a tabela do banco
    public class Contato
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Tel1 { get; set; } = string.Empty;
        public string Tel2 { get; set; } = string.Empty;
        public string Detalhes { get; set; } = string.Empty;
    }
}