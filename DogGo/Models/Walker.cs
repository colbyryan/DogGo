using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models
{
    public class Walker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        [DisplayName("Profile Picture")]
        public string ImageUrl { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public object Duration { get; internal set; }
    }
}