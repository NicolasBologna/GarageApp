using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.Spanish
{
    public class ESPCloseParkingDto
    {
        [Required]
        public string Patente { get; set; }
        [Required]
        public int IdUsuarioEgreso { get; set; }
    }
}
