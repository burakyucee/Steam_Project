using Steam_Project.Repository.Service.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Project.UI
{
    public partial class AdminGame : Form
    {
        public AdminGame()
        {
            InitializeComponent();
        }
                

        RepositoryOfGame service = new RepositoryOfGame();

      

        private void AdminGame_Load(object sender, EventArgs e)
        {
            cmbAddGameCategory.DataSource = service.TakeGameCategoryList();
            cmbAddGameCategory.DisplayMember = "Name";
            cmbAddGameCategory.ValueMember = "Id";
            cmbAddGameCategory.SelectedIndex = -1;

            cmbAddProducer.DataSource = service.TakeAppUserList();
            cmbAddProducer.DisplayMember = "FirstName";
            cmbAddProducer.ValueMember = "Id";
            cmbAddProducer.SelectedIndex = -1;

            dataGridView1.DataSource = service.TakeList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.Add(txtAddGameName.Text, txtAddTitle.Text,  fileName, (int)(cmbAddGameCategory.SelectedValue), (int)(cmbAddProducer.SelectedValue));
            dataGridView1.DataSource = service.TakeList();
            service.TextBoxEraser(groupBox1);
            Member f2 = new Member();
            f2.Show();
            try
            {
                service.Add(txtAddGameName.Text, txtAddTitle.Text, fileName, (int)(cmbAddGameCategory.SelectedValue), (int)(cmbAddProducer.SelectedValue));
                dataGridView1.DataSource = service.TakeList();
                service.TextBoxEraser(groupBox1);
                
                

                MessageBox.Show("İşlem tamam");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgi girdiniz");
            }
        }

        string fileName;
        private void btnAddPictureUrl_Click(object sender, EventArgs e)
        {
            ofdAdd.Filter = "JPG | *.jpg";
            if (ofdAdd.ShowDialog() == DialogResult.OK)
            {
                txtAddPictureUrl.Text = ofdAdd.FileName;
                fileName = ofdAdd.FileName;
            }
            

        }

       
    }
}
