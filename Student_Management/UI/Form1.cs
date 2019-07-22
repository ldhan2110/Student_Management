using Student_Management.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Check_User(tb_username.Text, tb_password.Text))
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                error.Text = "Username not Exist !!";
            }
        }
    }
}
