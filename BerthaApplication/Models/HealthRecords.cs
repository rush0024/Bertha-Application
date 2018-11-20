using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace BerthaApplication.Models
{
    public class HealthRecords
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HealthRecordId { get; set; }

        public string Location { get; set; }

        public string RecordTime { get; set; }

        public double SystolicPressure { get; set; }

        public double DiastolicPressure { get; set; }

        public double BodyTemperature { get; set; }

        public int HeartBeatPerSecond { get; set; }

        
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
