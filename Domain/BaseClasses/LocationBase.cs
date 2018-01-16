namespace Domain.BaseClasses
{
    public abstract class LocationBase
    {
        public string Altitude { set; get; }
        public string Latitude { set; get; }
        public string Longitude { set; get; }
        public string Name { set; get; }
    }
}
