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
    public partial class EditHeaderRequest : Form
    {
        public EditHeaderRequest(List<string> ga, List<string> gb)
        {
            InitializeComponent();
            for (int i = 0; i < ga.Count(); i++)
            {
                richTextBox1.Text += ga[i] + ": " + gb[i] + "\r\n";
            }
        }

        public List<string> a { get; set; }
        public List<string> b { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] d = richTextBox1.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            a = new List<string>();
            b = new List<string>();
            for (int i = 0; i < d.Length; i++)
            {
                string s1 = d[i].Substring(0, d[i].IndexOf(":"));
                string s2 = d[i].Substring(d[i].IndexOf(":") + 1);
                a.Add(s1);
                b.Add(s2);
            }
            this.Close();
        }
    }
}
