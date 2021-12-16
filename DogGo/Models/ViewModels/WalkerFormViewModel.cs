using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models.ViewModels
{
    public class WalkerFormViewModel
    {
        public List<Walk> Walks { get; set; }
        public Walker Walker { get; set; }
        public string TotalWalkTime 
        { 
            get
            {
                var totalMinutes = Walks.Select(w => w.Duration).Sum() / 60;
                var totalHours = totalMinutes / 60;
                var minutes = totalMinutes % 60;
                return $"Hours: {totalHours} Minutes: {minutes}";
            }
        }
    }
}
