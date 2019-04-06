using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CefForm
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser cefBrowser = null;

        public Form1()
        {
            InitializeComponent();

            var settings = new CefSettings
            {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN",
                MultiThreadedMessageLoop = true,
            };
            Cef.Initialize(settings);
            cefBrowser = new ChromiumWebBrowser("https://www.html5tricks.com/tag/webgl");
            panel1.Controls.Add(cefBrowser);
            cefBrowser.Dock = DockStyle.Fill;

            // 绑定
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            cefBrowser.RegisterJsObject("Sharp", new JsEvent(), new CefSharp.BindingOptions() { CamelCaseJavascriptNames = false });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 加载页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cefBrowser.LoadHtml(Properties.Resources.htmlString);
        }

        private void 调用jsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cefBrowser.ExecuteScriptAsync("alert('C#的调用.')");
        }

        private void js调用cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cefBrowser.ExecuteScriptAsync("Sharp.MessageText='000';Sharp.ShowTest();");
            cefBrowser.ExecuteScriptAsync("Sharp.ShowString('ddd');");
        }

        private void webGLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
