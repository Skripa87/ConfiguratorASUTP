using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Positions")]
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public double Up { get; set; }
        public double Right { get; set; }
        public double Down { get; set; }
        public double Back { get; set; }
        public virtual List<Part> Parts { get; set; }
        public Position()
        {
            Parts = new List<Part>();
        }
    }
}