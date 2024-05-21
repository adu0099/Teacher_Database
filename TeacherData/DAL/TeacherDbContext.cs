using Microsoft.EntityFrameworkCore;
using TeacherData.Models.DBEntities;

namespace TeacherData.DAL
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }

    }
}
