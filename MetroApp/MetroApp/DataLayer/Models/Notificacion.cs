using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("Notificacion")]
    public class Notificacion
    {
        [Key]
        public int RecargaId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public string Cedula { get; set; }
        public int TarjetaId { get; set; }

    }
}