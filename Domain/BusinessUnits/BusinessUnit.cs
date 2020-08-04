using Domain.Comon;
using Domain.Projects;
using Domain.Trackers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.BusinessUnits
{
    public class BusinessUnit:IEntity
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
        public string BuinsessUnitCode { get; set; }
        public string BuinsessUnitName { get; set; }
        public List<Project> Projects { get; set; }
    }
}
