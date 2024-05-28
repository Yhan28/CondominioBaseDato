
using Condominio.Domain.Entities.Inquilinos;
using Condominio.Domain.Entities.Personas;
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
    /// Define las configuraciones de un <see cref="Inquilino"/> para EntityFramework.
    /// </summary> 

    internal class InquilinoFluentConfiguration : IEntityTypeConfiguration<Inquilino>
    {
        public void Configure(EntityTypeBuilder<Inquilino> builder)
        {
            builder.ToTable("Inquilinos");
            builder.HasBaseType<Persona>();
        }
    }
}
