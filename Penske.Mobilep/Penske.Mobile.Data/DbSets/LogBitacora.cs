using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class LogBitacora
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Control { get; set; }
        public string Vin { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
    }
}
