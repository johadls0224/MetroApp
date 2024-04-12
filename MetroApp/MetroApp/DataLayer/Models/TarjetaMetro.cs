using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroApp.DataLayer.Models
{
    [Table("TarjetaMetro")]
    public class TarjetaMetro
    {
        [Key]
        public int TarjetaId { get; set; }
        public double Saldo { get; set; }
        public string Cedula { get; set; }

    }
}