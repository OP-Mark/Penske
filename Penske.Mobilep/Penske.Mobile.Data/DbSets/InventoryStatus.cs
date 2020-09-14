using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class InventoryStatus
    {
        public int Id { get; set; }
        public string NameStatus { get; set; }
        public bool? Active { get; set; }
    }
}
