using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        private static extern bool AnimateWindow(IntPtr handle, int ms, int flags);

        public MainForm()
        {
            // panel1-> 标准计算器
            // panel2-> 科学计算器 
            // panel3-> 输入与结果（顶端为结果，底端为输入内容） 
            // panel5-> 程序员计算器 

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 居中逐渐显示
            AnimateWindow(this.Handle, 1000, 0x90000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 隐藏其他的计算器
            this.panel2.Visible = false;
            this.panel1.Visible = true;
            this.StandardToolStripMenuItem.Checked = true;
        }

        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = false;
            this.ProgrammerToolStripMenuItem.Checked = false;

            // 重设主窗体尺寸
            this.Width = 292;
            this.Height = 381;

            // 重新排列panel1和panel2
            this.panel1.Left = 6;
            this.panel1.Top = 77;

            // 隐藏科学计算器
            this.panel2.Visible = false;
            this.panel5.Visible = false;
            this.panel8.Visible = false;
        }

        private void ScientificToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = true;
            this.ProgrammerToolStripMenuItem.Checked = false;

            // 重设主窗体尺寸
            this.Width = 562;
            this.Height = 381;

            // 重新排列panel1和panel2
            this.panel2.Left = 6;
            this.panel1.Left = 277;

            this.panel2.Top = 77;
            this.panel1.Top = 77;

            // 显示科学计算器
            this.panel2.Visible = true;
            this.panel5.Visible = false;
            this.panel8.Visible = false;
        }

        private void ProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = false;
            this.ProgrammerToolStripMenuItem.Checked = true;

            // 重设主窗体尺寸
            this.Width = 562;
            this.Height = 473;

            // 重新排列panel1和panel2
            this.panel8.Top = 77;
            this.panel8.Left = 10;

            this.panel5.Top = 165;
            this.panel1.Top = 165;

            this.panel5.Left = 6;
            this.panel1.Left = 277;

            // 显示程序员计算器
            this.panel2.Visible = false;
            this.panel5.Visible = true;
            this.panel8.Visible = true;
        }
    }
}
