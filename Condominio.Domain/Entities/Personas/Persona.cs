using Condominio.Domain.Entities.Common;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Personas
{
    public abstract class Persona:Entity
    {
        #region Propiedades
        /// <summary>
        /// Nombre de la comodidad
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Carnet de identidad
        /// </summary>
        public int CI { get; set; }

        /// <summary>
        /// Telefono
        /// </summary>
        public int Telefono { get; set; }

        [NotMapped]
        /// <summary>
        /// Vivienda en la que reside la persona
        /// </summary>
        public Vivienda Vivienda { get; set; }

        /// <summary>
        /// Relacion de personas con viviendas
        /// </summary>
        public int Vivienda_ID { get; set; }
        #endregion

        #region Constructor
        public Persona(string nombre, int ci,int telefono, Vivienda vivienda )
        {

            Nombre = nombre;
            CI = ci;
            Telefono = telefono;
            Vivienda_ID = vivienda.Id;  

        }
        protected Persona() { }
        #endregion
    }
}

