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

            int i = 1;
            List<List<string>> result = user.Get_Score_of_a_student();
            foreach (List<string> s in result)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(s[4]);
                if (s.Count > 6)
                    item.SubItems.Add(s[5]);
                else
                    item.SubItems.Add("null");
                item.SubItems.Add(s[0]);
                item.SubItems.Add(s[1]);
                item.SubItems.Add(s[2]);
                item.SubItems.Add(s[3]);
                i++;
                listView1.Items.Add(item);
            }
            
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
