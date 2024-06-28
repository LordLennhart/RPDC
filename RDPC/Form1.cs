using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace RDPC
{
    public partial class Form1 : Form   
    {
        #region DLLImport

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("user32")]
        public static extern int GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] keystate);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static bool WindowsLogOff() {
            return ExitWindowsEx(0, 0);
        }
        #endregion
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private bool IsSqaureFormat_;

        public Form1()
        {
            InitializeComponent();
            loadingLabel.Visible = false;
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            CreateRDP();
            creationLabel.Text = "ComTec GMBH";
            this.openrdpLabel.Visible = false;
            SquareFormatLarge(2);
            IsSqaureFormat_ = true;
        }


        private void connectBtn_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", folder + @"\rdpprof.rdp");
            Task.Run(new Action(() => LoadingAnimation(loadingLabel, Animations.ConnectingArr, 250, 3)));
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private bool CMDShell(string arg) {
            try{
                var process = new Process();
                var startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"shutdown /{arg} /t 0";
                process.StartInfo = startInfo;
                process.Start();
                return true;
            } catch {
                return false;
            }

        }

        private void rebootBtn_Click(object sender, EventArgs e) {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void signoffBtn_Click(object sender, EventArgs e) {       
            bool isOut = WindowsLogOff();
            if (!isOut){
                loadingLabel.Text = "Failed to Sign Off!";
                loadingLabel.Visible = true;
            }
        }

        private void LoadingAnimation(Label label, String[] arr, int intervall, int reps) {
            if (InvokeRequired) this.Invoke(new Action(() => label.Visible = true));
            for(int x = 0; x < reps; x ++) {
                for (int i = 0; i < arr.Length; i++) {
                    if (InvokeRequired) this.Invoke(new Action(() => label.Text = arr[i]));
                    else label.Text = arr[i];
                    Thread.Sleep(intervall);
                }
            }
            if (InvokeRequired) this.Invoke(new Action(() => label.Visible = false));
        }

        private void openrdpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //Process.Start("notepad.exe", folder + @"\rdpprof.rdp");
            PasswordWindow passwin = new PasswordWindow();  
            passwin.ShowDialog();
        }

        private void CreateRDP() {
            try{
                if (!File.Exists(folder + @"\rdpprof.rdp")){
                    File.Create(folder + @"\rdpprof.rdp").Close();
                    File.WriteAllText(folder + @"\rdpprof.rdp", Animations.RDPConfig);  
                }
            } catch {
                MessageBox.Show("Failed to Create RDP File!");
            }
        }

        private void creationLabel_MouseLeave(object sender, EventArgs e) {
            creationLabel.Text = "ComTec GMBH";
        }

        private void creationLabel_MouseEnter(object sender, EventArgs e) {
            creationLabel.Text = "Made By Lennart Schröder";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            byte[] keys = new byte[256];
            GetKeyboardState(keys);
            if((keys[(int)Keys.ControlKey] & keys[(int) Keys.P] & 128) == 128) {
                PasswordWindow passwin = new PasswordWindow();
                passwin.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.KeyPreview = true;
        }

        private void panel2_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void closeImage_MouseEnter(object sender, EventArgs e) {
            closeImage.BackgroundImage = Properties.Resources.Xrot;
        }

        private void closeImage_MouseLeave(object sender, EventArgs e) {
            closeImage.BackgroundImage = Properties.Resources.X;
        }

        private void dragAreaPanel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SquareFormat() {
            this.Size = new Size(380, 190);
            panel1.Size = new Size(200, 110);
            panel1.Location = new Point(12, 43);
            panel1.BackgroundImage = Properties.Resources.SqaureComTecLogo;
            connectBtn.Location = new Point(255, 43);
            shutdownBtn.Location = new Point(255, 72);
            rebootBtn.Location = new Point(255, 101);
            signoffBtn.Location = new Point(255, 130);
            creationLabel.Location = new Point(12, 156);
            closeImage.Location = new Point(355, 9);
            dragAreaPanel.Size = new Size(312, 24);
            dragAreaPanel.Location = new Point(12, 0);        // 355, 9
            changeFormatPanel.Location = new Point(331, 6); // 355, 166
            changeFormatPanel.BackgroundImage = Properties.Resources.RectangleIcon;
        }

        private void RectangleFormat() {
            this.Size = new Size(719, 119);
            panel1.Size = new Size(250, 69);
            panel1.Location = new Point(12, 24);
            panel1.BackgroundImage = Properties.Resources.ComTec_Logo_ohne_Schriftzug_transparent_1_;
            connectBtn.Location = new Point(268, 57);
            shutdownBtn.Location = new Point(379, 57);
            rebootBtn.Location = new Point(490, 57);
            signoffBtn.Location = new Point(602, 57);
            creationLabel.Location = new Point(12, 97);
            closeImage.Location = new Point(694, 5);
            dragAreaPanel.Size = new Size(676, 16);
            dragAreaPanel.Location = new Point(12, 5);
            changeFormatPanel.Location = new Point(670, 5); // 691; 97
            changeFormatPanel.BackgroundImage = Properties.Resources.SqaureIcon;
        }
        private void SquareFormatLarge(int multiplier) {
            this.Size = new Size(380 * multiplier, 190 * multiplier);
            panel1.Size = new Size(200 * multiplier, 110 * multiplier);
            panel1.Location = new Point(12 * multiplier, 43 * multiplier);
            panel1.BackgroundImage = Properties.Resources.ComtecSqaureLogoLarge;
            connectBtn.Location = new Point(255 * multiplier, 43 * multiplier);
            shutdownBtn.Location = new Point(255 * multiplier, 72 * multiplier);
            rebootBtn.Location = new Point(255 * multiplier, 101 * multiplier);
            signoffBtn.Location = new Point(255 * multiplier, 130 * multiplier);
            creationLabel.Location = new Point(12 * multiplier, 156 * multiplier);
            closeImage.Location = new Point(355 * multiplier, 9 * multiplier);
            dragAreaPanel.Size = new Size(312 * multiplier, 24 * multiplier);
            dragAreaPanel.Location = new Point(12 * multiplier, 0 * multiplier);        // 355, 9
            changeFormatPanel.Location = new Point(331 * multiplier, 6 * multiplier); // 355, 166
            changeFormatPanel.BackgroundImage = Properties.Resources.RectangleIcon;
        }

        private void changeFormatPanel_Click(object sender, EventArgs e) {
            if (!IsSqaureFormat_){
                SquareFormat();
                IsSqaureFormat_ = true;
            }
            else{
                RectangleFormat();
                IsSqaureFormat_ = false;
            }
        }
    }
}
    

