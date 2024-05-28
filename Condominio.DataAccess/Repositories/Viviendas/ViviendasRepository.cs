using Condominio.DataAccess.Abstract;
using Condominio.Domain.Entities.Viviendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Repositories
{
    public partial class ApplicationRepository : IRepository
    {

        public Vivienda CreateVivienda(int numeracion, string direccion)
        {
            Vivienda vivienda = new Vivienda(numeracion, direccion);
            _context.Add(vivienda);
            return vivienda;
        }

        public Vivienda_Renta CreateVivienda_Renta(int precio, int numeracion, string direccion)
        {
            Vivienda_Renta vivienda_Renta = new Vivienda_Renta(precio, numeracion,direccion);
            _context.Add(vivienda_Renta);
            return vivienda_Renta;
        }

        public void DeleteVivienda(Vivienda vivienda)
        {
            _context.Remove(vivienda);
        }

        public T? GetVivienda<T>(int id) where T : Vivienda
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<Vivienda> GetAllVivienda()
        {
            return _context.Set<Vivienda>().ToList();
        }

        public void UpdateVivienda(Vivienda vivienda)
        {
            _context.Set<Vivienda>().Update(vivienda);
        }
    }
}


