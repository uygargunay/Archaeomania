using Services.ViewModel;
using System.Collections.Generic;
using Domain;

namespace Services
{
    public interface IBirdService
    {
        /// <summary>
        /// Gets all birds from cache
        /// </summary>
        /// <returns></returns>
        IEnumerable<Bird> GetBirds(Enums.UnitOfMeasurement unitOfMeasurement = Enums.UnitOfMeasurement.Milliarchieops);
        /// <summary>
        /// Gets specific bird from bird collection 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Bird GetSpecificBird(int id);
        /// <summary>
        /// Adds a bird to collection cache
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        IEnumerable<Bird> AddBird(Bird bird);
        /// <summary>
        /// Removes a bird from collection cache
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        bool RemoveBird(Bird bird);
        /// <summary>
        /// Updates a bird from collection cache
        /// </summary>
        /// <param name="bird"></param>
        /// <returns></returns>
        bool UpdateBird(Bird bird);
        /// <summary>
        /// Gets the next unique id from collection
        /// </summary>
        /// <returns></returns>
        int GetNextId();
        /// <summary>
        /// Adds a specific bone to skeleton
        /// </summary>
        /// <param name="bird"></param>
        /// <param name="skeletonType"></param>
        /// <param name="skeletonLength"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Bird AddBoneToSkeleton(Bird bird, string skeletonType, string skeletonLength, out string message);
    }
}