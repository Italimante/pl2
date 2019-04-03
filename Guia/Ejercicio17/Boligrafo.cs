using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        #region ATRIBUTOS
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;
        #endregion

        #region CONSTRUCTORES

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this._color = color;
            this._tinta = tinta;
        }

        #endregion

        #region METODOS
        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        private void SetTinta(short tinta)
        {
            if( this._tinta + tinta >= 0 && this._tinta + tinta <= cantidadTintaMaxima)
            {
                this._tinta += tinta;
            }
        }

        public void Recargar()
        {
            this._tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            this._tinta -= gasto;
            dibujo = "*";
            return true;
        }
        
        
        #endregion


    }
}
