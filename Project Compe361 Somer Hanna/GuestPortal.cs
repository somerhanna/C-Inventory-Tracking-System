using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class GuestPortal : Form
    {
        public GuestPortal()
        {
            InitializeComponent();
        }

        private void GuestPortal_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            List<string> data = File.ReadAllLines(@"C:\Users\somer\Documents\Compe361\Info.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form login = new LoginPage();                                 //launch Login portal with button click
            login.Show();
            this.Hide();
            //go back to login page
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form guest = new GuestPortal();                         //refresh page
            guest.Show();
            this.Hide();
        }
    }
}
    

