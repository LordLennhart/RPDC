using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RDPC {
    public partial class PasswordWindow : Form {
        public PasswordWindow() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Location = new Point(this.Location.X, this.Location.Y - 35);
            this.FormBorderStyle = FormBorderStyle.None;
            wrongpLabel.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13 && passwordBox.Text == "ComT3K!1923#tWo&") {
                Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\rdpprof.rdp");
                this.Close();
            } else if (e.KeyChar == (char)13 && passwordBox.Text != "ComT3K!1923#tWo&") {
                passwordBox.Text = "";
                wrongpLabel.Visible = true;
                Animations.Shake(this);
            }  
            if (e.KeyChar == (char)27) this.Close();
        }
    }
}
