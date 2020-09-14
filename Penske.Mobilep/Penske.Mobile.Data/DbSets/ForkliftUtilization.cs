using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class ForkliftUtilization
    {
        public int Id { get; set; }
        public int? Unit { get; set; }
        public int? Yyear { get; set; }
        public int? Mmonth { get; set; }
        public int? Wweek { get; set; }
        public int? Hhours { get; set; }
        public int? Ppercent { get; set; }
    }
}
