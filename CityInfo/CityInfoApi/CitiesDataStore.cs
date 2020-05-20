using CityInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "City never sleeps",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Centeral Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDto()
                        { 
                            Id = 2,
                            Name = "Statue Of Liberty",
                            Description = "Iconic landmark of the New York city"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Singapore",
                    Description = "City garden and lakes",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Marina Bay Sands",
                            Description = "A new landmark",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Universal Studio",
                            Description = "A great place to visit."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Hyderabad",
                    Description = "Pearl city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Charminar",
                            Description = "An iconic landmark of the city"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Budda statue",
                            Description = "A great Sculpture made from single stone."
                        }
                    }
                }
            };
        }
    }
}
