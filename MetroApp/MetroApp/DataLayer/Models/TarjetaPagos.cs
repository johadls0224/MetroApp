using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("TarjetaPagos")]
    public class TarjetaPagos
    {
        [Key]
        public int TarjetaPagoId { get; set; }
        public int Tipo { get; set; }
        public int NumeroTarjeta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CodigoSeguridad { get; set; }
        public string Cedula { get; set; }

    }
}