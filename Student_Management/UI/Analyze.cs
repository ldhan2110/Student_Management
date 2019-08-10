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
    public partial class Analyze : Form
    {
        public Analyze(float num_pass,float num_fail,string Class)
        {
            InitializeComponent();
            chart1.Titles.Add("THỐNG KÊ THEO PHẦN TRĂM ĐẬU/RỚT");
            chart1.Series["Đậu/Rớt"].IsValueShownAsLabel = true;
            chart1.Series["Đậu/Rớt"].Points.AddXY("Đậu", (num_pass/(num_pass+num_fail))*100);
            chart1.Series["Đậu/Rớt"].Points.AddXY("Rớt", (num_fail / (num_pass + num_fail)) * 100);

            chart2.Titles.Add("THỐNG KÊ THEO SỐ LƯỢNG ĐẬU/RỚT");
            chart2.Series["Đậu"].IsValueShownAsLabel = true;
            chart2.Series["Rớt"].IsValueShownAsLabel = true;
            chart2.Series["Đậu"].Points.AddXY(Class, num_pass);
            chart2.Series["Rớt"].Points.AddXY(Class, num_fail);

        }
    }
}
