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
    public partial class Add_Student : Form
    {
        private User user;
        public Add_Student(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMSSV.Text) || string.IsNullOrEmpty(tbName.Text) || cbGender.SelectedItem is null || string.IsNullOrEmpty(tbClass.Text))
            {
                MessageBox.Show("You must fill all the information !!", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.Add_Student(tbMSSV.Text, tbName.Text, cbGender.SelectedItem.ToString(), tbCMND.Text, tbClass.Text);
                MessageBox.Show("Insert Successfully !");
            }
        }
    }
}
