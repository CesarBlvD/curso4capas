using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    internal class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        public Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "BSISSS02DES\\SQL_DESA09";
            this.Usuario = "sa";
            this.Clave = "D3s4rr0ll0202010";
            this.Seguridad = true;

        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                //string ConnectionString;
                //Cadena.ConnectionString = $"Data Source={this.Servidor}; Initial Catalog={this.Base}; User ID={this.Usuario}; Password={this.Clave}";
                 
                Cadena.ConnectionString = $"Data Source={this.Servidor}; Initial Catalog={this.Base};";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + $"User ID ={ this.Usuario}; Password ={ this.Clave}";
                }
                else
                {

                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
                
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
