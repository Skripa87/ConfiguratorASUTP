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
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyType Type { get; set; }
        public virtual List<Value> Values { get; set; }
        public virtual List<Part> Parts { get; set; }

        public virtual List<RemoteControl> RemoteControls { get; set; }
        public Property()
        {
            Values = new List<Value>();
            Parts = new List<Part>();
            RemoteControls = new List<RemoteControl>();
        }

    }
}