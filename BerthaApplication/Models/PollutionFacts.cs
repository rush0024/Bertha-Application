using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BerthaApplication.Models
{
    public class PollutionFacts
    {
        public double Dust { get; set; }

        public double Sulphur { get; set; }

        public double Nitrogen { get; set; }

        public double Fluor { get; set; }

        public double CarbonMonoxide { get; set; }

        public double Ozone { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}


