using Steam_Project.DAL.Context;
using Steam_Project.Model.ORM.Entity.Abstract;
using Steam_Project.Model.ORM.Entity.Concrete;
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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        int EklenenButonlar_Height = 0;
        int Soldan = 0, Ustten = 0;

        private void Member_Load(object sender, EventArgs e)
        {
            List<Game> games = db.Games.Where(x => x.Status == Model.ORM.Entity.Abstract.Status.Active || x.Status == Model.ORM.Entity.Abstract.Status.Update).ToList();
            foreach (var item in games)
            {
                flowLayoutPanel1.AutoScroll = true;
                List<Game> game = db.Games.Where(x => x.Status == Status.Active || x.Status == Status.Update).ToList();

                foreach (var game1 in games)
                {
                    GroupBox grp = new GroupBox();

                    grp.Location = new System.Drawing.Point(30, 120);
                    grp.Size = new System.Drawing.Size(300, 420);
                    PictureBox pctBox = new PictureBox();
                    pctBox.Location = new System.Drawing.Point(5, 45);
                    pctBox.Size = new System.Drawing.Size(290, 300);
                    pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctBox.Image = new Bitmap(item.PictureUrl);
                    Label gameName = new Label();
                    gameName.ForeColor = Color.DarkOrange;
                    gameName.Text = item.GameName;
                    gameName.Location = new System.Drawing.Point(5, 20);
                    gameName.Size = new System.Drawing.Size(290, 20);
                    Label gameDescription = new Label();
                    gameDescription.ForeColor = Color.DarkOrange;
                    
                    gameDescription.Location = new System.Drawing.Point(5, 360);
                    gameDescription.Size = new System.Drawing.Size(290, 50);
                    grp.Controls.Add(gameName);
                    grp.Controls.Add(gameDescription);
                    grp.Controls.Add(pctBox);

                    flowLayoutPanel1.Controls.Add(grp);
                }
            }
        }
    }
}
