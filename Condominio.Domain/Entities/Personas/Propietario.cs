using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Domain.Entities.Propietarios
{
    public class Propietario : Persona
    {
        #region Constructor
        public Propietario(string nombre, int ci, int telefono, Vivienda vivienda):base(nombre, ci, telefono, vivienda)
        {

        }
        protected Propietario() { } 
        
        #endregion
    }
}
