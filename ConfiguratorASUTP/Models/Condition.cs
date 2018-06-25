using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Conditions")]
    public class Condition
    {
        [Key]
        public int ConditionId { get; set; }
        public string ConditionName { get; set; }
        public ConditionType ConditionType { get; set; }
        public string ConditionClass { get; set; }
        public List<Property> ConditionClassProperties { get; set; }
        public bool isRangeConditionTypeValues { get; set; }
        public string ConditionActivateValues { get; set; }
        public bool ConditionState { get; set; }
        public Condition()
        {
            ConditionClassProperties = new List<Property>();
        }
    }
}