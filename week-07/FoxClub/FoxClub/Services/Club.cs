using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;

namespace FoxClub.Services
{
    public class Club : IClub
    {
        public List<Fox> foxes;

        public Club()
        {
            foxes = new List<Fox>();
        }

        public void AddFox(Fox fox)
        {
            foxes.Add(fox);
        }

        public List<Fox> GetFoxes()
        {
           return foxes;
        }

        public Fox GetLatestFox()
        {
            return foxes[foxes.Count - 1];
        }
    }
}
