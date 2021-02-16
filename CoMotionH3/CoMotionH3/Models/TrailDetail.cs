using System;
using System.Collections.Generic;
using System.Text;

namespace CoMotionH3.Models
{
    class TrailDetail
    {
        public string Id { get; set; }
        public int TrailNumber { get; set; }
        public string TrailDescription { get; set; }
        public DateTime TrailDateAndStartTime { get; set; }
        public string DayOfWeek => TrailDateAndStartTime.DayOfWeek.ToString();
        public int HareId { get; set; }
        public int? CoHare1Id { get; set; }
        public int? CoHare2Id { get; set; }
        public int? CoHare3Id { get; set; }
    }
}
