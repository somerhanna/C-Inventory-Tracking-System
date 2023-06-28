using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class AdminCategories : Form
    {
        public AdminCategories()
        {
            InitializeComponent();
        }

    private void button8_Click(object sender, EventArgs e)
        {
            Form categories = new AdminCategories();                         //refresh page
            categories.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form login = new AdminPortal();                                 //go back to adminportal
            login.Show();
            this.Hide();
            //go back to login page
        }

        public class Categories
        {
            private string office;
            private string food;
            private string home;
            private string computer;
            private string music;
            private string clothing;
            private string tools;
            private string sports;

            public string Office
            {
                get { return office; }
                set { office = value; }
            }
            public string Food
            {
                get { return food; }
                set { food = value; }
            }
            public string Home
            {
                get { return home; }
                set { home = value; }
            }
            public string Computer
            {
                get { return computer; }
                set { computer = value; }
            }
            public string Music
            {
                get { return music; }
                set { music = value; }
            }
            public string Clothing
            {
                get { return clothing; }
                set { clothing = value; }
            }
            public string Tools
            {
                get { return tools; }
                set { tools = value; }
            }
            public string Sports
            {
                get { return sports; }
                set { sports = value; }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox2.Text };
            var listItem = new ListViewItem(row);                       //add item to categories
            listView1.Items.Add(listItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)           //delete item to categories
            {
                listView1.Items.Remove(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPortal();                         //to products page
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form admin1 = new AdminTeams();                         //to team page
            admin1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form admin2 = new AdminCategories();                         //to categories page
            admin2.Show();
            this.Hide();
        }
    }
}
