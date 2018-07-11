using MacrotisOriExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisOriExam.Repositories
{
    public class AttractionsRepository
    {
        private AttractionContext attractionContext;

        public AttractionsRepository(AttractionContext attractionContext)
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

        public void EditAttraction(Attractions attraction)
        {
            attractionContext.Attractions.Update(attraction);
            attractionContext.SaveChanges();
        }

        public Attractions GetAttractionById(int id)
        {
            return attractionContext.Attractions.First(attr => attr.Id == id);
        }

        public List<Attractions> GetAttractionsByCategoryAndCity(string category, string city)
        {
            return attractionContext.Attractions.Where(n => n.City.Contains(city)).Where(n => n.Category.Contains(category)).ToList();
        }

        public List<Attractions> GetAttractionsByCity(string city)
        {
            return attractionContext.Attractions.Where(n => n.City.Contains(city)).ToList();
        }

        public List<Attractions> GetAttractionsByCategory(string category)
        {
            return attractionContext.Attractions.Where(cat => cat.Category.Contains(category)).ToList();
        }
    }
}
