using Repository.DataModel;
namespace Services.DTO
{
    public static class BirdDto
    {
        public static ViewModel.Bird FromBirdDataToBirdModel(Bird dataBird)
        {
            ViewModel.Bird bird = new ViewModel.Bird
            {
                Id = dataBird.Id,
                BirdType = dataBird.BirdType,
                Girth = dataBird.Girth,
                Height = dataBird.Height,
                Length = dataBird.Length,
                SpecimenName = dataBird.SpecimenName,
                Weight = dataBird.Weight,
                Location =
                    new ViewModel.Location
                    {
                        Altitude = dataBird.Location.Altitude,
                        Latitude = dataBird.Location.Latitude,
                        Longitude = dataBird.Location.Longitude,
                        Name = dataBird.Location.Name
                    },
                Skeleton =
                    new ViewModel.Skeleton
                    {
                        Feet = dataBird.Skeleton.Feet,
                        Skull = dataBird.Skeleton.Skull,
                        Spine = dataBird.Skeleton.Spine,
                        Tail = dataBird.Skeleton.Tail,
                        Teeth = dataBird.Skeleton.Teeth,
                        WeirdHandThings = dataBird.Skeleton.WeirdHandThings,
                        Wings = dataBird.Skeleton.Wings
                    }
            };
            return bird;
        }
        public static Bird FromBirdModelToBirdData(ViewModel.Bird dataBird)
        {
            Bird bird = new Bird
            {
                Id = dataBird.Id,
                BirdType = dataBird.BirdType,
                Girth = dataBird.Girth,
                Height = dataBird.Height,
                Length = dataBird.Length,
                SpecimenName = dataBird.SpecimenName,
                Weight = dataBird.Weight,
                Location =
                    new Location
                    {
                        Altitude = dataBird.Location.Altitude,
                        Latitude = dataBird.Location.Latitude,
                        Longitude = dataBird.Location.Longitude,
                        Name = dataBird.Location.Name
                    },
                Skeleton =
                    new Skeleton
                    {
                        Feet = dataBird.Skeleton.Feet,
                        Skull = dataBird.Skeleton.Skull,
                        Spine = dataBird.Skeleton.Spine,
                        Tail = dataBird.Skeleton.Tail,
                        Teeth = dataBird.Skeleton.Teeth,
                        WeirdHandThings = dataBird.Skeleton.WeirdHandThings,
                        Wings = dataBird.Skeleton.Wings
                    }
            };
            return bird;
        }
    }
}
