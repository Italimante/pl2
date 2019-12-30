using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Validará y realizará la operación pedida entre ambos números
        /// </summary>
        /// <param name="num1">Número 1</param>
        /// <param name="num2">Número 2</param>
        /// <param name="operador">Operadores: +, -, /, *</param>
        /// <returns>Si se tratara de una división por 0, retornará double.MinValue</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;
            string aux = Calculadora.ValidarOperador(operador);

            switch (aux)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    if (num1 * num2 == 0)
                    {
                        resultado = double.MinValue;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        ///  Valida que el operador recibido sea +, -, / o *
        /// </summary>
        /// <param name="operador">Recibe un string del operador</param>
        /// <returns> Retornará + si no es +, -, / o *</returns>
        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }


    }
}