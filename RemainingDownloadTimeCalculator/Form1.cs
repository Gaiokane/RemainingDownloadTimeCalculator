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

            txtboxSize.Text = "100";
            txtboxSpeed.Text = "600";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double size = Convert.ToDouble(txtboxSize.Text);
            double speed = Convert.ToDouble(txtboxSpeed.Text);
            labelTimeLeft.Text = "剩余：" + DownloadTime(size, speed);
        }

        /// <summary>
        /// 根据文件大小和下载速度计算剩余下载时间，返回剩余时间（含单位）
        /// </summary>
        /// <param name="Size">文件大小，单位MB</param>
        /// <param name="Speed">下载速度，单位KB/s</param>
        /// <returns></returns>
        private string DownloadTime(double Size, double Speed)
        {
            double time = Size * 1024 / Speed;//剩余多少秒
            //MessageBox.Show((time % 60).ToString());
            if (time / 60 == 0)//不超过1分钟
            {
                return time + "秒";
            }
            else//超过1分钟
            {
                if (time / (60 * 60) == 0)//不超过1小时
                {
                    return time / 60 + "分钟" + time % 60 + "秒";
                }
                else//超过1小时
                {
                    if (time / (60 * 60 * 24) == 0)//不超过1天
                    {
                        return time / (60 * 60) + "小时" + time % (60 * 60) + "分钟" + time % 60 + "秒";
                    }
                    else//超过1天
                    {
                        return time / (60 * 60 * 24) + "天" + time % (60 * 60) + "小时" + time % (60 * 60) + "分钟" + time % 60 + "秒";
                    }
                }
            }
        }
    }
}