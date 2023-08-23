using Microsoft.EntityFrameworkCore;

namespace Demo1.Models
{
    public class ITIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SARA;Database=ST1;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

      
    }
}
