using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Data
{
    public  class SouvenirContext:DbContext
    {
        public SouvenirContext() : base ("SouvenirContext")
        {

        }
        public DbSet<SouvenirType>SouvenirTypes { get; set; }
        public DbSet <Souvenir> Souvenirs { get; set; }
    }
}
