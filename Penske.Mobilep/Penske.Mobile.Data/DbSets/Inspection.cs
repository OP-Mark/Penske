using System;
using System.Collections.Generic;

namespace Penske.Mobilep.Data
{
    public partial class Inspection
    {
        public int Id { get; set; }
        public string Control { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Unit { get; set; }
        public int? OperatorId { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartTime { get; set; }
        public string Type { get; set; }
        public string EndMeter { get; set; }
        public string TimeEndMeter { get; set; }
        public string StartMeter { get; set; }
        public string TimeStartMeter { get; set; }
        public string TireWheels { get; set; }
        public string Lights { get; set; }
        public string Gauges { get; set; }
        public string SeatBelt { get; set; }
        public string Decals { get; set; }
        public string TransOil { get; set; }
        public string OverheadGard { get; set; }
        public string EngineOil { get; set; }
        public string HydraulicFluid { get; set; }
        public string RadiatorFluid { get; set; }
        public string EngineHoses { get; set; }
        public string Steering { get; set; }
        public string Brakes { get; set; }
        public string HandBrake { get; set; }
        public string Horn { get; set; }
        public string Battery { get; set; }
        public string ShiftLevels { get; set; }
        public string Fork { get; set; }
        public string Leaks { get; set; }
        public string BackupAlarm { get; set; }
        public string FireExtinguisher { get; set; }
        public string AirFilter { get; set; }
        public string Comments { get; set; }
    }
}
