using System.Collections.Generic;
using System.Linq;
using Repository.DataModel;

namespace Repository
{
    /// <summary>
    /// Handles bird repository details for data
    /// </summary>
    public class BirdRepository : IBirdRepository
    {
        private readonly IRepositoryCache _repositoryCache;

        #region Constructor
        /// <summary>
        /// BirdRepository default constructor
        /// </summary>
        public BirdRepository()
        {
         _repositoryCache = new RepositoryCache();   
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Gets all the active birds from repository
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Bird> GetBirds()
        {
            object cacheObject = _repositoryCache.GetCollection<Bird>(typeof(Bird).FullName);
            return ((IEnumerable<Bird>)cacheObject).Where(b=>b.IsActive);
        }
        /// <summary>
        /// Gets the specific bird by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Bird GetSpecificBird(int id)
        {
            var bird = GetBirds().FirstOrDefault(b => b.Id == id && b.IsActive);
            return bird;
        }
        /// <summary>
        /// Adds a bird to repository
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        public IEnumerable<Bird> AddBird(Bird bird)
        {
            List<Bird> birds = GetBirds().ToList();
            bird.IsActive = true;
            birds.Add(bird);
            return _repositoryCache.UpdateCollection(birds, typeof(Bird).FullName);
        }
        /// <summary>
        /// Removes a bird from repository
        /// </summary>
        /// <param name="birdId"></param>
        /// <returns></returns>
        public IEnumerable<Bird> RemoveBird(int? birdId)
        {
            List<Bird> birds = GetBirds().ToList();
            Bird bird = birds.FirstOrDefault(b => b.Id == birdId);
            if (bird != null) bird.IsActive = false;
            return _repositoryCache.UpdateCollection(birds, typeof(Bird).FullName);
        }
        /// <summary>
        /// Updates bird details in repostory
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        public IEnumerable<Bird> UpdateBird(Bird bird)
        {
            var birds = GetBirds() as IList<Bird> ?? GetBirds().ToList();
            var birdToUpdate = birds.FirstOrDefault(b => b.Id == bird.Id);
            if (birdToUpdate != null)
            {
                birdToUpdate.BirdType = bird.BirdType;
                birdToUpdate.Girth = bird.Girth;
                birdToUpdate.Height = bird.Height;
                birdToUpdate.Length = bird.Length;
                birdToUpdate.SpecimenName = bird.SpecimenName;
                birdToUpdate.Weight = bird.Weight;
                birdToUpdate.Location.Altitude = bird.Location.Altitude;
                birdToUpdate.Location.Latitude = bird.Location.Latitude;
                birdToUpdate.Location.Longitude = bird.Location.Longitude;
                birdToUpdate.Location.Name = bird.Location.Name;
                birdToUpdate.Skeleton.Feet = bird.Skeleton.Feet;
                birdToUpdate.Skeleton.Skull = bird.Skeleton.Skull;
                birdToUpdate.Skeleton.Spine = bird.Skeleton.Spine;
                birdToUpdate.Skeleton.Tail = bird.Skeleton.Tail;
                birdToUpdate.Skeleton.Teeth = bird.Skeleton.Teeth;
                birdToUpdate.Skeleton.WeirdHandThings = bird.Skeleton.WeirdHandThings;
                birdToUpdate.Skeleton.Wings = bird.Skeleton.Wings;
            }
            return _repositoryCache.UpdateCollection(birds.ToList(), typeof(Bird).FullName);
        }
        #endregion
    }
}
