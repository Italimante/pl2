using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region Atributos
        private static SqlCommand comando;
        private static SqlConnection conexion;
        #endregion

        #region Constructor

        static PaqueteDAO()
        {
            try
            {
                conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=correo-sp-2017; Integrated Security = True");
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        #endregion

        #region Métodos

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;

            try
            {
                string consulta = string.Format(
                    "INSERT INTO Paquetes (direccionEntrega, trackingID, alumno) VALUES ('{0}','{1}','{2}')",
                    p.DireccionEntrega, p.TrackingID, "Andrés Caballero Streppel");

                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

        #endregion
    }
}
