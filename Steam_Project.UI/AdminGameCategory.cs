using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steam_Project.Repository.Service.Concrete;





namespace Steam_Project.UI

{
    public partial class AdminGameCategory : Form
    {
        public AdminGameCategory()
        {
            InitializeComponent();
        }
        RepositoryOfGameCategory service = new RepositoryOfGameCategory();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            service.Add(txtAddName.Text, txtAddDescription.Text);
            dataGridView1.DataSource = service.Takelist();
            service.TextBoxEraser(groupBox1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            service.Update(int.Parse(txtUpdateID.Text), txtUpdateName.Text, txtUpdateDesciption.Text);
            dataGridView1.DataSource = service.Takelist();
            service.TextBoxEraser(groupBox3);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.Delete(int.Parse(txtDelete.Text));
            dataGridView1.DataSource = service.Takelist();
            service.TextBoxEraser(groupBox4);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.FindByName(txtFindCategory.Text);
            service.TextBoxEraser(groupBox5);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAll();
        }

        private void AdminGameCategory_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = service.Takelist();
        }
    }
}
