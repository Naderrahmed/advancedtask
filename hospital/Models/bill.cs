using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Models
{
    public class bill
    {
        public int idb { get; set; }
        public string problem { get; set; }
        public DateTime Dateexamination { get; set; }
        public decimal docCharges { get; set; }
        public decimal roomCharges { get; set; }
    }
}
