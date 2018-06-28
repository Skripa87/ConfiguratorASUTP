using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Parts")]
    public class Part
    {
        [Key]
        public int Id {get;set;}
        public string Name { get; set; }
        public string Designation { get; set; }
        public Profield Profield { get; set; }
        public Position Position { get; set; }
        public virtual List<Impact> Impacts { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<Part> Parts { get; set; }
        public virtual List<Condition> Conditions { get; set; }
        public Part()
        {
            Impacts = new List<Impact>();
            Properties = new List<Property>();
            Parts = new List<Part>();
            Conditions = new List<Condition>();
        }
    }
}