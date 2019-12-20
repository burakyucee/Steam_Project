using Steam_Project.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.Repository.Service.Abstract
{
    public interface IAppUserRepository
    {
        void Add(string firstName, string lastName, string userName, string email, string password, Role role);
        void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role);
        void Delete(int id);
        void TextBoxEraser(GroupBox groupBox);
        List<AppUser> TakeList();
        List<AppUser> FindByName(string firstName);
        List<AppUser> GetAll();

        void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate);
    }
}
