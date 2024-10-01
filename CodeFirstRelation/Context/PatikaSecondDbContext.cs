using CodeFirstRelation.Models;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        // Constructor to accept DbContextOptions
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {
        }

        // Veritabanı bağlantı ayarlarını tanımlıyoruz.
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        // Veritabanı bağlantı dizesini belirtiyoruz.
        //   optionsBuilder.UseSqlServer(@"Server=Ahmet;Database=PatikaCodeFirstDb2;Trusted_Connection=True;");
        // }

        // Model oluşturulurken ilişkileri tanımlıyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Bir User'ın birden çok Post'u olabilir, her Post'un bir User'ı vardır.
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }
    }
}
