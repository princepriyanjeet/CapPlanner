using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Comon
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Guid CreatedBy { get; set; }
        Guid ModifiedBy { get; set; }
        DateTimeOffset CreatedOn { get; set; }
        DateTimeOffset ModifiedOn { get; set; }

    }
}
