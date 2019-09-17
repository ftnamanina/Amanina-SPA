using Microsoft.EntityFrameworkCore;
using New.Models;

namespace New.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options ) : base(options){
        }
        public DbSet <Value> Values {get;set;} 
    }
}