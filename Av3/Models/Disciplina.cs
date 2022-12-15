using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Av3.Models
{
    public class Disciplina
    {
        [Required(ErrorMessage = "Digite o codigo da Disciplina")]
        public Int64 Codigo { get; set; }

        [Required(ErrorMessage = "Digite o nome da disciplina")]
        public String NomeDisciplina { get; set; }
		
		[Required(ErrorMessage = "Digite a carga horaria")]
        public Int64 CargaHoraria { get; set; }
    }
}
