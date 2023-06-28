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
    
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
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

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;                                          //populate listview with the textfile

            string filePath = @"C:\Users\somer\Documents\Compe361\Info.txt";

            List<string> data = File.ReadAllLines(filePath).ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            {}                                                                                                                                  //exception handling
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form login = new LoginPage();                                 //launch Login portal with button click
            login.Show();
            this.Hide();
            //go back to login page
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\somer\Documents\Compe361\Info.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();                           //add button

            lines.Add(textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text);
            File.WriteAllLines(filePath, lines);
            
            Form admin = new AdminPortal();                                         //refresh page
            admin.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPortal();                         //refresh page
            admin.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

           /* TextWriter tw = new StreamWriter(@"C:\Users\somer\Documents\Compe361\Info.txt");
            {
                foreach (ListViewItem item in listView1.Items)                                                                              //rewrite textfile to edit item
                {
                    try
                    {
                        tw.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + "," + item.SubItems[5].Text + "," + item.SubItems[6].Text + "," + item.SubItems[7].Text);
                    }
                    catch
                    { }
                }
            }*/
        } 

        private void button3_Click(object sender, EventArgs e)
        {                                                                                                                               //delete button
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            textClear();
            /*
            TextWriter tw = new StreamWriter(@"C:\Users\somer\Documents\Compe361\Info.txt");                                            //rewrite textfile to delete item
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    try
                    {
                        tw.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + "," + item.SubItems[5].Text + "," + item.SubItems[6].Text + "," + item.SubItems[7].Text);
                    }
                    catch
                    { }
                }
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPortal();                         //refresh page
            admin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form teams = new AdminTeams();                         //go to teams
            teams.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form categories = new AdminCategories();                         //go to categories
            categories.Show();
            this.Hide();
        }
    }

    public class Product
    {
        private string name;
        private string category;
        private string serial;
        private string department;
        private string price;
        private string quantity;
        private string date;
        private string seller;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Seller
        {
            get { return seller; }
            set { seller = value; }
        }
    }


}
