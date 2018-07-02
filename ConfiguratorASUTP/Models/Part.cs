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
        [Display(Name = "Наименование детали")]
        public string Part_Name { get; set; }
        [Display(Name = "Обозначение детали")]
        public string Part_Designation { get; set; }
        [Display(Name = "Габариты или каркас детали")]
        public Profield Part_Profield { get; set; }
        [Display(Name = "Размещение детали")]
        public Position Part_Position { get; set; }
        public virtual List<Impact> Impacts { get; set; }
        public virtual List<Property> Properties { get; set; }
        public Part Part_Owner { get; set; }
        public virtual List<Part> Childs { get; set; }
        public virtual List<Condition> Conditions { get; set; }

        public virtual List<RemoteControl> RemoteControls { get; set; }
        public Part()
        {
            Impacts = new List<Impact>();
            Properties = new List<Property>();
            Conditions = new List<Condition>();
            Childs = new List<Part>();
            RemoteControls = new List<RemoteControl>();
        }
    }
}