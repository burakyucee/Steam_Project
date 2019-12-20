namespace Steam_Project.UI
{
    partial class AdminGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddGameName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAddProducer = new System.Windows.Forms.ComboBox();
            this.cmbAddGameCategory = new System.Windows.Forms.ComboBox();
            this.btnAddPictureUrl = new System.Windows.Forms.Button();
            this.txtAddPictureUrl = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ofdAdd = new System.Windows.Forms.OpenFileDialog();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddGameName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbAddProducer);
            this.groupBox1.Controls.Add(this.cmbAddGameCategory);
            this.groupBox1.Controls.Add(this.btnAddPictureUrl);
            this.groupBox1.Controls.Add(this.txtAddPictureUrl);
            this.groupBox1.Controls.Add(this.txtAddTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Game";
            // 
            // txtAddGameName
            // 
            this.txtAddGameName.Location = new System.Drawing.Point(98, 16);
            this.txtAddGameName.Name = "txtAddGameName";
            this.txtAddGameName.Size = new System.Drawing.Size(172, 20);
            this.txtAddGameName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(198, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAddProducer
            // 
            this.cmbAddProducer.FormattingEnabled = true;
            this.cmbAddProducer.Location = new System.Drawing.Point(98, 232);
            this.cmbAddProducer.Name = "cmbAddProducer";
            this.cmbAddProducer.Size = new System.Drawing.Size(175, 21);
            this.cmbAddProducer.TabIndex = 3;
            // 
            // cmbAddGameCategory
            // 
            this.cmbAddGameCategory.FormattingEnabled = true;
            this.cmbAddGameCategory.Location = new System.Drawing.Point(98, 178);
            this.cmbAddGameCategory.Name = "cmbAddGameCategory";
            this.cmbAddGameCategory.Size = new System.Drawing.Size(175, 21);
            this.cmbAddGameCategory.TabIndex = 3;
            // 
            // btnAddPictureUrl
            // 
            this.btnAddPictureUrl.Location = new System.Drawing.Point(98, 100);
            this.btnAddPictureUrl.Name = "btnAddPictureUrl";
            this.btnAddPictureUrl.Size = new System.Drawing.Size(175, 23);
            this.btnAddPictureUrl.TabIndex = 2;
            this.btnAddPictureUrl.Text = "Choose A Picture";
            this.btnAddPictureUrl.UseVisualStyleBackColor = true;
            this.btnAddPictureUrl.Click += new System.EventHandler(this.btnAddPictureUrl_Click);
            // 
            // txtAddPictureUrl
            // 
            this.txtAddPictureUrl.Location = new System.Drawing.Point(98, 129);
            this.txtAddPictureUrl.Name = "txtAddPictureUrl";
            this.txtAddPictureUrl.Size = new System.Drawing.Size(175, 20);
            this.txtAddPictureUrl.TabIndex = 1;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(98, 48);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(175, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please Choose A Producer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please Choose A Game Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(40, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Game";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1031, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminGame";
            this.Text = "AdminGame";
            this.Load += new System.EventHandler(this.AdminGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAddProducer;
        private System.Windows.Forms.ComboBox cmbAddGameCategory;
        private System.Windows.Forms.Button btnAddPictureUrl;
        private System.Windows.Forms.TextBox txtAddPictureUrl;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddGameName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog ofdAdd;
        private System.Windows.Forms.ContextMenu contextMenu1;
    }
}