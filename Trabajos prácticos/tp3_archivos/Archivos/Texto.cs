using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda datos en un archivo de texto
        /// </summary>
        /// <param name="archivo">Ubicación en donde guardar</param>
        /// <param name="datos">Información a guardar</param>
        /// <returns>Retorna falso si hubo alguna excepción</returns>
        public bool Guardar(string archivo, string datos)
        {

            Directory.CreateDirectory("outArchivos");

            try
            {
                using (StreamWriter sw = File.AppendText("outArchivos/" + archivo))
                {
                    sw.WriteLine(datos);
                }
            }
            catch(Exception e)
            {
                return false;
            }

            return true;

        }

        /// <summary>
        /// Lee datos de un archivo de texto
        /// </summary>
        /// <param name="archivo">Ubicación a donde guardar</param>
        /// <param name="datos">Información a guardar</param>
        /// <returns>Retorna falso y el dato en null si hubo alguna excepción</returns>
        public bool Leer(string archivo, out string datos)
        {

            Directory.CreateDirectory("outArchivos");

            try
            {
                using (StreamReader sr = new StreamReader("outArchivos/" + archivo))
                {
                    datos = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                datos = null;
                return false;
            }

            return true;
        }

    }
}
