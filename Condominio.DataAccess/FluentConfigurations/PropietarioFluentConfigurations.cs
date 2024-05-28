
using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Propietarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.FluentConfigurations
{
    /// <summary>
    /// Define las configuraciones de un <see cref="Propietario"/> para EntityFramework.
    /// </summary> 

    internal class PropietarioFluentConfiguration : IEntityTypeConfiguration<Propietario>
    {
        public void Configure(EntityTypeBuilder<Propietario> builder)
        {
            builder.ToTable("Propietarios");
            builder.HasBaseType<Persona>();
        }
    }
}
