using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class HeaderRespone : Form
    {
        public HeaderRespone(WebHeaderCollection whc)
        {
            if (whc == null)
            {
                whc = new WebHeaderCollection();
            }    
            InitializeComponent();
            string[] headername = whc.AllKeys;
            for (int i = 0; i < whc.Count; i++)
            {
                ListViewItem f = new ListViewItem((i + 1).ToString());
                f.SubItems.Add(headername[i]);
                f.SubItems.Add(whc[i]);
                listView1.Items.Add(f);
            }
        }
    }
}
