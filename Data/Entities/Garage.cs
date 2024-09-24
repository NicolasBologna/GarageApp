using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Garage
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public GarageStatus Status { get; set; } = GarageStatus.Enabled;
        public string? Plate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

    }
}
