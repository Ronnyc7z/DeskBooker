using DeskBooker.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DeskBooker.DataAccess
{
    public class DeskBookerContext : DbContext
    {
        public DeskBookerContext(DbContextOptions<DeskBookerContext> options): base(options)
        {
            
        }
        public DbSet<DeskBooking> DeskBooking { get; set; }
        public DbSet<Desk> Desk { get; set; }        
    }
}