using Condominio.Domain.Entities.Inquilinos;
using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Propietarios;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Abstract.Personas
{
    public interface IPersonaRepository:IRepository
    {

        /// <summary>
        /// Crea un propietario en BD.
        /// </summary>
        /// <param name="nombre">Nombre del propietario.</param>
        /// <param name="ci">CI del propietario.</param>
        /// <param name="telefono">Telefono del propietario.</param>
        /// <param name="vivienda">CI del propietario.</param>
        /// <returns></returns>
        Propietario CreatePropietario(string nombre, int ci, int telefono, Vivienda vivienda);


        object CreateInquilino(string nombre, string fechaContrat, int ci, int telefono, int duracionContrat);

        /// <summary>
        /// Crea un inquilino en BD.
        /// </summary>
        /// <param name="nombre">Nombre del inquilino.</param>
        /// <param name="ci">CI del inquilino.</param>
        /// <param name="telefono">Telefono del inquilino.</param>
        /// <param name="vivienda">CI del inquilino.</param>
        ///  <param name="fecha_Contrat">fecha_Contrat del inquilino.</param>
        ///  <param name="duracion_Contrat">duracion_Contrat del inquilino.</param>
        /// <returns></returns>
        Inquilino CreateInquilino(string nombre, int ci, int telefono, Vivienda vivienda, string fecha_Contrat, int duracion_Contrat);

        /// <summary>
        /// Obtiene una persona de BD.
        /// </summary>
        /// <typeparam name="T">Tipo de persona a obtener.</typeparam>
        /// <param name="id">Identificador de la persona.</param>
        /// <returns>persona solicitada de existir en BD, de lo contrario <see langword="null"/> </returns>
        T? GetPersona<T>(int id) where T : Persona;

        /// <summary>
        /// Obtiene todos las personas de BD.
        /// </summary>
        /// <returns>Personas en BD.</returns>
        IEnumerable<Persona> GetAllPersona();

        /// <summary>
        /// Actualiza una persona en BD.
        /// </summary>
        /// <param name="persona">Persona a actualizar.</param>
        void UpdatePersona(Persona persona);

        /// <summary>
        /// Elimina una persona de BD.
        /// </summary>
        /// <param name="persona">Persona a eliminar.</param>
        void DeletePersona(Persona persona);

    }
}
    

