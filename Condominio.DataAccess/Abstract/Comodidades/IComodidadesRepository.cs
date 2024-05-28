using Condominio.Domain.Entities.Comodidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Abstract.Comodidades
{
    public interface  IComodidadesRepository:IRepository
    {
         
        /// <summary>
        /// Crea una comodidad en BD.
        /// </summary>
        /// <param name="nombre">Identificador de la comodidad.</param>
        /// <param name="valor">Valor de la comodidad.</param>
        /// <returns></returns>
        Comodidad CreateComodidad(string nombre, int valor);


        /// <summary>
        /// Obtiene una comodidad de BD.
        /// </summary>
        /// <param name="id">Identificador de la comodidad.</param>
        /// <returns>Comodidad solicitada de existir en BD, de lo contrario <see langword="null"/> </returns>
        Comodidad? GetComodidad(int id);

        /// <summary>
        /// Obtiene todos las comodidades de BD.
        /// </summary>
        /// <returns>Comodidades en BD.</returns>
        IEnumerable<Comodidad> GetAllComodidad();

        /// <summary>
        /// Actualiza una comodidad en BD.
        /// </summary>
        /// <param name="comodidad">Comodidad a actualizar.</param>
        void UpdateComodidad(Comodidad comodidad);

        /// <summary>
        /// Elimina una comodidad de BD.
        /// </summary>
        /// <param name="comodidad">Comodidad a eliminar.</param>
        void DeleteComodidad(Comodidad comodidad);

    }
}
    

