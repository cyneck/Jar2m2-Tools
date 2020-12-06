using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormJar2m2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.textBoxFilePath.Text = file.FileName;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxGroupId.Text))
            {
                MessageBox.Show("groupId不能为空");
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxArtifactId.Text))
            {
                MessageBox.Show("artifactId不能为空");
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxVersion.Text))
            {
                MessageBox.Show("version不能为空");
                return;
            }
            if (string.IsNullOrEmpty(this.textBoxFilePath.Text))
            {
                MessageBox.Show("jar包不能为空");
                return;
            }

            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();

            string strInput = "mvn install:install-file " +
                " -DgroupId=" + this.textBoxGroupId.Text +
                " -DartifactId=" + this.textBoxArtifactId.Text +
                " -Dversion=" + this.textBoxVersion.Text +
                " -Dpackaging=jar" +
                " -Dfile=" + this.textBoxFilePath.Text;
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput + "&exit");

            p.StandardInput.AutoFlush = true;

            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();

            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();

            MessageBox.Show(output);
            Console.WriteLine(output);
        }

    }
}
