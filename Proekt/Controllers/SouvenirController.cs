using Proekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Controllers
{
    public class SouvenirController
    {
        private SouvenirContext dbContext = new SouvenirContext();

        public List<Souvenir> GetAllSоuvenirs()
           => dbContext.Souvenirs
            .Include("Type")
            .ToList();

        public void Create(Souvenir souvenir)
        {
            dbContext.Souvenirs.Add(souvenir);
            dbContext.SaveChanges();

        }
        public void Update(int id, Souvenir souvenir)
        {
            Souvenir findedSouvenir = dbContext.Souvenirs.Find(id);

            if (findedSouvenir == null)
                return;

            findedSouvenir.Name = souvenir.Name;
            findedSouvenir.Description = souvenir.Description;
            findedSouvenir.Price = souvenir.Price;
            findedSouvenir.TypeId = souvenir.TypeId;


            dbContext.SaveChanges();

        }
        public void Delete(int id)
        {
            Souvenir findedSouvenir = dbContext.Souvenirs.Find(id);
            if (findedSouvenir == null)
                return;
            dbContext.Souvenirs.Remove(findedSouvenir);
            dbContext.SaveChanges();
        }
    }
}
