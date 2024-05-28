
using Condominio.Domain.Entities.Viviendas;
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
    /// Define las configuraciones de un <see cref="Motorcycle"/> para EntityFramework.
    /// </summary> 

    internal class Vivienda_RentaFluentConfiguration : IEntityTypeConfiguration<Vivienda_Renta>
    {
        public void Configure(EntityTypeBuilder<Vivienda_Renta> builder)
        {
            builder.ToTable("Vivienda_Rentas");
            builder.HasBaseType<Vivienda>();
        }
    }
}
