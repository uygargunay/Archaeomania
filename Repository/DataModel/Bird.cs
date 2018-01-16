using System;
using Domain.BaseClasses;

namespace Repository.DataModel
{
    /// <summary>
    /// Bird class - Holds dimension and informaiton for a bird
    /// </summary>
    [Serializable]
    public class Bird:BirdBase
    {
        public Location Location { set; get; }
        public Skeleton Skeleton { set; get; }
    }
}
