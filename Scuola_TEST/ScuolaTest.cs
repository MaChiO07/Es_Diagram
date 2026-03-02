using DLibrary;
namespace Scuola_TEST


{
    [TestClass]
    public sealed class ScuolaTest
    {
        [TestMethod]
        public void CalcolaMediaVoti_TEST()
        {
            // Arrange
            Studente s1 = new Studente();
            s1.Voti = new List<Voto>();
            Materia m1 = new Materia("Matematica");
            
        
            Voto v1 = new Voto();
            v1.Materia = m1;
            v1.Valore = 8;

            Voto v2 = new Voto();
            v2.Materia = m1;
            v2.Valore = 6;

            Voto v3 = new Voto();
            v3.Materia = m1;
            v3.Valore = 4;

            s1.Voti.Add(v1);
            s1.Voti.Add(v2);
            s1.Voti.Add(v3);

            double resultMedia;

            // Act
            resultMedia = Scuola.CalcolaMediaVoti(s1);

            // Assert
            Assert.AreEqual(resultMedia, 6);
        }
    }
}
