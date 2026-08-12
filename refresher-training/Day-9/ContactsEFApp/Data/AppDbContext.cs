using Microsoft.EntityFrameworkCore;
using ContactsEFApp.Models;

namespace ContactsEFApp.Data
{
    // EF uses this class to know what tables exist and how to connect
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; } // this becomes the Contact table
    }
}