using Steam_Project.Model.ORM.Entity.Concrete;
using Steam_Project.Repository.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.Repository.Service.Concrete
{
    public class RepositoryOfGame : BaseRepository, IGameRepository
    {
        Game game = new Game();
        public void Add(string gameName,string title, string pictureURL, int gameCategoryID, int appUserID)
        {
            game.GameName = gameName;
            game.Title = title;
            game.PictureUrl = pictureURL;
            game.GameCategoryID = gameCategoryID;
            game.AppUserID = appUserID;
            db.Games.Add(game);
            db.SaveChanges();






        }

        public void Delete(int id)
        {
            game = db.Games.FirstOrDefault(x => x.ID == id);
            game.DeleteDate = DateTime.Now;
            game.Status = Model.ORM.Entity.Abstract.Status.Passive;
            db.SaveChanges();
        }

        public List<Game> FindByName(string gameName)
        {
            return db.Games.Where(x => x.GameName == gameName).ToList();
        }

        public List<Game> GetAll()
        {
            return db.Games.ToList();
        }

        public List<AppUser> TakeAppUserList()
        {
            return db.AppUsers.Where(x => x.Status == Model.ORM.Entity.Abstract.Status.Active).ToList();
        }

        public List<GameCategory> TakeGameCategoryList()
        {
            return db.GameCategories.Where(x => x.Status == Model.ORM.Entity.Abstract.Status.Active).ToList();
        }

        public List<Game> TakeList()
        {
            return db.Games.Where(x => x.Status == Model.ORM.Entity.Abstract.Status.Active).ToList();

        }

        public void TextBoxEraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void Update(string gameName,int id, string tittle, string pictureURL, int gameCategoryID, int appUserID)
        {
            try
            {
                game.GameName = gameName;
                game = db.Games.FirstOrDefault(x => x.ID == id);
                game.Title = tittle;
                game.PictureUrl = pictureURL;
                game = db.Games.FirstOrDefault(x => x.GameCategoryID == gameCategoryID);
                game = db.Games.FirstOrDefault(x => x.AppUserID == appUserID);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen ID giriniz.");
            }
        }
    }
}
