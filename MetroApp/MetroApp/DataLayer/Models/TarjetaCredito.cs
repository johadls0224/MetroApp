using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroApp.DataLayer.Models
{
    [Table("TarjetaCredito")]
    public class TarjetaCredito
    {
        [Key]
        [Required(ErrorMessage = "El campo Id Tarjeta es obligatorio.")]
        public int TarjetaId { get; set; }

        [Required(ErrorMessage = "El campo Número de Tarjeta es obligatorio.")]
        [CreditCard(ErrorMessage = "Ingrese un número de tarjeta válido.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "El campo Tipo de Tarjeta es obligatorio.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Vencimiento es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "El campo Código de Seguridad es obligatorio.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "El código de seguridad debe tener 3 caracteres.")]
        public string CodigoSeguridad { get; set; }

        [Required(ErrorMessage = "El campo Nombre en la Tarjeta es obligatorio.")]
        public string NombreEnTarjeta { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un formato de correo electrónico válido.")]
        public string Email { get; set; }
    }
}
