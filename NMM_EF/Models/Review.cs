using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMM_EF.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int BreweryID { get; set; }

    }
}
