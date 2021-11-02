using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul6HW3.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ExtraHeaderAttribute : Attribute
    {
        public ExtraHeaderAttribute(string kay, string value)
        {

        }

        public string Kay { get; set; }
        public string Value { get; set; }
    }
}
