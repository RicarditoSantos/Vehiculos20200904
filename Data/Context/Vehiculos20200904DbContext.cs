using Vehiculos20200904.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos20200904.Data.Context;
public class Vehiculos20200904DbContext:DbContext
{
    public Vehiculos20200904DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculo {get; set;} = null!;
}
public interface Vehiculos20200904{
public DbSet<Vehiculo> Vehiculos {get; set;}
}