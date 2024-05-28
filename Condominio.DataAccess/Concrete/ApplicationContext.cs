
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite.Infrastructure.Internal;
using System.Drawing;
using Microsoft.Data.Sqlite;
using Condominio.Domain.Entities.Comodidades;
using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Viviendas;
using Condominio.DataAccess.FluentConfigurations;
using Condominio.DataAccess.Relacion_Viviendas_Comodidades;

namespace Condominio.DataAccess.Concrete
{
    /// <summary>
    /// Define la estructura de la base de datos de la aplicación.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        //Región destinada a la declaración de las tablas de las entidades base
        #region Tables 

        /// <summary>
        /// Tabla de comodidades.
        /// </summary>
        public DbSet<Comodidad> Comodidades { get; set; }
        /// <summary>
        /// Tabla de persona.
        /// </summary>
        public DbSet<Persona> Persona { get; set; }
        /// <summary>
        /// Tabla de Vivienda.
        /// </summary>
        public DbSet<Vivienda> Vivienda { get; set; }
        /// <summary>
        /// Tabla de Vivienda_Renta.
        /// </summary>
        public DbSet<RentayComodidad> RentayComodidad { get; set; }


        #endregion


        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        public ApplicationContext()
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="connectionString">
        /// Cadena de conexión.
        /// </param>
        public ApplicationContext(string connectionString)
            : base(GetOptions(connectionString))
        {
        }

        /// <summary>
        /// Inicializa un objeto <see cref="ApplicationContext"/>.
        /// </summary>
        /// <param name="options">
        /// Opciones del contexto.
        /// </param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Base classes mapping

            modelBuilder.Entity<Comodidad>().ToTable("Comodidad");

            modelBuilder.Entity<Persona>().ToTable("Persona");

            modelBuilder.Entity<Vivienda>().ToTable("Vivienda");

            modelBuilder.Entity<RentayComodidad>().ToTable("RentayComodidad");

            #endregion

            modelBuilder.ApplyConfiguration(new InquilinoFluentConfiguration());
            modelBuilder.ApplyConfiguration(new PropietarioFluentConfiguration());
            modelBuilder.ApplyConfiguration(new Vivienda_RentaFluentConfiguration());
            
        }


        #region Helpers

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqliteDbContextOptionsBuilderExtensions.UseSqlite(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion

    }

    /// <summary>
    /// Habilita características en tiempo de diseño de la base de datos de la aplicación.
    /// Ej: Migraciones.
    /// </summary>
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            try
            {
                var connectionString = "Data Source = CarDealerDB.sqlite";
                optionsBuilder.UseSqlite(connectionString);
            }
            catch (Exception)
            {
                //handle errror here.. means DLL has no sattelite configuration file.
                throw;
            }

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
