using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos

        private double numero;

        #endregion

        #region Propiedades

        /// <summary>
        /// SetNumero asignará un valor al atributo numero, previa validación.
        /// En este lugar será el único en todo el código que llame al método ValidarNumero
        /// </summary>
        private String SetNumero
        {

            set
            {
                this.numero = ValidarNumero(value.ToString());
            }

        }

        #endregion

        #region Constructores

        public Numero() : this(0)
        {

        }

        public Numero(double numero) : this(numero.ToString())
        {

        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Comprueba que el valor recibido sea numérico.
        /// </summary>
        /// <param name="strNumero">Valor a validar/convertir, si es posible, en Double.</param>
        /// <returns>Retorna el valor en formato Double. Caso contrario, retorna 0.
        /// Y si le paso un cero como hago para comprobar que sea un número válido?
        /// </returns>
        private static double ValidarNumero(string strNumero)
        {
            double aux = 0;
            bool resultado = double.TryParse(strNumero, out aux);
            if (resultado)
            {
                return double.Parse(strNumero);
            }
            return 0;
        }
        /// <summary>
        /// El método BinarioDecimal convertirá un número binario a decimal
        /// </summary>
        /// <param name="binario">String binario</param>
        /// <returns> Caso contrario retornará "Valor inválido"</returns>
        public static string BinarioDecimal(string binario)
        {
            int n = 0;
            bool flag = true;

            for (int x = binario.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (binario[x] == '0' || binario[x] == '1')
                {
                    n += (int)(int.Parse(binario[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    flag = false;
                }
            }

            if (flag)
            {
                return n.ToString();
            }
            else
            {
                return "Valor inválido";
            }

        }
        /// <summary>
        ///  convertirán un número decimal a binario, en caso de ser posible.
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>El numero binario si esta todo correcto, de lo contrario; Valor inválido.</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int n = Math.Abs((int)numero);

            if (n > 0)
            {
                while (true)
                {
                    if ((n % 2) != 0)
                    {
                        binario = "1" + binario;
                    }
                    else
                    {
                        binario = "0" + binario;
                    }
                    n /= 2;

                    if (n <= 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                return "Valor inválido";
            }


            return binario;
        }
        /// <summary>
        /// Sobrecarga. Convertirá un número decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El binario si esta todo correcto, o valor inválido si hubo error.</returns>
        public static string DecimalBinario(string numero)
        {
            double aux = 0;
            bool sucess = double.TryParse(numero, out aux);
            if (sucess)
            {
                return Numero.DecimalBinario(double.Parse(numero));
            }
            else
            {
                return "Valor inválido";
            }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Resta dos valores
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Multiplica dos números
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>Resultado de la multiplicación</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide dos números
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>La división de ambos números, salvo que tenga que dividr por cero donde retornaría minValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }

        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Número 2</param>
        /// <returns>La suma de ambos números</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        #endregion

    }
}
