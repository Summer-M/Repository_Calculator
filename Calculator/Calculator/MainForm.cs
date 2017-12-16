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
            AnimateWindow(this.Handle, 1000, 0x00000001);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 隐藏其他的计算器
            this.panel2.Visible = false;
            this.panel1.Visible = true;
            this.StandardToolStripMenuItem.Checked = true;
        }

        /// <summary>
        /// 点击标准计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = false;
            this.ProgrammerToolStripMenuItem.Checked = false;

            // 重设主窗体尺寸
            Design_Form_Width = 292;
            Design_Form_Height = 381;
            Design_Form_Trend_Of_Change = (this.Width > Design_Form_Width || this.Height > Design_Form_Height) ? false : true;

            // 重新排列panel1和panel2
            this.panel1.Left = 6;
            this.panel1.Top = 77;

            // 隐藏科学计算器
            this.panel2.Visible = false;
            this.panel5.Visible = false;
            this.panel8.Visible = false;

            // 定时器更新窗体Size
            this.timer1.Start();
        }

        /// <summary>
        /// 点击科学计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScientificToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = true;
            this.ProgrammerToolStripMenuItem.Checked = false;

            // 重设主窗体尺寸
            Design_Form_Width = 562;
            Design_Form_Height = 381;
            Design_Form_Trend_Of_Change = (this.Width > Design_Form_Width || this.Height > Design_Form_Height) ? false : true;

            // 重新排列panel1和panel2
            this.panel2.Left = 6;
            this.panel1.Left = 277;

            this.panel2.Top = 77;
            this.panel1.Top = 77;

            // 显示科学计算器
            this.panel2.Visible = true;
            this.panel5.Visible = false;
            this.panel8.Visible = false;

            // 定时器更新窗体Size
            this.timer1.Start();
        }

        /// <summary>
        /// 点击程序员计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 更新菜单栏状态
            this.StandardToolStripMenuItem.Checked = true;
            this.ScientificToolStripMenuItem.Checked = false;
            this.ProgrammerToolStripMenuItem.Checked = true;

            // 重设主窗体尺寸
            Design_Form_Width = 562;
            Design_Form_Height = 473;
            Design_Form_Trend_Of_Change = (this.Width > Design_Form_Width || this.Height > Design_Form_Height) ? false : true;

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

            // 定时器更新窗体Size
            this.timer1.Start();
        }

        /// <summary>
        /// 定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Design_Form_Trend_Of_Change)
            {
                if (this.Width < Design_Form_Width)
                {
                    this.Width += 20;
                }
                else
                {
                    this.Width = Design_Form_Width;
                }

                if (this.Height < Design_Form_Height)
                {
                    this.Height += 20;
                }
                else
                {
                    this.Height = Design_Form_Height;
                }
            }
            else
            {
                if (this.Width > Design_Form_Width)
                {
                    this.Width -= 20;
                }
                else
                {
                    this.Width = Design_Form_Width;
                }

                if (this.Height > Design_Form_Height)
                {
                    this.Height -= 20;
                }
                else
                {
                    this.Height = Design_Form_Height;
                }
            }

            if (this.Width == Design_Form_Width && this.Height == Design_Form_Height)
            {
                this.timer1.Stop();
            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About m_About = new About();
            m_About.ShowInTaskbar = false;
            m_About.ShowDialog();
        }

        /// <summary>
        /// 设置TextBox1的值
        /// </summary>
        /// <param name="ButtonName"></param>
        private void SetTextBox1_Text(String ControlName)
        {
            this.textBox1.AppendText(ControlName);
        }

        /// <summary>
        /// 设置TextBox2的值
        /// </summary>
        /// <param name="ButtonName"></param>
        private void SetTextBox2_Text(String ControlName)
        {
            this.textBox2.AppendText(ControlName);
        }

        /// <summary>
        /// 清空TextBox1
        /// </summary>
        private void ClearTextBox1_Text()
        {
            this.textBox1.Text = "";
        }

        /// <summary>
        /// 清空TextBox2
        /// </summary>
        private void ClearTextBox2_Text()
        {
            this.textBox2.Text = "";
        }

        /// <summary>
        /// 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button28_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button28.Text);
        }

        /// <summary>
        /// 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button25.Text);
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button24.Text);
        }

        /// <summary>
        /// 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button23.Text);
        }

        /// <summary>
        /// 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button20.Text);
        }

        /// <summary>
        /// 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button19.Text);
        }

        /// <summary>
        /// 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button18.Text);
        }

        /// <summary>
        /// 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button15.Text);
        }

        /// <summary>
        /// 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false; }
            SetTextBox2_Text(this.button14.Text);
        }

        /// <summary>
        /// 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            if (Clear_Form_Order) { ClearTextBox2_Text(); Clear_Form_Order = false;}
            SetTextBox2_Text(this.button13.Text + this.button13.Text);
        }

        /// <summary>
        /// +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            SetTextBox1_Text(this.textBox2.Text + this.button26.Text);
            Clear_Form_Order = true;
        }

        /// <summary>
        /// -
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            SetTextBox1_Text(this.textBox2.Text + this.button22.Text);
            Clear_Form_Order = true;
        }

        /// <summary>
        /// *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            SetTextBox1_Text(this.textBox2.Text + this.button17.Text);
            Clear_Form_Order = true;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            SetTextBox1_Text(this.textBox2.Text + this.button12.Text);
            Clear_Form_Order = true;
        }
    }
}
