using Condominio.DataAccess.Abstract;
using Condominio.Domain.Entities.Inquilinos;
using Condominio.Domain.Entities.Personas;
using Condominio.Domain.Entities.Propietarios;
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
         
        public Propietario CreatePropietario(string nombre, int ci, int telefono, Vivienda vivienda)
        {
            Propietario propietario = new Propietario(nombre, ci, telefono, vivienda);
            _context.Add(propietario);
            return propietario;
        }

        public Inquilino CreateInquilino(string nombre, int ci, int telefono, Vivienda vivienda, string fecha_Contrat, int duracion_Contrat)
        {
            Inquilino inquilino = new Inquilino(nombre, ci, telefono, vivienda, fecha_Contrat,duracion_Contrat);
            _context.Add(inquilino);
            return inquilino;
        }

        public void DeletePersona(Persona persona)
        {
            _context.Remove(persona);
        }

        public T? GetPersona<T>(int id) where T : Persona
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<Persona> GetAllPersona()
        {
            return _context.Set<Persona>().ToList();
        }

        public void UpdatePersona(Persona persona)
        {
            _context.Set<Persona>().Update(persona);
        }
    }
}
    

