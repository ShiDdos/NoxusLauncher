using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Threading;
using System.Reflection.Emit;
using System.Net;
using System.IO;

namespace NoxusLauncher
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            var sesion = MSession.GetOfflineSession(LoginScreen.user);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static string version;

        MSession session;

        private void path()
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add(string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };
            launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
            };


            foreach (var item in launcher.GetAllVersions())
            {
                versioncombobox.Items.Add(item.Name);
            }
        }

        private void launch()
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                label2.Text = (string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount));
            };
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 4096,
                Session = MSession.GetOfflineSession(LoginScreen.user),
            };

            version = versioncombobox.SelectedItem.ToString();
            var process = launcher.CreateProcess(version, launchOption);

            process.Start();
            Hide();
        }

        private void kullanici_adi_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            kullanici_adi.Text = LoginScreen.user;
            var request = WebRequest.Create("https://minotar.net/helm/" + kullanici_adi.Text +"/65.png");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
             pictureBox1.Image = Bitmap.FromStream(stream);
            }
            path();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            btn_oyna.Enabled = false;
            Thread thread = new Thread(() => launch());
            thread.IsBackground= true;
            thread.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 500)
                timer1.Stop();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Ayarlar ay = new Ayarlar();
            ay.Show();
        }

        private void versioncombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
