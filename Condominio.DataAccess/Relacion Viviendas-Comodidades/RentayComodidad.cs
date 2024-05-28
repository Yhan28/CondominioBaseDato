using Condominio.Domain.Entities.Common;
using Condominio.Domain.Entities.Comodidades;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Relacion_Viviendas_Comodidades
{
    public class RentayComodidad:Entity
    {
        public int Comodidad_ID { get; set; }
        public int Vivienda_Renta_ID { get; set; }




        public RentayComodidad( Vivienda_Renta vivienda_Renta, Comodidad comodidades )

        {

            Comodidad_ID = comodidades.Id;

            Vivienda_Renta_ID = vivienda_Renta.Id;


        }

        public RentayComodidad() { }
    }

}
