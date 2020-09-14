using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Models
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Comments { get; set; }
        public bool? IsComments { get; set; }
    }
}
