using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Model.ORM.Entity.Concrete
{
    public class GameCategory:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Game> Games { get; set; }


    }
}
