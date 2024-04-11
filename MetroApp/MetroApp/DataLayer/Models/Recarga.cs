using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("Recarga")]
    public class Recarga
    {
        [Key]

        [Required(ErrorMessage = "El campo Id Recarga es obligatorio.")]
        public int RecargaId { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo Monto es obligatorio.")]
        public double Monto { get; set; }

        [Required(ErrorMessage = "El campo Cedula es obligatorio.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Id Tarjeta es obligatorio.")]
        public int TarjetaId { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un formato de correo electrónico válido.")]
        public string Email { get; set; }
    }
}