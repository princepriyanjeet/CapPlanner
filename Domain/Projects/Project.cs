using Domain.BusinessUnits;
using Domain.Trackers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Projects
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public Guid BusinessUnitId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public List<Tracker> TrackerRecord { get; set; }
    }
}
