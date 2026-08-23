using Microsoft.EntityFrameworkCore;
using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<NotesEntity> Notes { get; set; }
        public DbSet<LabelEntity> Labels { get; set; }
    }
}