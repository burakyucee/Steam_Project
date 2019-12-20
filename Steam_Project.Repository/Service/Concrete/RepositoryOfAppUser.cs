using Steam_Project.Model.ORM.Entity.Abstract;
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
    public class RepositoryOfAppUser : BaseRepository, IAppUserRepository
    {
        AppUser user = new AppUser();
        public void Add(string firstName, string lastName, string userName, string email, string password, Role role)
        {
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.Email = email;
            user.Password = password;
            user.Role = role;
            db.AppUsers.Add(user);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            user = db.AppUsers.FirstOrDefault(x => x.ID == id);
            user.DeleteDate = DateTime.Now;
            user.Status = Status.Passive;
            db.SaveChanges();
        }

        public List<AppUser> FindByName(string firstName)
        {
            return db.AppUsers.Where(x => x.FirstName == firstName).ToList();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public void GetEnum(ComboBox comboBoxAdd, ComboBox comboBoxUpdate)
        {
            comboBoxAdd.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxAdd.SelectedIndex = 0;

            comboBoxUpdate.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBoxUpdate.SelectedIndex = 0;
        }

        public List<AppUser> TakeList()
        {
            return db.AppUsers.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();
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

        public void Update(int id, string firstName, string lastName, string userName, string email, string password, Role role)
        {
            try
            {
                user = db.AppUsers.FirstOrDefault(x => x.ID == id);
                user.FirstName = firstName;
                user.LastName = lastName;
                user.UserName = userName;
                user.Email = email;
                user.Password = password;
                user.Role = role;
                user.Status = Status.Update;
                user.UpdateDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen ID giriniz!!!");
            }
        }
    }
}
