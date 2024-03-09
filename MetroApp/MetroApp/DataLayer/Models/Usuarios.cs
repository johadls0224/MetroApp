using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]

        [Required(ErrorMessage = "El campo Cedula es obligatorio.")]
        public string Cedula { get; set; }

        public int TipoDocumento { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un formato de correo electrónico válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Password es obligatorio.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio.")]
        public string Telefono { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool EstadoUsuario { get; set; }
    }
}