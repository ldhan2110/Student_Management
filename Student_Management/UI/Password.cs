using Student_Management.BL;
using Student_Management.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management.UI
{
    public partial class Password : Form
    {
        private User user;

        public Password(User u)
        {
            InitializeComponent();
            user = u;
        }

        public bool Check_Password()
        {
            if (user.Check_User(oldPassword.Text))
            {
                if (oldPassword.Text == newPassword.Text)
                {
                    MessageBox.Show("New Password must be different from Old Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;

            }
            else
            {
                MessageBox.Show("Old Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_Password())
            {
                DataAccess service = new DataAccess();
                if (service.Update_User(user.Username, newPassword.Text, user.type))
                {
                    MessageBox.Show("Update password Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    user.Reload_User(newPassword.Text);
                    this.Close();
                }
            }
        }
    }
}
