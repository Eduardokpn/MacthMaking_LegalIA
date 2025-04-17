using System.ComponentModel.DataAnnotations;

namespace Tec_Legal.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Área de Interesse é obrigatorio.")]
        public string AreaInteresse { get; set; }

        [Required(ErrorMessage = "Localização é obrigatorio.")]
        public string Localizacao { get; set; }

        public string Descricao { get; set; }

    
    
    }
}
