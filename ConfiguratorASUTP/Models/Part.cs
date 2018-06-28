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
        public int Id {get;set;}
        public string Name { get; set; }
        public string Designation { get; set; }
        public Profield Profield { get; set; }
        public Position Position { get; set; }
        public virtual List<Impact> Impacts { get; set; }
        public virtual List<Property> Properties { get; set; }
        public List<Part> Parts { get; set; }
        public virtual List<Condition> Conditions { get; set; }
        public virtual List<AssemblyPart> Assemblies { get; set; }
        public Part()
        {
            Impacts = new List<Impact>();
            Properties = new List<Property>();
            Assemblies = new List<AssemblyPart>();
            Conditions = new List<Condition>();
            Parts = new List<Part>();
            if (Assemblies == null || Assemblies.Count == 0 )
            {
                return;
            }
            else
            {
                foreach (var item in Assemblies)
                {
                    if(item == null || item.Parts == null || item.Parts.Count > 0)
                    {
                        foreach (var itemLevel2 in item.Parts)
                        {
                            Parts.Add(itemLevel2);
                        }
                    }
                }
            }
        }
    }
}