using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.BaseClasses
{
    public abstract class BirdBase
    {
        [Browsable(false)]
        public int? Id { set; get; }
        public double Height { set; get; }
        public double Weight { set; get; }
        public double Length { set; get; }
        public double Girth { set; get; }
        public string SpecimenName { set; get; }
        [Required(ErrorMessage = "Each bird must have a bird type.")]
        public Enums.BirdType BirdType { set; get; }
        [Browsable(false)]
        public bool IsActive { set; get; }
    }
}
