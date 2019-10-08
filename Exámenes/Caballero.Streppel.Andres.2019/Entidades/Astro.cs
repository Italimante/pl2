using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro(int duraOrbita, int duraRotacion, string nombre) {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuracion orbita: {0}", this.duracionOrbita);
            sb.AppendFormat("\nDuracion rotacion: {0}", this.duracionRotacion);
            sb.AppendFormat("\nNombre: {0}", this.nombre);
            return sb.ToString();
        }

        public abstract string Orbitar();

        public virtual string Rotar() {
            return "Rotando. Tiempo Estimado: {0}" + this.duracionOrbita;
        }

        //TODO: Agregar un conversor explícito de Astro a String que retorne sólo el nombre del astro.





    }
}
