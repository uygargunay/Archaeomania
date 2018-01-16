using System.Collections.Generic;
using Repository.DataModel;

namespace Repository
{
    public interface IBirdRepository
    {
        /// <summary>
        /// Gets all the active birds from repository
        /// </summary>
        /// <returns></returns>
        IEnumerable<Bird> GetBirds();
        /// <summary>
        /// Gets the specific bird by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Bird GetSpecificBird(int id);
        /// <summary>
        /// Adds a bird to repository
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        IEnumerable<Bird> AddBird(Bird bird);
        /// <summary>
        ///  Removes a bird from repository
        /// </summary>
        /// <param name="birdId"></param>
        /// <returns></returns>
        IEnumerable<Bird> RemoveBird(int? birdId);
        /// <summary>
        /// Updates bird details in repostory
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        IEnumerable<Bird> UpdateBird(Bird bird);
    }
}