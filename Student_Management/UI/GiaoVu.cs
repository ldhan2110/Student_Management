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

            if (radioButton1.Checked == true)
            {
                listView.Columns.Add("MSSV", 60);
                listView.Columns.Add("Họ tên", 159);
                listView.Columns.Add("Giới tính", 60);
                listView.Columns.Add("CMND", 85);

                List<List<string>> list_student = user.Get_Student_of_a_class(cbClass.SelectedItem.ToString());

                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = s[0];
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    item.SubItems.Add(s[4]);
                    item.SubItems.Add(s[5]);
                    listView.Items.Add(item);
                }
            }

            if (radioButton2.Checked == true)
            {   
                listView.Columns.Add("Mã môn",60);
                listView.Columns.Add("Tên môn",159);
                listView.Columns.Add("Phòng học",100);

                List<List<string>> list_student = user.Get_Courses_of_a_class(cbClass.SelectedItem.ToString());

                foreach (List<string> s in list_student)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = s[0];
                    item.SubItems.Add(s[1]);
                    item.SubItems.Add(s[2]);
                    item.SubItems.Add(s[3]);
                    item.SubItems.Add(s[4]);
                    
                    listView.Items.Add(item);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                user.Impor_CSV_DB(tbfile.Text, "Students");
                
            }
            if (radioButton2.Checked == true)
            {
                user.Impor_CSV_DB(tbfile.Text, "Courses");
                
            }
            MessageBox.Show("Import Successfully !!");
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
    }
}
