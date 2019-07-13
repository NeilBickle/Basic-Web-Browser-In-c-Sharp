using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (WebBrwsrTest.CanGoBack)
            {
                WebBrwsrTest.GoBack();
            }
        }

        private void Btnfrwd_Click(object sender, EventArgs e)
        {
            if (WebBrwsrTest.CanGoForward)
            {
                WebBrwsrTest.GoForward();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            WebBrwsrTest.Navigate("www.google.co.uk");
        }

        private void BtnRfh_Click(object sender, EventArgs e)
        {
            WebBrwsrTest.Refresh();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string URL = TxtSearch.Text.Trim();
            WebBrwsrTest.Navigate(URL);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            WebBrwsrTest.Stop();
        }

        private void WebBrowser_Load(object sender, EventArgs e)
        {
            WebBrwsrTest.Navigate("www.google.co.uk");
        }
    }
}
