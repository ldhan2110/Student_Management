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
    public partial class GiaoVu : Form
    {
        private User user;
        private float num_pass = 0;
        private float num_fail = 0;

        public GiaoVu(User u)
        {
            user = u;
            InitializeComponent();
            foreach (string s in user.Get_Class())
                cbClass.Items.Add(s);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Password password_form = new Password(user);
            password_form.ShowDialog();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView.Clear();
            listView.GridLines = true;
            listView.Columns.Add("STT", 38);
            listView.Items.Clear();

            if (ClassRB.Checked == true)
            {
                listView.Columns.Add("MSSV", 60);
                listView.Columns.Add("Họ tên", 159);
                listView.Columns.Add("Giới tính", 60);
                listView.Columns.Add("CMND", 85);

                List<List<string>> list_student = user.Get_Student_of_a_class(cbClass.SelectedItem.ToString());

                int i = 1;
                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    item.SubItems.Add(s[4]);
                    item.SubItems.Add(s[5]);
                    listView.Items.Add(item);
                    i++;
                }

            }

            if (ScheduleRB.Checked == true)
            {
                listView.Columns.Add("Mã môn", 60);
                listView.Columns.Add("Tên môn", 159);
                listView.Columns.Add("Phòng học", 100);

                List<List<string>> list_student = user.Get_Courses_of_a_class(cbClass.SelectedItem.ToString());

                int i = 1;
                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    item.SubItems.Add(s[4]);
                    listView.Items.Add(item);
                    i++;
                }

            }

            if (ClassCoursesRB.Checked == true)
            {
                listView.Columns.Add("MSSV", 60);
                listView.Columns.Add("Họ tên", 159);
                listView.Columns.Add("Giới tính", 60);
                listView.Columns.Add("CMND", 85);

                List<List<string>> list_student = user.Get_Student_of_a_Course_class(cbClass.SelectedItem.ToString());

                int i = 1;
                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(s[0]);
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    listView.Items.Add(item);
                    i++;
                }


            }

            if (ScoreRB.Checked == true)
            {
                listView.Columns.Add("MSSV", 60);
                listView.Columns.Add("Họ tên", 159);
                listView.Columns.Add("Điểm GK", 55);
                listView.Columns.Add("Điểm CK", 55);
                listView.Columns.Add("Điểm Khác", 75);
                listView.Columns.Add("Điểm Tổng", 75);
                listView.Columns.Add("Đậu/Rớt", 75);
                float pass = 0; float fail = 0;
                List<List<string>> list_student = user.Get_Student_of_a_Score_class(cbClass.SelectedItem.ToString());

                int i = 1;
                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ToString();
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    item.SubItems.Add(s[4]);
                    item.SubItems.Add(s[5]);
                    item.SubItems.Add(s[6]);
                    if (int.Parse(s[6]) >= 5) { pass++; item.SubItems.Add("Đậu"); }
                    else { fail++; item.SubItems.Add("Rớt"); }
                    listView.Items.Add(item);
                    i++;
                }
                num_fail = fail;
                num_pass = pass;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem is null)
            {
                MessageBox.Show("You must choose a table to insert !!");

            }
            if (user.Impor_CSV_DB(tbfile.Text, cbtable.SelectedItem.ToString()))
                MessageBox.Show("Import Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Import failed !!", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbfile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbfile.Text = ofd.FileName;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassRB.Checked == true)
            {
                Add_Student add_form = new Add_Student(user);
                add_form.ShowDialog();
                cbClass.Items.Clear();
                foreach (string s in user.Get_Class())
                    cbClass.Items.Add(s);
            }

            if (ClassCoursesRB.Checked == true)
            {
                if (cbClass.SelectedItem is null) return;
                AddClassCourses form = new AddClassCourses(user, cbClass.SelectedItem.ToString());
                form.ShowDialog();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassRB.Checked == true)
            {
                listView.Clear();
                cbClass.Items.Clear();
                List<string> temp = user.Get_Class();
                foreach (string s in temp)
                    cbClass.Items.Add(s);
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ScheduleRB.Checked == true)
            {
                listView.Clear();
                cbClass.Items.Clear();
                foreach (string s in user.Get_Class_course())
                {
                    cbClass.Items.Add(s);
                }
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
        }

        private void radiobutton4_CheckedChanged(object sender, EventArgs e)
        {
            if (ClassCoursesRB.Checked == true)
            {
                listView.Clear();
                cbClass.Items.Clear();
                foreach (string s in user.Get_Course_Class())
                {
                    cbClass.Items.Add(s);
                }
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = true;
                contextMenuStrip1.Items[3].Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (ScoreRB.Checked == true)
            {
                listView.Clear();
                cbClass.Items.Clear();
                foreach (string s in user.Get_Score_Class())
                {
                    cbClass.Items.Add(s);
                }
            }
            contextMenuStrip1.Items[0].Enabled = false;
            contextMenuStrip1.Items[1].Enabled = true;
            contextMenuStrip1.Items[2].Enabled = false;
            contextMenuStrip1.Items[3].Enabled = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                string[] temp = cbClass.SelectedItem.ToString().Split('-');
                if (user.Remove_student_from_ClassCourses(listView.SelectedItems[0].SubItems[1].Text.ToString(), temp[1], temp[0]))
                    MessageBox.Show("Remove Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Remove Failed !", "ERRORS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                ListViewItem student = listView.SelectedItems[0];
                Update_Score form = new Update_Score(user, student.SubItems[3].Text, student.SubItems[4].Text, student.SubItems[5].Text, student.SubItems[6].Text, student.SubItems[1].Text, cbClass.SelectedItem.ToString());
                form.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student_Management.exe\nVersion: 0.0.1\nDeveloper: Le Dang Hoang An", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void analyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (num_pass == 0 && num_fail == 0) return;
            Analyze form = new Analyze(num_pass, num_fail,cbClass.SelectedItem.ToString());
            form.ShowDialog();
        }
    }
}
