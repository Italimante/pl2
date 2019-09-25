using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision { get { return this.anio.ToString() + "º" + this.division.ToString(); } }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendFormat("\nCurso: {0}", this.AnioDivision);
            return sb.ToString();
        }

        public override bool ValidarDocumentacion(string doc)
        {

            return Regex.IsMatch(doc, pattern) //En consola ta el ejemplo

            throw new NotImplementedException();
        }
    }
}
