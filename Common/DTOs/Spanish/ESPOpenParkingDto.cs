using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.Spanish
{
    public class ESPOpenParkingDto
    {
        [Required]
        public string Patente { get; set; }
        [Required]
        public int IdUsuarioIngreso { get; set; }
        [Required]
        public int IdCochera { get; set; }
    }
}
