using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class AssociatePortal : Form
    {
        public AssociatePortal()
        {
            InitializeComponent();
            listView1.View = View.Details;

            List<string> data = File.ReadAllLines(@"C:\Users\somer\Documents\Compe361\Info.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;                                                                  //listview
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;                                                                  //click on row to populate textfields
                textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;                                                                  //populate fields by clicking on row
                textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;
            }
            catch
            { }
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
            Form associate = new AssociatePortal();                         //refresh page
            associate.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\somer\Documents\Compe361\Info.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            lines.Add(textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ", " + textBox7.Text + ", " + textBox8.Text);
            File.WriteAllLines(filePath, lines);

            Form associate = new AssociatePortal();                         //refresh page
            associate.Show();
            this.Hide();
        }

        private void AssociatePortal_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;                                                                  //listview
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;                                                                  //click on row to populate textfields
            listView1.SelectedItems[0].SubItems[4].Text = textBox5.Text;
            listView1.SelectedItems[0].SubItems[5].Text = textBox6.Text;
            listView1.SelectedItems[0].SubItems[6].Text = textBox7.Text;
            listView1.SelectedItems[0].SubItems[7].Text = textBox8.Text;                                                                    //edit button

            textClear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            textClear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form associate = new AssociatePortal();                         //refresh page
            associate.Show();
            this.Hide();
        }
    }
}

