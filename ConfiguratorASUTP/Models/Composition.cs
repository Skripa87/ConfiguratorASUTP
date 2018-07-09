using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public class Composition
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual List<Part> Parts { get; set; }
        public Composition()
        {
            Parts = new List<Part>();
        }
    }
}