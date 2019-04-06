using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefForm
{
    public class JsEvent
    {
        public string MessageText { get; set; }
        public void ShowTest()
        {
            MessageBox.Show("this in c#.\n\r" + MessageText);
        }

        public void ShowString(object ss)
        {
            string str = ss.ToString();
            MessageBox.Show("收到Js参数的调用\n\r" + str);
        }

        /* public void ShowString(string ss)
         {
             MessageBox.Show("收到Js参数的调用\n\r" + ss);
         }

         public void ShowString(int ss)
         {
             MessageBox.Show("收到JsInt参数的调用\n\r" + ss.ToString());
         }*/
    }
}
