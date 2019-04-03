using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        #region ATRIBUTOS
        private int _x;
        private int _y;
        #endregion

        #region GETS
        public int GetX()
        {
            return this._x;
        }
        public int GetY()
        {
            return this._y;
        }
        #endregion

        #region CONSTRUCTORES
        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        #endregion
    }

    class Rectangulo
    {
        #region ATRIBUTOS
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;
        #endregion

        #region CONSTRUCTORES
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this._vertice1 = vertice1;
            this._vertice2 = 
            this._vertice3 = vertice3;
        }
        #endregion

        #region GET'S
        public float GetArea()
        {
            return this._area;
        }
        public float GetPerimetro()
        {
            return this._perimetro;
        }
        #endregion


        #region MÉTODOS
        public float Area()
        {
            return 0;
        }

        public float Perimetro()
        {
            return 0;
        }
        #endregion




    }
}
