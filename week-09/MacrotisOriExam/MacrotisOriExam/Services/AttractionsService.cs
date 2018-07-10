using MacrotisOriExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisOriExam.Services
{
    public class AttractionsService
    {
        private AttractionContext attractionContext;

        public AttractionsService(AttractionContext attractionContext)
        {
            this.attractionContext = attractionContext;
        }

        public List<Attractions> GetAttractions()
        {
            return attractionContext.Attractions.ToList();
        }

        public void AddAttraction(Attractions attraction)
        {
            attractionContext.Attractions.Add(attraction);
            attractionContext.SaveChanges();
        }

        public void EditAttraction(int id)
        {
            attractionContext.Attractions.Update(GetAttractionById(id));
        }

        public Attractions GetAttractionById(int id)
        {
            return attractionContext.Attractions.Where(attr => attr.Id == id).First();
        }

        public List<Attractions> GetAttractionsByNameAndCategory(string category, string city)
        {
            if (city is null || category is null)
            {
                return GetAttractions();
            }
            else if (category is null)
            {
                return GetAttractionsByCity(city);
            }
            else if (city is null)
            {
                return GetAttractionsByCategory(category);
            }  
            return attractionContext.Attractions.Where(n => n.City == city).Where(n => n.Category == category).ToList();
        }

        public List<Attractions> GetAttractionsByCity(string city)
        {
            return attractionContext.Attractions.Where(n => n.City == city).ToList();
        }

        public List<Attractions> GetAttractionsByCategory(string category)
        {
            return attractionContext.Attractions.Where(cat => cat.Category == category).ToList();
        }
    }
}
