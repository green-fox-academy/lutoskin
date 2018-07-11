using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisOriExam.Models
{
    public class FilterDTO
    {
        public string Result { get; set; }
        public int Count { get; set; }
        public List<Attractions> Attractions { get; set; }
    }
}
