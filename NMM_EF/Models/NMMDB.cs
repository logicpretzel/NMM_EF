using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace NMM_EF.Models
{
    public class NMMDB : DbContext
    {
        public NMMDB () : base("NMMDB")
        {

        }
        public DbSet<Brewery> Breweries { get; set;  }
        public DbSet<Review> Reviews { get; set; }
    }
}
