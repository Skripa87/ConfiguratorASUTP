using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("RemoteControls")]
    public class RemoteControl
    {
        [Key]
        public int RemoteControl_Id { get; set; }
        public string RemoteControl_Name { get; set; }
        public string RemoteControl_Designation { get; set; }
        public Profield RemoteControl_Profield { get; set; }
        public List<Part> Parts { get; set; }
        public List<Property> Properties { get; set; }
        public RemoteControl()
        {
            Parts = new List<Part>();
            Properties = new List<Property>();
        }
    }
}