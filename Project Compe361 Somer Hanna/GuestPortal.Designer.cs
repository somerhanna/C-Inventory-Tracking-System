
namespace Project2
{
    partial class GuestPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestPortal));
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
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(150, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 296);
            this.listView1.TabIndex = 15;
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
            this.button7.Location = new System.Drawing.Point(12, 77);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "←";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(45, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "↻";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // GuestPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 498);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listView1);
            this.Name = "GuestPortal";
            this.Text = "GuestPortal";
            this.Load += new System.EventHandler(this.GuestPortal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader SerialNum;
        private System.Windows.Forms.ColumnHeader Seller;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader namq;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}