using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public class AssemblyPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Part> Parts { get;set;}
        public AssemblyPart()
        {
            Parts = new List<Part>();
        }
        
    }
}