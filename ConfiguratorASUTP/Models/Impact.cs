using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Impacts")]
    public class Impact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ImpactType Type { get; set; }        
        public virtual List<Part> Parts { get; set; }
        public Impact()
        {
            Parts = new List<Part>();
        }
    }
}