using Domain.BusinessUnits;
using Domain.Comon;
using Domain.Trackers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peristence.Shared
{
    public interface IDatabaseContext
    {
        DbSet<Tracker> Trackers { get; set; }
        DbSet<BusinessUnit> BusinessUnits { get; set; }
        DbSet<T> Set<T>() where T : class, IEntity;
        void Save();
    }
}
