using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Estante
    {
        #region Atributos
        private Producto[] _productos;
        private int _ubicacionEstante;
        #endregion Atributos

        #region Constructores
        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }
        #endregion Constructores

        #region Métodos
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            string aux = "";
            for (i = 0; i < e._productos.Length; i++)
            {
                aux += Producto.MostrarProducto(e._productos[i]);
            }

            return "Estanteria: " + e._ubicacionEstante.ToString() + "\nCon los productos:" + aux;
        }
        #endregion Métodos

        #region Sobrecargas

        public static bool operator ==(Estante e, Producto p)
        {
            int i;
            for (i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p) //Optimizar este código
        {
            int largo = e._productos.Length;
            int i;
            bool hayCapacidad = false;
            bool estaRepetido = true;
            int lugarVacio = -1;

            for (i = 0; i < largo; i++)
            {
                if (e._productos[i] is null)
                {
                    lugarVacio = i;
                    hayCapacidad = true;
                    break;
                }
            }

            if (hayCapacidad)
            {
                for (i = 0; i < largo; i++)
                {
                    if (e._productos[i] != p)
                    {
                        estaRepetido = false;
                        break;
                    }
                }
            }

            if (hayCapacidad && estaRepetido == false)
            {
                e._productos[lugarVacio] = p;
                return true;
            }

            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    e._productos[i] = null;
                    break;
                }
            }
            return e;
        }

        #endregion



    }
}
