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

        //CREATE
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
