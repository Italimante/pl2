using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Dolar
    {
        #region ATRIBUTOS

        private double _cantidad;
        private float _cotizRespectoDolar;

        #endregion

        #region CONSTRUCTORES

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {

        }

        public Dolar(double cantidad, float cotizacion)
        {

        }

        #endregion

        #region GETs

        public double GetCantidad()
        {
            return 1;
        }

        public float GetCotizacion()
        {
            return 0;
        }

        #endregion

        #region SOBRECARGAS ENTRE MONEDAS

        public static explicit operator Euro(Dolar d){}
        public static explicit operator Pesos(Dolar d){}
        public static implicit operator Dolar(double d){}

        #endregion

        #region SOBRECARGAS IGUALDAD

        public static bool operator !=(Dolar d, Euro e) { }
        public static bool operator !=(Dolar d, Pesos p) { }
        public static bool operator !=(Dolar d1, Dolar d2) { }

        #endregion

        #region SOBRECARGAS RESTA

        public static Dolar operator -(Dolar d, Euro e) { }

        #endregion

    }
}
