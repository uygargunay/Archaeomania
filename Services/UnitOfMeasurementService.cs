using Domain;

namespace Services
{
    public class UnitOfMeasurementService : IUnitOfMeasurementService
    {
        #region Public Methods
        public double ConvertUnit(Enums.UnitOfMeasurement toUnit)
        {
            switch (toUnit)
            {
                case Enums.UnitOfMeasurement.Inches:
                    return FromMilliarchieopsToInches();
                case Enums.UnitOfMeasurement.Centimeters:
                    return FromMilliarchieopsToCentimeters();
                default:
                    return 1;
            }
        }
        public double FromMilliarchieopsToInches() => 0.14;
        public double FromMilliarchieopsToCentimeters() => 0.35;
        public double FromInchesToMilliarchieops() => 7;
        public double FromCentimetersToMilliarchieops() => 2.85;
        #endregion
    }
}
