using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WonderHorseStable.Models
{
    public class Horse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Trained { get; set; }
        public bool HasPermission { get; set; }
        public string ImageSource { get; set; }
    }
}
