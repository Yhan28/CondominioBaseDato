using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Abstract.Viviendas
{
    public interface  IViviendaRepository
    {

        /// <summary>
        /// Crea una vivienda en BD.
        /// </summary>
        /// <param name="numeracion">Numeracion de la vivienda.</param>
        /// <param name="direccion">Direccion de la vivienda.</param>
        /// <returns></returns>
        Vivienda CreateVivienda(int numeracion, string direccion);

        /// <summary>
        /// Crea una vivienda en BD.
        /// </summary>
        /// <param name="precio">Precio de la renta.</param>
        /// <param name="numeracion">Numeracion de la vivienda de renta.</param>
        /// <param name="direccion">Direccion de la vivienda de renta.</param>
        /// <returns></returns>
        Vivienda_Renta CreateVivienda_Renta(int precio, int numeracion, string direccion);


        /// <summary>
        /// Obtiene una vivienda de BD.
        /// </summary>
        /// <typeparam name="T">Tipo de vivienda a obtener.</typeparam>
        /// <param name="id">Identificador de la vivienda.</param>
        /// <returns>Vivienda solicitada de existir en BD, de lo contrario <see langword="null"/> </returns>
        T? GetVivienda<T>(int id) where T : Vivienda;

        /// <summary>
        /// Obtiene todos las viviendas de BD.
        /// </summary>
        /// <returns>Viviendas en BD.</returns>
        IEnumerable<Vivienda> GetAllVivienda();

        /// <summary>
        /// Actualiza una vivienda en BD.
        /// </summary>
        /// <param name="vivienda">Vivienda a actualizar.</param>
        void UpdateVivienda(Vivienda vivienda);

        /// <summary>
        /// Elimina una vivienda de BD.
        /// </summary>
        /// <param name="vivienda">Vivienda a eliminar.</param>
        void DeleteVivienda(Vivienda vivienda);

    }
}
