using Domain.Projects;
using Domain.Trackers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ProjectToTrackerMappers
{
    public class ProjectToTrackerMapping
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid TrackerId { get; set; }
        public Tracker Tracker { get; set; }
    }
}
