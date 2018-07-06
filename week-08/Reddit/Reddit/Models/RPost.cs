using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class RPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URLPath { get; set; }
        public int Votes { get; set; }
    }
}
