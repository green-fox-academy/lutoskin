using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WonderHorseStable.Models;
using WonderHorseStable.Repositories;

namespace WonderHorseStable.Services
{
    public class StableService
    {
        private StableContext stableContext;

        public StableService(StableContext stableContext)
        {
            this.stableContext = stableContext;
        }

        public List<Horse> GetHorses()
        {
            return stableContext.Horses.ToList();
        }

        public void AddHorse(Horse horse)
        {
            stableContext.Horses.Add(horse);
            stableContext.SaveChanges();
        }

        public void ChangeToTrained(long id)
        {
            GetHorseById(id).Trained = true;
            stableContext.SaveChanges();
        }

        public void ChangePermission(long id)
        {
            var horseImAboutToChange = GetHorseById(id);
            if (horseImAboutToChange.Trained)
            {
                horseImAboutToChange.HasPermission = (horseImAboutToChange.HasPermission) ? false : true;
                stableContext.SaveChanges();
            }         
        }

        public void DeleteRecord(long id)
        {
            var horseImAboutToDelete = GetHorseById(id);
            stableContext.Horses.Remove(horseImAboutToDelete);
            stableContext.SaveChanges();
        }

        private Horse GetHorseById(long id)
        {
            return stableContext.Horses.Where(horse => horse.Id == id).First();
        }

        internal List<Horse> SearchByName(string searchString)
        {
            searchString = (searchString is null) ? " " : searchString;
            return stableContext.Horses.Where(horse => horse.Name.ToLower().Contains(searchString.ToLower())).ToList();
        }
    }
}
