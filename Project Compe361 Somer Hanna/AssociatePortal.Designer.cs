
namespace Project2
{
    partial class AssociatePortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociatePortal));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.namq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 29);
            this.button4.TabIndex = 25;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(625, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(451, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.GhostWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namq,
            this.Category,
            this.SerialNum,
            this.Department,
            this.Price,
            this.Quantity,
            this.Date,
            this.Seller});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(155, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 164);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // namq
            // 
            this.namq.DisplayIndex = 6;
            this.namq.Text = "Name";
            this.namq.Width = 90;
            // 
            // Category
            // 
            this.Category.DisplayIndex = 7;
            this.Category.Text = "Category";
            this.Category.Width = 90;
            // 
            // SerialNum
            // 
            this.SerialNum.DisplayIndex = 0;
            this.SerialNum.Text = "Serial Num";
            this.SerialNum.Width = 90;
            // 
            // Department
            // 
            this.Department.DisplayIndex = 1;
            this.Department.Text = "Department";
            this.Department.Width = 90;
            // 
            // Price
            // 
            this.Price.DisplayIndex = 2;
            this.Price.Text = "Price";
            this.Price.Width = 90;
            // 
            // Quantity
            // 
            this.Quantity.DisplayIndex = 3;
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 90;
            // 
            // Date
            // 
            this.Date.DisplayIndex = 4;
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Seller
            // 
            this.Seller.DisplayIndex = 5;
            this.Seller.Text = "Seller";
            this.Seller.Width = 90;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "←";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(44, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "↻";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(281, 415);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(113, 20);
            this.textBox8.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(280, 371);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 20);
            this.textBox7.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(281, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(527, 369);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(775, 374);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(527, 412);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(775, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 29;
            // 
            // AssociatePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 495);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AssociatePortal";
            this.Text = "AssociatePortal";
            this.Load += new System.EventHandler(this.AssociatePortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader namq;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader SerialNum;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Seller;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}