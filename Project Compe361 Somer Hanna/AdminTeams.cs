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
    public partial class AdminTeams : Form
    {
        public AdminTeams()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form teams = new AdminTeams();                         //refresh page
            teams.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form login = new AdminPortal();                                 //go back to admin portal
            login.Show();
            this.Hide();
            //go back to login page
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox2.Text };
            var listItem = new ListViewItem(row);                       //add item to associate
            listView1.Items.Add(listItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)           //delete item to associate
            {
                listView1.Items.Remove(item);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text };
            var listItem = new ListViewItem(row);                       //add item to admins
            listView2.Items.Add(listItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)           //delete item to admins
            {
                listView2.Items.Remove(item);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPortal();                         //products page
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form admin1 = new AdminTeams();                         //teams page
            admin1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form admin2 = new AdminCategories();                         //categories page
            admin2.Show();
            this.Hide();
        }
    }
}
