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

        //UPDATE - Dev 1
        public void UpdateDragon(int id, Dragon d)
        {
            using (DragonsDBEntities db = new DragonsDBEntities())
            {
                var dragonToUpdate = db.Dragons.Where(p => p.Id == id).FirstOrDefault();
                if (dragonToUpdate != null)
                {
                    dragonToUpdate.Id = id;
                    dragonToUpdate.Name = d.Name;
                    dragonToUpdate.Kills = d.Kills;
                    db.SaveChanges();
                }
            }
        }

        //DELETE - Dev 2
        public void DeleteDragon(int id)
        {
            using (DragonsDBEntities db = new DragonsDBEntities())
            {
                var dragonToDelete = db.Dragons.Where(d => d.Id == id).FirstOrDefault();
                if (dragonToDelete != null)
                {
                    db.Dragons.Remove(dragonToDelete);
                    db.SaveChanges();
                }
            }
        }

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
