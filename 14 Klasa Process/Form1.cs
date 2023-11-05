using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Klasa_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fExplorer_Click_1(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void fExcel_Click_1(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void fWord_Click_1(object sender, EventArgs e)
        {
            Process.Start("WINWord.exe");
        }

        private void fInfo_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
}