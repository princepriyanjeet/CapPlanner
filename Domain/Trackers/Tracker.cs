using Common.Enums;
using Domain.BusinessUnits;
using Domain.Comon;
using Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Trackers
{
    public class Tracker : IEntity
    {
        public Guid Id { get ; set ; }
        public Guid CreatedBy { get; set ; }
        public Guid ModifiedBy { get ; set ; }
        public DateTimeOffset CreatedOn { get ; set ; }
        public DateTimeOffset ModifiedOn { get ; set ; }
        public decimal OffshoreCount { get; set; }
        public decimal OnshoreCount { get; set; }
        public MonthlyPlanner TrackerMonth { get; set; }
        public int TrackerYear { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
