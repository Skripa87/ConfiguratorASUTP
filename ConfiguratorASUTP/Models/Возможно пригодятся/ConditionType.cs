using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("ConditionTypes")]
    public class ConditionType
    {
        [Key]
        public int ConditionTypeId { get; set; }
        public string ConditionTypeName { get; set; }
        public string ConditionNonActivateClasses { get; set; }
    }
}