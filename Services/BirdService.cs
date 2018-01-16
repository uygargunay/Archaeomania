using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Repository;
using Services.DTO;
using Services.ViewModel;

namespace Services
{
    public class BirdService : IBirdService
    {
        private readonly IBirdRepository _birdRepository;
        private readonly IUnitOfMeasurementService _unitOfMeasurementService;

        #region Constructor
        public BirdService()
        {
            _birdRepository = new BirdRepository();
            _unitOfMeasurementService = new UnitOfMeasurementService();
        }
        #endregion
        #region Public Methods
        public IEnumerable<Bird> AddBird(Bird bird)
        {
            var birdsData = _birdRepository.AddBird(BirdDto.FromBirdModelToBirdData(bird));
            return birdsData.Select(BirdDto.FromBirdDataToBirdModel);
        }

        public IEnumerable<Bird> GetBirds(Enums.UnitOfMeasurement unitOfMeasurement = Enums.UnitOfMeasurement.Milliarchieops)
        {
            var birdsData = _birdRepository.GetBirds();
            var birdsModel = birdsData.Select(BirdDto.FromBirdDataToBirdModel);
            double umTimes = _unitOfMeasurementService.ConvertUnit(unitOfMeasurement);
            List<Bird> list = new List<Bird>();
            var birds = birdsModel as IList<Bird> ?? birdsModel.ToList();
            foreach (var bird in birds)
                list.Add(bird);
            list.ForEach(b =>
            {
                b.Height = Math.Round(b.Height*umTimes,2);
                b.Length = Math.Round(b.Length*umTimes,2);
                b.Girth = Math.Round(b.Girth*umTimes,2);

            });
            return birds;

        }

        public Bird GetSpecificBird(int birdId)
        {
            var birdData = _birdRepository.GetSpecificBird(birdId);
            return  BirdDto.FromBirdDataToBirdModel(birdData);
        }

        public bool RemoveBird(Bird bird)
        {
            _birdRepository.RemoveBird(bird.Id);
            return true;
        }

        public bool UpdateBird(Bird bird)
        {
            _birdRepository.UpdateBird(BirdDto.FromBirdModelToBirdData(bird));
            return true;
        }

        public int GetNextId()
        {
            var lastBird = _birdRepository.GetBirds().OrderByDescending(b=>b.Id).FirstOrDefault();
            if (lastBird?.Id != null)
                return (int) (lastBird.Id + 1);
            return 1;
        }

        public Bird AddBoneToSkeleton(Bird bird, string skeletonType, string skeletonLength, out string message)
        {
            message = "";
            if (bird.Skeleton == null)
                bird.Skeleton = new Skeleton();
            switch (skeletonType)
            {
                case "Wings":
                    {
                        if (bird.Skeleton.Wings == null)
                            bird.Skeleton.Wings = new List<double>();
                        if (bird.Skeleton.Wings?.Count == 2)
                        {
                            message = "A bird can't have more than 2 wings";
                            break;
                        }
                        bird.Skeleton.Wings.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "WeirdHandThings":
                    {
                        if (bird.Skeleton.WeirdHandThings == null)
                            bird.Skeleton.WeirdHandThings = new List<double>();
                        if (bird.Skeleton.WeirdHandThings?.Count == 2)
                        {
                            message = "A bird can't have more than 2 weird hand things";
                            break;
                        }
                        bird.Skeleton.WeirdHandThings.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "Skull":
                    {
                        if (bird.Skeleton.Skull == null)
                            bird.Skeleton.Skull = new List<double>();
                        if (bird.Skeleton.Skull?.Count == 1)
                        {
                            message = "A bird can't have more than 1 skull";
                            break;
                        }
                        bird.Skeleton.Skull.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "Teeth":
                    {
                        if (bird.Skeleton.Teeth == null)
                            bird.Skeleton.Teeth = new List<double>();
                        if (bird.Skeleton.Teeth?.Count == 300)
                        {
                            message = "A bird can't have more than 300 teeth";
                            break;
                        }
                        bird.Skeleton.Teeth.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "Feet":
                    {
                        if (bird.Skeleton.Feet == null)
                            bird.Skeleton.Feet = new List<double>();
                        if (bird.Skeleton.Feet?.Count == 2)
                        {
                            message = "A bird can't have more than 2 feet";
                            break;
                        }
                        bird.Skeleton.Feet.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "Tail":
                    {
                        if (bird.Skeleton.Tail == null)
                            bird.Skeleton.Tail = new List<double>();
                        if (bird.Skeleton.Tail?.Count == 1)
                        {
                            message = "A bird can't have more than 1 tail";
                            break;
                        }
                        bird.Skeleton.Tail.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
                case "Spine":
                    {
                        if (bird.Skeleton.Spine == null)
                            bird.Skeleton.Spine = new List<double>();
                        if (bird.Skeleton.Spine?.Count == 1)
                        {
                            message = "A bird can't have more than 1 spine";
                            break;
                        }
                        bird.Skeleton.Spine.Add(Convert.ToDouble(skeletonLength));
                        break;
                    }
            }
            return bird;
        }
        #endregion
    }
}
