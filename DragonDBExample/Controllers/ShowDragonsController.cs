using DragonDBExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonDBExample.Controllers
{
    public class ShowDragonsController
    {
        //READ
        public List<Dragon> GetAllDragons()
        {
            using (DragonsDBEntities db = new DragonsDBEntities())
            {
                return db.Dragons.ToList();
            }
        }

        //Create - Team Leader
        public void CreateDragon(Dragon d)
        {
            using (DragonsDBEntities db = new DragonsDBEntities())
            {
                var lastDragon = db.Dragons.ToList().LastOrDefault();
                if (lastDragon == null)
                {
                    lastDragon = new Dragon();
                    lastDragon.Id = 0;
                }

                d.Id = lastDragon.Id + 1;
                db.Dragons.Add(d);
                db.SaveChanges();
            }
        }

        //UPDATE
        //DELETE

        public List<Dragon> ShowAllDragonsWithMoreKills()
        {
            const int kills = 10;

            using (DragonsDBEntities db = new DragonsDBEntities())
            {
                return db.Dragons.Where(d => d.Kills > kills).OrderByDescending(d => d.Kills).ToList();
            }
        }
    }
}
