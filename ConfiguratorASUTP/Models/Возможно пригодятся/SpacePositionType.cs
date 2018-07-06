using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("SpacePositionTypes")]
    public class SpacePositionType
    {
        [Key]
        public int SpacePositionTypeId { get; set; }
        public string SpacePositionTypeName { get; set; }
        public List<SpacePositionType> SpacePositionTypes { get; set; }
        public SpacePositionType()
        {
            SpacePositionTypes = new List<SpacePositionType>();
        }
    }
}