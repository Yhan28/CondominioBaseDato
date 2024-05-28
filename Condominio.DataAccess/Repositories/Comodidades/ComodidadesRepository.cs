using Condominio.DataAccess.Abstract;
using Condominio.Domain.Entities.Comodidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DataAccess.Repositories
{
    public partial class ApplicationRepository : IRepository
    {
         
        public Comodidad CreateComodidad(string nombre, int valor)
        {
            Comodidad comodidad = new Comodidad(nombre, valor);
            _context.Add(comodidad);
            return comodidad;
        }

     
        public void DeleteComodidad(Comodidad comodidad)
        {
            _context.Remove(comodidad);
        }

        public Comodidad? GetComodidad<T>(int id)
        {
            return _context.Set<Comodidad>().Find(id);
        }

        public IEnumerable<Comodidad> GetAllComodidad()
        {
            return _context.Set<Comodidad>().ToList();
        }

        public void UpdateComodidad(Comodidad comodidad)
        {
            _context.Set<Comodidad>().Update(comodidad);
        }
    }
}
    

