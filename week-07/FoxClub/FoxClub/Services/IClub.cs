using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IClub
    {
        void AddFox(Fox fox);
        Fox GetLatestFox();
        List<Fox> GetFoxes();
    }
}
