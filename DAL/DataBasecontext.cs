using Microsoft.EntityFrameworkCore;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL
{
    public class DataBasecontext : DbContext
    {
        //por medio de este constructor me conecto a la BD
        public DataBasecontext(DbContextOptions<DataBasecontext> options) : base(options)
        {
            
        }
        //Este metodo me sirve para configurar unos indices de cada campo en una tabla en BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); //se crea un indice para la tabla country para el campo name

            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        #endregion
    }
}
