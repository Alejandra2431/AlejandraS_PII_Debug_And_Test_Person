using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void nombreCorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string nombreCorrecto= "Alejandra"; 
            Person prueba= new Person(nombreCorrecto,"");
            Assert.AreEqual(nombreCorrecto,prueba.Name);           
        }
        [Test]
        public void cICorrecta()
        {
            string cICorrecta= "5.028.441-8"; 
            Person prueba= new Person("",cICorrecta);
            Assert.AreEqual(cICorrecta,prueba.ID);           
        }
        [Test]
        public void nombreIncorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string nombreIncorrecto= ""; 
            Person prueba= new Person(nombreIncorrecto,"");
            Assert.AreEqual(null,prueba.Name);           
        }
        [Test]
        public void cIIncorrecta()
        {
            string cIIncorrecta= "123123123"; 
            Person prueba= new Person("",cIIncorrecta);
            Assert.AreEqual(null,prueba.ID);           
        }
    }
}

