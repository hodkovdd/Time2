using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Time2.Model
{
    public class ModelContext : DbContext
    {
        public DbSet<WriteOff> WriteOffs { get; set; }
    }
}
