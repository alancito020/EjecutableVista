using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace carga2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\ferna\source\repos\carga2\progressbar.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //--------------------------Este si funciono (codigo para que CMD no abra)--------------------------------------------
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.FileName = @"C:\Users\ferna\source\repos\carga2\autoScan.bat";
            Process.Start(psi);
            Process.WaitForExit(psi);
            //--------------------------------------------
            //Process.Start(@"C:\Users\ferna\source\repos\carga2\autoScan.bat");
            //--------------------------------------------
            /*System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\Users\ferna\source\repos\carga2\autoScan.bat";//"C:\\scripts\\batchfile1.bat";
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();
            proc.WaitForExit();*/
            //-----------------------------------------------------------------------
            /*Process proc = null;
            try
            {
                string targetDir = string.Format(@"C:\Users\ferna\source\repos\carga2");//this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "autoScan.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                //proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }*/

        }
    }
}
