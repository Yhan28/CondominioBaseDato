using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Inquilinos
{
    public class Inquilino : Persona
    {
        #region Propiedades
        /// <summary>
        /// Fecha de inicio del contrato
        /// </summary>
        public string Fecha_Contrat { get; set; }

        /// <summary>
        /// Duracion del contrato en años
        /// </summary>
        public int Duracion_Contrat { get; set; }


        #endregion

        #region Constructor
        public Inquilino(string nombre, int ci, int telefono, Vivienda vivienda, string fecha_Contrat, int duracion_Contrat) : base(nombre, ci, telefono, vivienda)
        {
            Fecha_Contrat = fecha_Contrat;
            Duracion_Contrat = duracion_Contrat;
        }

        protected Inquilino() { }
        #endregion
    }
}

