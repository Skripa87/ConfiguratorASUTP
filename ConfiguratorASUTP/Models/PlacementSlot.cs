using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("PlacementSlots")]
    public class PlacementSlot
    {
        [Key]
        public int PlacementSlotId { get; set; }
        public string PlacementSlotName { get; set; }
        public PlacementType PlacementType { get; set; }
        public SpacePosition PlacementSlotSpacePosition { get; set; }
        public List<Condition> PlacementSlotConstraints { get; set; }
        public Profield PlacementSlotProfield { get; set; }

        public PlacementSlot()
        {
            PlacementSlotConstraints = new List<Condition>();
        }
    }
}