using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace RepositoryTests
{
    [TestClass()]
    public class UnitOfMeasurementServiceTests
    {
        [TestMethod()]
        public void ConvertUnitTest()
        {
            UnitOfMeasurementService unitOfMeasurementService = new UnitOfMeasurementService();
            double result = unitOfMeasurementService.ConvertUnit(Enums.UnitOfMeasurement.Inches);
            if (Math.Abs(result - 0.14) > 0)
                Assert.Fail();
            result = unitOfMeasurementService.ConvertUnit(Enums.UnitOfMeasurement.Centimeters);
            if (Math.Abs(result - 0.35) > 0)
                Assert.Fail();
        }
    }
}