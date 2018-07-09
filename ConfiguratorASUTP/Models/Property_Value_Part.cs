using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public class Property_Value_Part
    {
        public int Properties_Values_Parts_Id { get; set; }
        public int Properties_Values_Parts_Property_Id { get; set; }
        public int Properties_Values_Parts_Value_Id { get; set; }
        public int Properties_Values_Parts_Part_Id { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<Value> Values { get; set; }
        public virtual List<Part> Parts { get; set; }
        public Property_Value_Part()
        {
            Properties = new List<Property>();
            Values = new List<Value>();
            Parts = new List<Part>();
        }
    }
}