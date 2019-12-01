using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormApp.Models
{
    public class GenderModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.ID + " " + this.Name;
        }
    }
}
