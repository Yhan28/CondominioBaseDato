
using Condominio.Domain.Entities.Common;
using Condominio.Domain.Entities.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Viviendas
{
    public class Vivienda:Entity
    {
        #region Propiedades
       /// <summary>
       /// Identificador de la casa
       /// </summary>
        public int Numeracion { get; set; }

        /// <summary>
        /// Direccion exacta de la casa
        /// </summary>
        public string Direccion { get; set; }

        [NotMapped]
        /// <summary>
        /// Personas que hay en la casa 
        /// </summary>
        public List<Persona> Personas { get; set; }       

        #endregion


        #region Constructor
        public Vivienda(int numeracion,string direccion)
        {
            Numeracion = numeracion;
            Direccion = direccion;
            Personas = new List<Persona>();
        }

        protected Vivienda() { }
        #endregion

    }
}
