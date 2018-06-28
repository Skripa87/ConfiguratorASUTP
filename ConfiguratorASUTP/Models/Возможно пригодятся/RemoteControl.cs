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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public List<PlacementSlot> Slots { get; set; }
        public List<ComponentPart> Parts { get; set; }
        public List<Property> Properties { get; set; }
        public Profield Profield { get; set; }
        public RemoteControl()
        {
            Slots = new List<PlacementSlot>();
            Parts = new List<ComponentPart>();
            Properties = new List<Property>();
        }
    }
}