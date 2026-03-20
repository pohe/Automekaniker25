using SailClubLibrary.Exceptions;
using SailClubLibrary.Interfaces;
using SailClubLibrary.Models;
using SailClubLibrary.Services;

namespace TestBoatApp2026
{
    [TestClass]
    public sealed class BoatRepositoryTest
    {
        private IBoatRepository boatRepo;

        private void Setup()
        {
            boatRepo = new BoatRepository();
        }

        [TestMethod]
        public void AddBoatTest()
        {
            //Arrange
            Setup();  


            //Act
            int beforeCount = boatRepo.Count;
            boatRepo.AddBoat(new Boat(5, BoatType.LASERJOLLE, "IC4", "233243DK", "No", 0.3, 1.2, 4, "2016"));
            int afterCount = boatRepo.Count;

            //Assert
            Assert.AreEqual(beforeCount + 1, afterCount);
        }

        [TestMethod]
        [ExpectedException(typeof(BoatSailnumberExistsException))]
        public void AddExistBoatTest_BoatSailnumberExistsException()
        {
            //Arrange
            Setup(); 
            boatRepo.AddBoat(new Boat(5, BoatType.LASERJOLLE, "IC4", "233243DK", "No", 0.3, 1.2, 4, "2016"));


            //Act

            boatRepo.AddBoat(new Boat(6, BoatType.LYNÆS, "IC5", "233243DK", "No", 0.5, 1.2, 4, "2006"));

            //Assert

        }
    }
}
