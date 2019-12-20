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
    public class RepositoryOfGameCategory : BaseRepository, IGameCategoryRepository
    {
        GameCategory gameCategory = new GameCategory();
        public void Add(string name, string description)
        {
            gameCategory.Name = name;
            gameCategory.Description = description;
            db.GameCategories.Add(gameCategory);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            gameCategory = db.GameCategories.FirstOrDefault(x => x.ID == id);
            gameCategory.DeleteDate = DateTime.Now;
            gameCategory.Status = Model.ORM.Entity.Abstract.Status.Passive;
            db.SaveChanges();
        }

        public List<GameCategory> FindByName(string name)
        {
            return db.GameCategories.Where(x => x.Name == name).ToList();
        }

        public List<GameCategory> GetAll()
        {
            return db.GameCategories.ToList();
        }

        public List<GameCategory> Takelist()
        {
            return db.GameCategories.Where(x => x.Status == Model.ORM.Entity.Abstract.Status.Active || x.Status == Model.ORM.Entity.Abstract.Status.Update).ToList();
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

        public void Update(int id, string name, string description)
        {
            try
            {
                gameCategory = db.GameCategories.FirstOrDefault(x => x.ID == id);
                gameCategory.Name = name;
                gameCategory.Description = description;
                gameCategory.Status = Model.ORM.Entity.Abstract.Status.Update;
                gameCategory.UpdateDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen ID giriniz");

            }
        }
    }
}
