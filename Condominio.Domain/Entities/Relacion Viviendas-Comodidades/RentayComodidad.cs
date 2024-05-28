using Condominio.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Relacion_Viviendas_Comodidades
{
    public class RentayComodidad:Entity
    {
        public int Comodidad_ID { get; set; }
        public int Vivienda_Renta_ID { get; set; }

    }
}
