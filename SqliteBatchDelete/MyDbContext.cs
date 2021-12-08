using Microsoft.EntityFrameworkCore;

namespace SqliteBatchDelete
{
    public class MyDbContext : DbContext
    {
        public DbSet<MyEntity> MyDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=SqliteBatchDelete.db");
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public uint MyUintId { get; set; }
    }
}
