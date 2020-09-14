using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public string Control { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? OperatorId { get; set; }
        public string Location { get; set; }
        public string Vin { get; set; }
        public string Model { get; set; }
        public int? Status { get; set; }
        public bool? Cyc { get; set; }
    }
}
