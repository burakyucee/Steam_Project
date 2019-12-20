using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.Model.ORM.Entity.Concrete
{
    public class Game:BaseEntity
    {
        public string GameName { get; set; }
        public string Title { get; set; }
        
        public string PictureUrl { get; set; }

        public int GameCategoryID { get; set; }

        public virtual GameCategory GameCategory { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
