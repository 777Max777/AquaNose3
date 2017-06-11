using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuadroSoft.Enose
{
    public partial class ReopenMap : Form
    {
        private string latitude;
        private string longitude;

        public ReopenMap(string lat, string lng)
        {
            latitude = lat;
            longitude = lng;

            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            try
            {
                WebBro.Navigate(new Uri(String.Format("file:///{0}/PageMap.html", curDir)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebBro.Document.GetElementById("lat").SetAttribute("value", latitude);
            WebBro.Document.GetElementById("lng").SetAttribute("value", longitude);
            WebBro.Document.GetElementById("btn").InvokeMember("click");
        }
    }
}
