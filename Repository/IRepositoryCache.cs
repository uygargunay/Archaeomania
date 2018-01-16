using System.Collections.Generic;

namespace Repository
{
    internal interface IRepositoryCache
    {
        /// <summary>
        /// Gets collection from cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        IEnumerable<T> GetCollection<T>(string cacheKey);

        /// <summary>
        /// Updates a collection in cache 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        IEnumerable<T> UpdateCollection<T>(List<T> t, string cacheKey);
    }
}