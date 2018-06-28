using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("ImpactTypes")]
    public class ImpactType
    {
        [Key]
        public int ImpactTypeId { get; set; }
        public string ImpactTypeName { get; set; }
    }
}