using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Data
{
    public class SouvenirType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SouvenirType> SouvenirTypes { get; set; }
    }
}
