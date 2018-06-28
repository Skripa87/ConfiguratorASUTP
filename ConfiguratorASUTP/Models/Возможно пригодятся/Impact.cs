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
        public int ImpactId { get; set; }
        public string ImpactName { get; set; }
        public string ImpactDescription { get; set; }
        public ImpactType ImpactType { get; set; }
        public List<Property> ImpactPropertyTypes { get; set; }
        public Impact()
        {
            ImpactPropertyTypes = new List<Property>();
        }
    }
}