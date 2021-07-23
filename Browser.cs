using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Browser : Form
    {        
        public Browser()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            webBrowser1.ScriptErrorsSuppressed = true;
            web = new WebClient();
            htmltext = "";
            headera = new List<string>();
            headerb = new List<string>();
            nowheadera = new List<string>();
            nowheaderb = new List<string>();
            headera.Add("accept");
            headera.Add("user-agent");
            headerb.Add("text / html, application / xhtml + xml, application / xml; q = 0.9,image / avif,image / webp,image / apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            headerb.Add("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36");
            nowheadera.Add("accept");
            nowheadera.Add("user-agent");
            nowheaderb.Add("text / html, application / xhtml + xml, application / xml; q = 0.9,image / avif,image / webp,image / apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            nowheaderb.Add("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36");
        }
        WebClient web;
        string htmltext;
        List<string> headera; 
        List<string> headerb;
        List<string> nowheadera;
        List<string> nowheaderb;

        void createrequest(List<string> a, List<string> b)
        {
            web = new WebClient();
            nowheadera.Clear();
            nowheaderb.Clear();
            for (int i = 0; i < a.Count(); i++)
            {
                web.Headers.Add(a[i], b[i]);
                nowheadera.Add(a[i]);
                nowheaderb.Add(b[i]);
            }
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(search.Text, headera, headerb);
            }
        }

        private void Navigate(String address, List<string> ra, List<string> rb)
        {
            string saveaddress = address;
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            createrequest(ra, rb);
            try
            {
                //webBrowser1.Navigate(new Uri(address));
                byte[] respone = web.DownloadData(address);
                WebHeaderCollection whc = web.ResponseHeaders;
                htmltext = Encoding.UTF8.GetString(respone);
                webBrowser1.DocumentText = htmltext;
                search.Text = address;
            }
            catch
            {
                address = "https://www.google.com/search?q=" + saveaddress;
                byte[] respone = web.DownloadData(address);
                WebHeaderCollection whc = web.ResponseHeaders;
                htmltext = Encoding.UTF8.GetString(respone);
                webBrowser1.DocumentText = htmltext;
                search.Text = address;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void View_Click(object sender, EventArgs e)
        {
            Form f = new ViewSource(webBrowser1.DocumentText);
            f.Show();
        }
        public void GetAllFiles()
        {            
            System.IO.Directory.CreateDirectory("source");
            string pattern = "(?<=(href| src)=\")[\\.\\:/\\w -]*(?=\")";
            Regex rgx = new Regex(pattern);
            foreach (Match match in rgx.Matches(webBrowser1.DocumentText))
            {
                WebClient myclient = new WebClient();
                string s = match.Value;   
                try
                {
                    myclient.DownloadFile(s, "source/" + s.Substring(s.LastIndexOf("/")));
                }
                catch
                {
                }
            }
            try
            {
                FileStream d = new FileStream("file.html", FileMode.Create);
                StreamWriter s = new StreamWriter(d);
                s.Write(webBrowser1.DocumentText);
            }
            catch
            {
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Url.ToString() != String.Empty)
            {
                GetAllFiles();
            }
        }

        private void HeaderRequest_Click(object sender, EventArgs e)
        {   
            using (var form = new EditHeaderRequest(nowheadera, nowheaderb))
            {
                var result = form.ShowDialog();                
                if (form.a != null && form.b != null)
                {
                    Navigate(search.Text, form.a, form.b);
                }
            }
        }

        private void HeaderRespone_Click(object sender, EventArgs e)
        {
            WebHeaderCollection whc = web.ResponseHeaders;
            Form f = new HeaderRespone(whc);
            f.Show();
        }
    }
}
