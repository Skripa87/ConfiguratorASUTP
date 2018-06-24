using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("PlacementTypes")]
    public class PlacementType
    {
        [Key]
        public int SlotTypeId { get; set; }
        public string SlotTypeNAme { get; set; }
        public List<PlacementType> SlotTypeSlotTypes { get; set; }
        public PlacementType()
        {
            SlotTypeSlotTypes = new List<PlacementType>();
        }
    }
}