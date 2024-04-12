using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MetroApp.DataLayer.Models
{
    [Table("CreditCard")]
    public class CreditCard
    {
        [Key]

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Numero de tarjeta es obligatorio.")]
        public int NumeroTarjeta { get; set; }

        [Required(ErrorMessage = "El campo Fecha de vencimiento es obligatorio.")]
        public DateTime FechaVencimiento { get; set; }

        [Required(ErrorMessage = "El campo CVV es obligatorio.")]
        public int CVV { get; set; }

    }
}