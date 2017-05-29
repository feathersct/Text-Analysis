using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            versionLabel.Text = String.Format("Version {0}", AssemblyVersion); ;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
