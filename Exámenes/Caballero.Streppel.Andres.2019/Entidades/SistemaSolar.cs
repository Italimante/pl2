using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planeta { get { return this.planetas; } }

        /// <summary>
        /// 22. MostrarInformacionAstros(): método que retorna toda la información de los planetas, y sus satélites.
        /// </summary>
        /// <returns></returns>
        public String MostrarInformacionAstros() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nLista de planetas del Sistema solar:");
            foreach (Planeta p in this.planetas)
            {
                sb.AppendFormat("\n{0}", p.ToString());
            }

            return sb.ToString();
        }

        private SistemaSolar() {
            this.planetas = new List<Astro>();
        }

    }
}
