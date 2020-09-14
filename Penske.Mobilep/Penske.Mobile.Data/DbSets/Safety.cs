using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Safety
    {
        public int Id { get; set; }
        public string Control { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string DockNum { get; set; }
        public bool? WeelChocked { get; set; }
        public bool? TrailerLock { get; set; }
        public bool? CurtainFullyOpen { get; set; }
        public string Carrier { get; set; }
        public string Trailer { get; set; }
        public string LoadType { get; set; }
        public string LoadId { get; set; }
        public int? QtyUnits { get; set; }
        public int? QtyDamage { get; set; }
        public int? QtyNoLabel { get; set; }
        public bool? TandemLocking { get; set; }
        public bool? TrlInspected { get; set; }
    }
}
