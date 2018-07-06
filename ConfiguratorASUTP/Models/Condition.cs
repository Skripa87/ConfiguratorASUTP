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
        public int Id { get; set; }
        public string Name { get; set; }
        public ConditionType Type { get; set; }
        public Property ClassesProperty { get; set; }
        public string Classes { get; set; }
        public string ActivateValues { get; set; }
        public bool isRangeTypeValue { get; set; }
        public bool State { get; set; }
        public virtual List<Part> Parts {get;set;}
        public Condition()
        {
            Parts = new List<Part>();
        }

        
    }
}