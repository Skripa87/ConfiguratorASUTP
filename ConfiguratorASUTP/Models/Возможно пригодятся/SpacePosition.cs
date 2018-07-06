using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("SpacePositions")]
    public class SpacePosition
    {
        [Key]
        public int SpacePositionId { get; set; }
        public SpacePositionType SpacePositionType { get; set; }
        public string SpacePositionUnit { get; set; }
    }
}