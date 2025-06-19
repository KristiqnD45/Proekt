using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Data
{
    public class Souvenir
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public string Type { get; set; }
        public int TypeId { get; set; } 

        public SouvenirType SouvenirTypes { get; set; }
        public int SouvenirTypeId { get; internal set; }
    }
}
