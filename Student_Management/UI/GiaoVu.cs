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

            if (radioButton1.Checked == true)
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

            if (radioButton2.Checked == true)
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

            if (radiobutton4.Checked == true)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem is null)
            {
                MessageBox.Show("You must choose a table to insert !!");

            }
            if (user.Impor_CSV_DB(tbfile.Text, cbtable.SelectedItem.ToString()))
                MessageBox.Show("Import Successfully !!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if (radioButton1.Checked == true)
            {
                Add_Student add_form = new Add_Student(user);
                add_form.ShowDialog();
            }
            cbClass.Items.Clear();
            foreach (string s in user.Get_Class())
                cbClass.Items.Add(s);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                cbClass.Items.Clear();
                List<string> temp = user.Get_Class();
                foreach (string s in temp)
                    cbClass.Items.Add(s);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                cbClass.Items.Clear();
                foreach (string s in user.Get_Class_course())
                {
                    cbClass.Items.Add(s);
                }
            }
        }

        private void radiobutton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobutton4.Checked == true)
            {
                cbClass.Items.Clear();
                foreach (string s in user.Get_Course_Class())
                {
                    cbClass.Items.Add(s);
                }
            }
        }
    }
}
