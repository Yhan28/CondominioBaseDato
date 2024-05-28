﻿using Condominio.Domain.Entities.Comodidades;
using Condominio.Domain.Entities.Relacion_Viviendas_Comodidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Viviendas
{
    public class Vivienda_Renta:Vivienda
    {
        #region Propiedades
        /// <summary>
        /// Precio de la renta
        /// </summary>
        public int Precio { get; set; }

        [NotMapped]
        /// <summary>
        /// Comodidades de la renta
        /// </summary>
        public List<Comodidad> Comodidad { get; set; }

        /// <summary>
        /// Tabla de los ID de comodidades y viviendas de renta
        /// </summary>
        public List<RentayComodidad> RentayComodidadList { get; set; }
        #endregion

        #region Constructor
        public Vivienda_Renta(int precio, int numeracion, string direccion) : base(numeracion, direccion)
        {
            Precio = precio;
            Comodidad = new List<Comodidad>();
            RentayComodidadList = new List<RentayComodidad>();
        }

        protected Vivienda_Renta() { }
        #endregion
    }
}
