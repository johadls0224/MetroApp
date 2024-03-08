using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("Pagos")]
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public int EstadoPago { get; set; }
        public string Cedula { get; set; }
        public int TarjetaId { get; set; }

    }
}