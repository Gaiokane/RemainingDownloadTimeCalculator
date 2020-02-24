using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemainingDownloadTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBtnMB.Checked = true;
            radioKBs.Checked = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double size = Convert.ToDouble(txtboxSize.Text);
            double speed = Convert.ToDouble(txtboxSpeed.Text);
            labelTimeLeft.Text = "剩余：" + DownloadTime(size, speed) + "分钟";
        }

        /// <summary>
        /// 根据文件大小和下载速度计算剩余下载时间，返回分钟
        /// </summary>
        /// <param name="Size">文件大小，单位MB</param>
        /// <param name="Speed">下载速度，单位KB/s</param>
        /// <returns></returns>
        private double DownloadTime(double Size, double Speed)
        {
            return Size / (Speed * 60 / 1024);
        }
    }
}