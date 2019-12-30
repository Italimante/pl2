using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Archivos;

namespace PruebasUnitarias2.cs
{
    [TestClass]
    public class PruebasUnitarias2
    {

        /// <summary>
        /// Prueba la excepción: DniInvalidoException
        /// Cuando recibe un DNI con letra, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException_ConLetra()
        {
            Alumno a = new Alumno();
            ///Pruebo con una letra en el DNI
            a.StringToDNI = "40144s566";
        }

        /// <summary>
        /// Prueba la excepción: DniInvalidoException
        /// Cuando recibe un DNI vacío, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException_Vacio()
        {
            Alumno a = new Alumno();
            ///Pruebo con el dni vacio
            a.StringToDNI = "";
        }

        /// <summary>
        /// Prueba la excepción: DniInvalidoException
        /// Cuando recibe un DNI con carácter inválido, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException_CaracterInvalido()
        {
            Alumno a = new Alumno();
            ///Pruebo con caracter especial
            a.StringToDNI = "4#0144@566";
        }

        /// <summary>
        /// Prueba la excepción: NacionalidadInvalidaException
        /// Cuando recibe un DNI Argentino, pero nacionalidad Extranjera
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException_DNIArgentino()
        {
            Alumno alumnoArgentino = new Alumno();
            alumnoArgentino.Nacionalidad = Persona.ENacionalidad.Extranjero;
            alumnoArgentino.DNI = 89999955; //DNI Argentino
        }

        /// <summary>
        /// Prueba la excepción: NacionalidadInvalidaException
        /// Cuando recibe un DNI Extranjero, pero nacionalidad Argentina
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException_DNIExtranjero()
        {
            Alumno alumnoExtranjero = new Alumno();
            alumnoExtranjero.Nacionalidad = Persona.ENacionalidad.Argentino;
            alumnoExtranjero.DNI = 90000001; //DNI Extranjero
        }

        /// <summary>
        /// Prueba numérica
        /// Chequea si el DNI que se envia como string se convirtio correctamente a entero
        /// </summary>
        [TestMethod]
        public void TestValorNumerico_DNIstringAEntero()
        {
            Alumno a = new Alumno(1, "a", "b", "40144566", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Assert.IsTrue(40144566 == a.DNI);
        }

        /// <summary>
        /// Prueba numérica
        /// Chequea si el DNI que se envia como string se convirtio correctamente a entero
        /// </summary>
        [TestMethod]
        public void TestValorNumerico_DNIcero()
        {
            Alumno a = new Alumno();
            try {
                a.DNI = 0;
            }
            catch (Exception e) {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
            
        }

        /// <summary>
        /// Prueba que al generar una jornada, no tenga un alumnos nulos
        /// </summary>
        [TestMethod]
        public void TestValorNulo_JornadaSinAlumnosNulos()
        {
            Jornada j = new Jornada();
            Assert.IsNotNull(j.Alumnos);
        }

        /// <summary>
        /// Prueba que al generar una universidad, no tenga un alumnos nulos
        /// </summary>
        [TestMethod]
        public void TestValorNulo_UniversidadSinAlumnosNulos()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Alumnos);
        }

        /// <summary>
        /// Prueba que al generar una universidad, no tenga un profesores nulos
        /// </summary>
        [TestMethod]
        public void TestValorNulo_UniversidadSinProfesoresNulos()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Instructores);
        }

    }
}
