using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace Repository
{
    sealed class RepositoryCache : IRepositoryCache
    {
        #region Private Methods
        /// <summary>
        /// Creates a cache object if the cache key doesn't exists. 
        /// Returns cache object if the cache key exists
        /// Cache is used as a repository in this project
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        private ObjectCache GetCache<T>(string cacheKey)
        {
            ObjectCache cache = MemoryCache.Default;
            if (cache.Contains(cacheKey))
                return cache;
            // Store data in the cache    
            IEnumerable cacheCollection = new List<T>();
            cache.Add(cacheKey, cacheCollection, AssignCachePolicy());
            return cache;
        }
        /// <summary>
        /// Assigns a policy to cache
        /// </summary>
        /// <returns></returns>
        private CacheItemPolicy AssignCachePolicy()
        {
            return  new CacheItemPolicy { AbsoluteExpiration = DateTime.Now.AddHours(10.0) };
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Gets collection from cache
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        public IEnumerable<T> GetCollection<T>(string cacheKey)
        {
            ObjectCache cache = GetCache<T>(cacheKey);
            return (IEnumerable<T>) cache.Get(cacheKey);
        }
        /// <summary>
        /// Updates a collection in cache 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        public IEnumerable<T> UpdateCollection<T>(List<T> t, string cacheKey)
        {
            ObjectCache cache = GetCache<T>(cacheKey);
            cache.Set(cacheKey, t, AssignCachePolicy());
            return GetCollection<T>(cacheKey);
        }
        #endregion
    }
}
