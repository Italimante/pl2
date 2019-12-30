using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;
using Archivos;

namespace TestUnitarios
{
    /// <summary>
    ///a. Generar al menos dos test unitario que validen Excepciones
    /// </summary>
    [TestClass]
    public class PruebaExcepciones
    {
        /// <summary>
        /// Prueba la excepción: DniInvalidoException
        /// Cuando reciba una letra en el DNI, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoConLetra()
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
        public void TestDniInvalidoVacio()
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
        public void TestDniInvalidoCaracterInvalido()
        {
            Alumno a = new Alumno();
            ///Pruebo con caracter especial
            a.StringToDNI = "4#0144@566";
        }

        /// <summary>
        /// Prueba la excepción: NacionalidadInvalidaException
        /// Cuando recibe una Nacionalidad incorrecta, debería ser extranjero, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaExceptionExtranjero()
        {
            try
            {
                //Debería ser extranjero por el DNI, pero le paso que es Argentino
                Alumno a = new Alumno(1,"Fulano","Mengano", "90000000",Persona.ENacionalidad.Argentino,Universidad.EClases.Laboratorio);
                Assert.Fail();
            }
            catch (NacionalidadInvalidaException e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// Prueba la excepción: NacionalidadInvalidaException
        /// Cuando recibe una Nacionalidad incorrecta, debería ser Argentino, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaExceptionArgentino()
        {
            try
            {
                //Debería ser extranjero por el DNI, pero le paso que es Argentino
                Alumno a = new Alumno(1, "Fulano", "Mengano", "89999999", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
                Assert.Fail();
            }
            catch (NacionalidadInvalidaException e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

    }

    /// <summary>
    /// b. Generar al menos uno que valide un valor numérico
    /// </summary>
    [TestClass]
    public class PruebaValorNumerico
    {
        /// <summary>
        /// Chequear si el DNI que le pase como string se convirtió correctamente en entero
        /// </summary>
        [TestMethod]
        public void ValorDniNumerico()
        {
            Alumno a = new Alumno(1,"a","b","40144566",Persona.ENacionalidad.Argentino,Universidad.EClases.Laboratorio);
            Assert.IsTrue(40144566 == a.DNI);
            //Assert.AreEqual(a.DNI, 401441566);
        }

        /// <summary>
        /// Prueba la excepción: DniInvalidoException
        /// Cuando reciba una letra en el DNI, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniNumericoFueraDeRango()
        {
            Alumno a = new Alumno();
            a.DNI = 401445669;
        }

        /// <summary>
        /// Prueba la excepción:
        /// DniInvalidoException
        /// Cuando reciba un cero en el DNI, en Alumno que hereda de Persona
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniNumericoCero()
        {
            Alumno a = new Alumno();
            a.DNI = 0;
        }
    }

    /// <summary>
    /// c. Generar al menos uno que valide que no haya valores nulos en algún atributo de las clases dadas. 
    /// </summary>
    [TestClass]
    public class ValidarValoresNulos
    {
        /// <summary>
        /// Prueba que al generar una jornada, no tenga un alumnos nulos
        /// </summary>
        [TestMethod]
        public void JornadaNula()
        {
            Jornada j = new Jornada();
            Assert.IsNotNull(j.Alumnos);
        }

        /// <summary>
        /// Prueba que al generar una universidad, no tenga un alumnos nulos
        /// </summary>
        [TestMethod]
        public void UniversidadConAlumnosNulos()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Alumnos);
        }

        /// <summary>
        /// Prueba que al generar una universidad, no tenga un profesores nulos
        /// </summary>
        [TestMethod]
        public void UniversidadConProfesoresNulos()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Instructores);
        }

        /// <summary>
        /// Prueba que al generar una universidad, no tenga un jornadas nulas
        /// </summary>
        [TestMethod]
        public void UniversidadConJornadasNulas()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Jornadas);
        }

    }
}
