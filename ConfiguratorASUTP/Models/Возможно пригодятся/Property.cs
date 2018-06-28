using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Properties")]
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public PropertyType PropertyType { get; set; }
        public string PropertyTypeValue { get; set; }
        public object PropertyValue { get; set; }
    }
}