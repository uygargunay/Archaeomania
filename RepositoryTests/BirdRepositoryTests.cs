using Repository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.DataModel;
using static Domain.Enums;

namespace RepositoryTests
{ 
    [TestClass()]
    public class BirdRepositoryTests
    {
        [TestMethod()]
        public void AddBirdTest()
        {
            var mockRepository = new BirdRepository();
            mockRepository.AddBird(new Bird
            {
                BirdType = BirdType.Archie,
                Girth = 3.21,
                Id = 1,
                Height = 3.3,
                Length = 4.3,
                SpecimenName = "Archie",
                Weight = 45.4,
                Location = new Location {Altitude = "3453", Latitude = "23423", Longitude = "12341", Name = "Cypress"},
                Skeleton = new Skeleton()
             });

            mockRepository.AddBird(new Bird
            {
                BirdType = BirdType.Archie,
                Girth = 1.21,
                Id = 2,
                Height = 2.3,
                Length = 3.3,
                SpecimenName = "Archie 2",
                Weight = 15.4,
                Location = new Location { Altitude = "3453", Latitude = "23423", Longitude = "12341", Name = "Cypress" },
                Skeleton = new Skeleton()
            });
           
            if (mockRepository.GetBirds() == null)
                Assert.Fail();
        }

        [TestMethod()]
        public void GetSpecificBirdTest()
        {
            var mockRepository = new BirdRepository();
            AddBirdTest();
            Bird bird = mockRepository.GetSpecificBird(1);
            if (bird == null)
                Assert.Fail();
        }
        [TestMethod()]
        public void RemoveBirdTest()
        {
            var mockRepository = new BirdRepository();
            Bird bird = mockRepository.GetSpecificBird(1);
            List<Bird> birds = mockRepository.RemoveBird(bird.Id).ToList();
            if (birds == null)
                Assert.Fail();
        }

        [TestMethod()]
        public void UpdateBirdTest()
        {
            var mockRepository = new BirdRepository();
            AddBirdTest();
            Bird bird = mockRepository.GetSpecificBird(1);
            bird.BirdType = BirdType.Trex;
            List<Bird> birds = mockRepository.UpdateBird(bird).ToList();
            if (birds == null)
                Assert.Fail();
        }
        [TestMethod()]
        public void GetBirdsTest()
        {
            var mockRepository = new BirdRepository();
            AddBirdTest();
            var birdsCollection = mockRepository.GetBirds();
            if (birdsCollection == null)
                Assert.Fail();
        }

        [TestMethod()]
        public void RepositoryTest()
        {
            var mockRepository = new BirdRepository();
            AddBirdTest();
            GetSpecificBirdTest();
            RemoveBirdTest();
            UpdateBirdTest();
            var finalBirdsCollection = mockRepository.GetBirds();
            if (finalBirdsCollection == null)
                Assert.Fail();
        }
    }
}