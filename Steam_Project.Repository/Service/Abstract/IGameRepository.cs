using Steam_Project.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.Repository.Service.Abstract
{
    public interface IGameRepository
    {
        void Add(string gameName, string title, string pictureURL, int gameCategoryID, int appUserID);
        void Update(string gameName,int id, string title, string pictureURL, int gameCategoryID, int appUserID);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<Game> TakeList();
        List<Game> FindByName(string gameName);
        List<Game> GetAll();

        List<GameCategory> TakeGameCategoryList();
        List<AppUser> TakeAppUserList();

    }
}
