using System.ComponentModel.DataAnnotations;

namespace Zeniata.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Cidade { get; set; }

        public double DistanciaMatriz { get; set; }

        [Required]
        public string EstiloTrabalho { get; set; } // Presencial, Híbrido, Remoto

        [StringLength(100)]
        public string Cargo { get; set; }

        [StringLength(100)]
        public string Setor { get; set; }

        public string StatusSaude { get; set; } // Ativo, Afastado, Acompanhamento

        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        public string Observacoes { get; set; }
    }
}
