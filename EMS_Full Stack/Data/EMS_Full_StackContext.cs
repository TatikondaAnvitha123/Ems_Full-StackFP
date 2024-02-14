using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS_Full_Stack.Models;

namespace EMS_Full_Stack.Data
{
    public class EMS_Full_StackContext : DbContext
    {
        public EMS_Full_StackContext (DbContextOptions<EMS_Full_StackContext> options)
            : base(options)
        {
        }

        public DbSet<EMS_Full_Stack.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
