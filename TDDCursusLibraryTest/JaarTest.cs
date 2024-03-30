using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class JaarTest
    {
        [TestMethod]
        public void IsSchrikkeljaar_DeelbaarDoor100MaarNietDoor400_IsGeenSchrikkeljaar()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(false, new Jaar(1900).IsSchrikkeljaar);
        }
        // Een Jaar Deelbaar Door 4 Is Een Schrikkeljaar
        [TestMethod]
        public void IsSchrikkeljaar_DeelbaarDoor4_IsEenSchrikkeljaar()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(true, new Jaar(2012).IsSchrikkeljaar);
        }
        // Een Jaar Niet Deelbaar Door 4 Is Geen Schrikkeljaar
        [TestMethod]
        public void IsSchrikkeljaar_NietDeelbaarDoor4_IsGeenSchrikkeljaar()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(false, new Jaar(2015).IsSchrikkeljaar);
        }
        [TestMethod]
        public void IsSchrikkeljaar_DeelbaarDoor400_IsEenSchrikkeljaar()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(true, new Jaar(2000).IsSchrikkeljaar);
        }
    }
}