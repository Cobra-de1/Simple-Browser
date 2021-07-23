using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class ViewSource : Form
    {
        public ViewSource(string pagesource)
        {
            InitializeComponent();
            richTextBox1.AutoSize = true;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            richTextBox1.Height = 900;
            richTextBox1.Width = 1540;
            richTextBox1.Text = pagesource;
        }
    }
}
