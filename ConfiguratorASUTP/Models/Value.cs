﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfiguratorASUTP.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string TypeValue { get; set; }
        public string Val { get; set; }
        public virtual List<Property> Properties { get; set; }
        public virtual List<Property_Value_Part> Properties_Values_Parts { get; set; }
        public Value()
        {
            Properties = new List<Property>();
            Properties_Values_Parts = new List<Property_Value_Part>();
        }

    }
}