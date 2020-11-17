using Core.Models.Bugs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class BugConfiguration : IEntityTypeConfiguration<BugEntity>
    {
        public void Configure(EntityTypeBuilder<BugEntity> builder)
        {
            // builder.HasOne(u => u.ReportedBy)
            //     .WithMany(u => u.Bug)
            //     .HasForeignKey(k => k.Id);

            builder.HasMany(u => u.User)
                .WithMany(b => b.Bug);
        }
    }
}
