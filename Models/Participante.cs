using System.ComponentModel.DataAnnotations;
namespace RegistroComunitarioComunidadConectada.Web.Models
{
    public class Participante
    {
        [Required(ErrorMessage = "La identificacion es obligatoria.")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(1, 120, ErrorMessage = "La edad debe estar entre {1} y {2} años.")]
        public int Edad { get; set; }
    }

}


    

