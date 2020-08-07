using Domain.BusinessUnits;
using Domain.Trackers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BusinessToTrackeMappers
{
    public class BusinessToTrackerMapping
    {
        public Guid BusinessUnitId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }

        public Guid TrackerId { get; set; }
        public Tracker Tracker { get; set; }
    }
}
