using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.BaseClasses
{
    public abstract class SkeletonBase
    {
        [Range(0, 2)]
        public List<double> Wings { set; get; }
        [Range(0, 2)]
        public List<double> WeirdHandThings { set; get; }
        [Range(0, 1)]
        public List<double> Skull { set; get; }
        [Range(0, 300)]
        public List<double> Teeth { set; get; }
        [Range(0, 2)]
        public List<double> Feet { set; get; }
        [Range(0, 1)]
        public List<double> Tail { set; get; }
        [Range(0, 1)]
        public List<double> Spine { set; get; }
    }
}
