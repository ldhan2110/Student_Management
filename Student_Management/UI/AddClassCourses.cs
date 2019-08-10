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
    public partial class AddClassCourses : Form
    {
        private User user;
        private string Class;
        public AddClassCourses(User u, string s)
        {
            InitializeComponent();
            user = u;
            Class = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Add_student_to_ClassCourses(textBox1.Text, Class))
                MessageBox.Show("Add successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Add Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
