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

namespace Student_Management.UI
{
    public partial class Student : Form
    {
        private User user;
        public Student(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password password_form = new Password(user);
            password_form.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Log_out();
            this.Close();

        }
    }
}
