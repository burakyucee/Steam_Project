using Steam_Project.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.Repository.Service.Abstract
{
    public interface IGameCategoryRepository
    {
        void Add(string name, string description);
        void Update(int id, string name, string description);
        void Delete(int id);

        void TextBoxEraser(GroupBox groupBox);
        List<GameCategory> Takelist();
        List<GameCategory> FindByName(string name);
        List<GameCategory> GetAll();
    }
}
