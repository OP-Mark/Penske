using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class LocationsConfiguration
    {
        public int Id { get; set; }
        public int Nvins { get; set; }
        public string Location { get; set; }
        public string Models { get; set; }
        public string ModelsPriorityI { get; set; }
        public string ModelsPriorityR { get; set; }
        public bool? Authorize { get; set; }
        public bool? Scanning { get; set; }
        public string Rrow { get; set; }
        public int? Ccolumn { get; set; }
    }
}
