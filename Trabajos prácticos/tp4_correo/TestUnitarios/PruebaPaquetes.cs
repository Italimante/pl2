using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class PruebaPaquetes
    {

        /// <summary>
        /// 2. Verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void PaqueteMismoID()
        {
            Correo c = new Correo();
            Paquete p = new Paquete("direccion", "123");
            Paquete p2 = new Paquete("direccion", "123");

            c += p;
            c += p2;

        }

        /// <summary>
        /// 1. Realizar test que verifique que la lista de Paquetes del Correo esté instanciada.
        /// </summary>
        [TestMethod]
        public void PaqueteInstanciado()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c.Paquete);
        }


    }
}
