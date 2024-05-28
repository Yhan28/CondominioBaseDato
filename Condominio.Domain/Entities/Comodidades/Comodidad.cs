using Condominio.Domain.Entities.Common;
using Condominio.Domain.Entities.Relacion_Viviendas_Comodidades;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Comodidades
{
    public class Comodidad:Entity
    {
        #region Propiedades
        /// <summary>
        /// Nombre de la comodidad
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Valor de cuanto encarece el valor de la vivienda
        /// </summary>
        public int Valor { get; set; }

        /// <summary>
        /// Lista de todas las viviendas con esa comodidad
        /// </summary>
        public List<Vivienda_Renta> Vivienda_Renta_List { get; set; }

        /// <summary>
        /// Tabla de los ID de comodidades y viviendas de renta
        /// </summary>
        public List<ViviendasyComodidad> Relacion_List { get; set; }
        #endregion

        #region Constructor
        public Comodidad (string nombre,int valor) {

            Nombre = nombre;
            Valor = valor;
            Vivienda_Renta_List = new List<Vivienda_Renta> ();
            Relacion_List = new List<ViviendasyComodidad> ();
        }

        protected Comodidad() { }
        #endregion
    }
}
