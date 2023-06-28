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
    public partial class LoginPage:Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //username (textBox1)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //password (textBox2)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login button (launch associate or admin)

            int x, y, z; //
            x = 0;
            y = 0;
            z = 0;

                string userid = textBox1.Text;
                string password = textBox2.Text;

            if (userid.All(char.IsDigit) && (textBox1.Text.Length == 6))   //associate userID is all numbers, 6 length long
                x = 1;
            else if (textBox1.Text.Length != 4)
            error.Text = "Invalid userID - Must be 4 or 6 digits";

            if (userid.All(char.IsDigit) && (textBox1.Text.Length == 4))   //admin userID is all numbers, 4 length long
                z = 1;
            else if (textBox1.Text.Length != 6)
            error.Text = "Invalid userID - Must be 4 or 6 digits";


            if (password.All(char.IsDigit) && (textBox2.Text.Length == 6))  //password should be 6 numbers long
                y = 1;
            else if (textBox2.Text.Length != 6)
            error2.Text = "Invalid password";



            if ((x == 1) && (y == 1))                                       //test for associate userID
            {
                Form associate = new AssociatePortal();                    //launch Associate portal
                associate.Show();
                this.Hide();
            }
            else if ((z == 1) && (y == 1))                                 //test for admin userID
            {
                Form admin = new AdminPortal();                             //launch Admin portal
                admin.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form guest = new GuestPortal();                                 //launch Guest portal with button click
            guest.Show();
            this.Hide();
            //launch guest mode
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void error2_Click(object sender, EventArgs e)
        {

        }
    }
}
