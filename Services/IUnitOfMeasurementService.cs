using Domain;

namespace Services
{
    public interface IUnitOfMeasurementService
    {
        /// <summary>
        /// Converts units to eachother
        /// </summary>
        /// <param name="toUnit"></param>
        /// <returns></returns>
        double ConvertUnit(Enums.UnitOfMeasurement toUnit);
        /// <summary>
        /// Converts values from Milliarchieops To Inches
        /// </summary>
        /// <returns></returns>
        double FromMilliarchieopsToInches();
        /// <summary>
        /// Converts values from Milliarchieops To Centimeters
        /// </summary>
        /// <returns></returns>
        double FromMilliarchieopsToCentimeters();
        /// <summary>
        /// Converts values from Inches To Milliarchieops
        /// </summary>
        /// <returns></returns>
        double FromInchesToMilliarchieops();
        /// <summary>
        /// Converts values from Centimeters To Milliarchieops
        /// </summary>
        /// <returns></returns>
        double FromCentimetersToMilliarchieops();
    }
}