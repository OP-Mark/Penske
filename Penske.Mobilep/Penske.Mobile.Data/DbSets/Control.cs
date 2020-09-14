using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Control
    {
        public int Id { get; set; }
        public int? Safety { get; set; }
        public int? Inspection { get; set; }
        public int? Entry { get; set; }
    }
}
