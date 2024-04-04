using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace AlexFormsPlus
{
    public partial class Form5 : Form
    {
        private WebView2 webView;

        public Form5()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private void InitializeWebView()
        {
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            Controls.Add(webView);
            webView.Source = new Uri("https://www.ldoceonline.com/");
        }
    }
}
