using Student_Management.BL;
using Student_Management.DAL;
using Student_Management.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class LoginForm : Form
    {
        private User user;
        public LoginForm(User u)
        {
            user = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Check_User(tb_username.Text, tb_password.Text))
            {
                if (user.Check_Type('S'))
                {
                    Student student_form = new Student(user);
                    student_form.ShowDialog();   
                }
                
            }
            else
            {
                error.Text = "Wrong Username or Password !!";
            }
        }
    }
}
