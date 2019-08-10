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
    public partial class Update_Score : Form
    {
        private User user;
        string GKs, CKs, Khacs, Tongs, MSSVs, Class;

        public Update_Score(User u, string GK, string CK, string Khac, string Tong, string MSSV, string classes)
        {
            InitializeComponent();
            user = u;
            CKtb.Text = CK;
            GKtb.Text = GK;
            Khactb.Text = Khac;
            Tongtb.Text = Tong;
            CKs = CK;
            Khacs = Khac;
            Tongs = Tong;
            GKs = GK;
            MSSVs = MSSV;
            Class = classes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GKs != GKtb.Text)
            {
                if (user.Update_Scores(GKtb.Text, "ĐiểmGK", MSSVs, Class))
                    MessageBox.Show("Update Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update Failed !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CKs != CKtb.Text)
            {
                if (user.Update_Scores(CKtb.Text, "ĐiểmCK", MSSVs, Class))
                    MessageBox.Show("Update Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update Failed !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Khacs !=Khactb.Text)
            {
                if (user.Update_Scores(Khactb.Text, "ĐiểmKhác", MSSVs, Class))
                    MessageBox.Show("Update Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update Failed !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Tongs != GKtb.Text)
            {
                if (user.Update_Scores(Tongtb.Text, "ĐiểmTổng", MSSVs, Class))
                    MessageBox.Show("Update Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update Failed !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
