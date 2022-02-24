using LeaveManagement.Data.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

        }


        //Whenever We call save changes then this will call
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base
                                    .ChangeTracker
                                    .Entries<BaseEntity>()
                                    .Where(q => q.State == EntityState.Modified || q.State == EntityState.Modified)
                      )
            {
                entry.Entity.DateModified = System.DateTime.Now;

                //Calling Add or AddRange
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = System.DateTime.Now;
                }

            }

            return base.SaveChangesAsync(cancellationToken);
        }


        // Admin Will add NEW type of leave in db or CRUD
        public DbSet<LeaveType> LeaveTypes { get; set; }

        //Admin will set new LeaveType to all employee in LeaveManagement -> LeaveType ->Allocate Leave
        //After that only 
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        //Most of User will request for leave in ApplyForLeave
        public DbSet<LeaveRequest> LeaveRequests { get; set; }

    }
}
