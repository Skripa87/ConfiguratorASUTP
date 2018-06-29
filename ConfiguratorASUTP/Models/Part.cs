using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    [Table("Parts")]
    public class Part
    {
        [Key]
        public int Part_Id { get;set;}
        public string Part_Name { get; set; }
        public string Part_Designation { get; set; }
        public Profield Part_Profield { get; set; }
        public Position Part_Position { get; set; }
        public virtual List<Impact> Part_Impacts { get; set; }
        public virtual List<Property> Part_Properties { get; set; }
        public List<Part> Part_Parts { get; set; }
        public virtual List<Condition> Part_Conditions { get; set; }
        public virtual List<AssemblyPart> Part_Assemblies { get; set; }
        public Part()
        {
            Part_Impacts = new List<Impact>();
            Part_Properties = new List<Property>();
            Part_Assemblies = new List<AssemblyPart>();
            Part_Conditions = new List<Condition>();
            Part_Parts = new List<Part>();
            if (Part_Assemblies == null || Part_Assemblies.Count == 0 )
            {
                return;
            }
            else
            {
                foreach (var item in Part_Assemblies)
                {
                    if(item == null || item.Parts == null || item.Parts.Count > 0)
                    {
                        foreach (var itemLevel2 in item.Parts)
                        {
                            Part_Parts.Add(itemLevel2);
                        }
                    }
                }
            }
        }
    }
}