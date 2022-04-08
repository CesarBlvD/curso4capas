using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            
            return DCategoria.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            
            return DCategoria.Buscar(Valor);
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            
            string Existe = DCategoria.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;
                return DCategoria.Insertar(obj);
            }    
        }
        public static string Actualizar(int Id, string Nombre, string Descripcion)
        {
            

            string Existe = DCategoria.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria
                {
                    IdCategoria = Id,
                    Nombre = Nombre,
                    Descripcion = Descripcion
                };
                return DCategoria.Actualizar(obj);
            }
        }
        public static string Eliminar(int Id)
        {
            return DCategoria.Eliminar(Id);
        }
        public static string Activar (int Id)
        {
            return DCategoria.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            return DCategoria.Desactivar(Id);
        }
    }
}
