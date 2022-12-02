using System.ComponentModel.DataAnnotations;
using SistemaWebEmpleado.Validations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        [CheckValidLegajo]
        [StringLength(7)]
        public string Legajo { get; set; }

        [Required]
        public string Titulo { get; set; }

    }
}
