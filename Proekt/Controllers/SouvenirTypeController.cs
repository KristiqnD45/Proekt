using Proekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Controllers
{
    public class SouvenirTypeController
    {
        private SouvenirContext dbContext = new SouvenirContext();

        public List<SouvenirType> GetAllSоuvenirTypes()
           => dbContext.SouvenirTypes.ToList();

        public void Create(SouvenirType type)
        {
            dbContext.SouvenirTypes.Add(type);
            dbContext.SaveChanges();

        }
      
    }
}

