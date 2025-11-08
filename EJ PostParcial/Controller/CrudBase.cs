using System;
using EJ_PostParcial.Controller;

namespace EJ_PostParcial.Controller
{
    public class CrudBase<T> : ICRUD<T>, IModificar<T>  where T : ID
    {
        protected List<T> elementos = new();
        public virtual void Agregar(T entidad) => elementos.Add(entidad);
        public virtual void Eliminar(T entidad) => elementos.Remove(entidad);
        public virtual List<T> MostrarTodos() => elementos;
        public virtual void Modificar(T entidad)
        {
            var existente = ObtenerPorID(entidad.id);
            if (existente != null)
            {
                elementos.Remove(existente);
                elementos.Add(entidad);
            }
        }
        public virtual T ObtenerPorID(int id)
            => elementos.FirstOrDefault(e => CompararID(e, id));

        public virtual bool CompararID(T entidad, int id)
            => entidad.id == id;
    }

}