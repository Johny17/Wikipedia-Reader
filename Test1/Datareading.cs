using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;


namespace Test1
{
    public partial class Datareading : Form
    {
        public Datareading()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var webclient = new WebClient();
            var pageSourceCode = webclient.DownloadString("http://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + textBox1.Text + "&redirects=true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(pageSourceCode);

            var fmode = doc.GetElementsByTagName("extract")[0];


            try
            {
                string ss = fmode.InnerText;
                Regex regex = new Regex("<[^>]*>");
                string.Format("Before:{0}", ss);
                ss = regex.Replace(ss, string.Empty);
                string result = string.Format(ss);
                richTextBox1.Text += result;
                
            
            }
            catch (Exception)
            {
                richTextBox1.Text = "error";
            }

        }

    }
}
