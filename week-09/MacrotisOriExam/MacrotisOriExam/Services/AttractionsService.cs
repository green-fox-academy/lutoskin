using MacrotisOriExam.Models;
using MacrotisOriExam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisOriExam.Services
{
    public class AttractionsService
    {
        private AttractionsRepository attractionsRepository;

        public AttractionsService(AttractionsRepository attractionsRepository)
        {
            this.attractionsRepository = attractionsRepository;
        }

        public List<Attractions> GetAttractions()
        {
            return attractionsRepository.GetAttractions();
        }

        public void AddAttraction(Attractions attraction)
        {
            attractionsRepository.AddAttraction(attraction);
        }

        public void EditAttraction(Attractions attraction)
        {
            attractionsRepository.EditAttraction(attraction);
        }

        public Attractions GetAttractionById(int id)
        {
            return attractionsRepository.GetAttractionById(id);
        }

        public List<Attractions> GetAttractionsByCategoryAndCity(string category, string city)
        {
            if (city is null || category is null)
            {
                return GetAttractions();
            }
            else if (category is null)
            {
                return attractionsRepository.GetAttractionsByCity(city);
            }
            else if (city is null)
            {
                return attractionsRepository.GetAttractionsByCategory(category);
            }
            return attractionsRepository.GetAttractionsByCategoryAndCity(category, city);         
        }
    }
}
