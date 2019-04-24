using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Provincial:Llamada
    {
        #region Fields
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja franjaHoraria;
        #endregion

        #region Properties

        public float CostoLllamada { get { return CalcularCosto(); } }

        #endregion

        #region Builder
        public Provincial(Franja miFranja, Llamada llamada)
        {

        }
        public Provincial()
        #endregion

        #region Methods
        private float CalcularCosto()
        {
            return 0;
        }
        public string Mostrar()
        {
            return "";
        }
        #endregion

    }
}
