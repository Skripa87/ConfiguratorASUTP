using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Profields")]
    public class Profield
    {
        [Key]
        public int ProfieldId { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public virtual List<Part> Parts { get; set; } 
        public Profield()
        {
            Parts = new List<Part>();
        }
    }
}