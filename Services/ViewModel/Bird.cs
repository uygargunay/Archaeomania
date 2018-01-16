using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Domain.BaseClasses;

namespace Services.ViewModel
{
    /// <summary>
    /// Bird class - Holds dimension and informaiton for a bird
    /// Visible from presentation layer
    /// </summary>
    [Serializable]
    public class Bird:BirdBase
    {
        [Browsable(false)]
        public Location Location { set; get; }
        [Required(ErrorMessage = "Each bird must have a skeleton.")]
        [Browsable(false)]
        public Skeleton Skeleton { set; get; }
        public double? Wingspan
        {
            get
            {
                return Skeleton?.Wings?.Count == 0
                    ? 0
                    : (Skeleton?.Wings?.Count == 2
                        ? Girth + Skeleton?.Wings?.Sum(w => w)
                        : Math.Round(Length/6,2) + (Skeleton?.Wings?.Sum(w => w)*2));
            }
        }
    }
}
