using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace BatteryChargeReminder
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MinimixeMaximize();
        }

        private void minimizeMaximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimixeMaximize();
        }

        private void MinimixeMaximize()
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                
                

                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon1.ShowBalloonTip(100);
            }

            this.Activate();
            SetMimimizeMaximizeText();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();

                notifyIcon1.BalloonTipText = "To exit, right click on the notification icon and select Exit.";
                notifyIcon1.BalloonTipTitle = "Application is still running...";
                notifyIcon1.Text = "Battery Charge Reminder";

                notifyIcon1.ShowBalloonTip(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Properties.Settings.Default.MaxThreshold;
            comboBox2.SelectedIndex = Properties.Settings.Default.MinThreshold;

            pbBatteryStatus.Image = imageList1.Images["empty"];

            timer1.Interval = 1500;

            lblEstimatedTimeRemaining.Visible = false;
            lblEstimatedTimeRemainingValue.Visible = false;

            trackBar1.SetRange(20, 100);

            doubleTrackBar1.Minimum = 5;
            doubleTrackBar1.Maximum = 95;
            //
            // must set first the ValueRight
            doubleTrackBar1.ValueRight = Properties.Settings.Default.ValueRight;
            doubleTrackBar1.ValueLeft = Properties.Settings.Default.ValueLeft;

            toggleSwitch1.Checked = Properties.Settings.Default.Enabled;

            bool enabled = toggleSwitch1.Checked;

            lblEnabled.Text = enabled ? "Enabled" : "Disabled";

            doubleTrackBar1.Enabled = enabled;

            doubleTrackBar1.LeftThumbColor = enabled ? Color.DodgerBlue : Color.Gainsboro;
            doubleTrackBar1.RightThumbColor = enabled ? Color.DodgerBlue : Color.Gainsboro;

            disableToolStripMenuItem.Text = toggleSwitch1.Checked ? "Disable" : "Enable";
        }

        private void SetMimimizeMaximizeText()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                minimizeMaximizeToolStripMenuItem.Text = "Maximize";
            }
            else
            {
                minimizeMaximizeToolStripMenuItem.Text = "Minimize";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            SetMimimizeMaximizeText();

            disableToolStripMenuItem.Text = toggleSwitch1.Checked ? "Disable" : "Enable";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var status = SystemInformation.PowerStatus;
            var batteryStatus = (int)status.BatteryChargeStatus;
            var estimatedChargeRemaining = 100 * status.BatteryLifePercent;
            var batteryLifeRemaining = (int)status.BatteryLifeRemaining;
            var batteryFullLifetime = (int)status.BatteryFullLifetime;

            if (batteryStatus == 0)
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");

                foreach (ManagementObject mo in mos.Get())
                {
                    try
                    {
                        batteryStatus = Convert.ToInt32(mo["BatteryStatus"]);
                        break;
                    }
                    catch
                    {

                    }
                }
            }

            switch (status.PowerLineStatus)
            {
                case PowerLineStatus.Offline: // Unplugged
                    lblBatteryStatus.Text = string.Format("{0}%", estimatedChargeRemaining);
                    SetBatteryStatusImage(estimatedChargeRemaining, batteryLifeRemaining);
                    break;
                case PowerLineStatus.Online:
                    lblBatteryStatus.Text = string.Format("{0}%", estimatedChargeRemaining);
                    lblEstimatedTimeRemaining.Visible = true;
                    lblEstimatedTimeRemainingValue.Visible = true;
                    pbBatteryStatus.Image = imageList1.Images["charging"];

                    lblEstimatedTimeRemaining.Text = "Battery status:";
                    lblEstimatedTimeRemainingValue.Text = "Available (plugged in)";
                    /*
                    if (batteryFullLifetime > 0)
                    {
                        lblEstimatedTimeRemaining.Visible = true;
                        lblEstimatedTimeRemainingValue.Visible = true;
                        lblEstimatedTimeRemaining.Text = "Time until fully charged:";

                        int hours = batteryFullLifetime / 3600;
                        int mins = (batteryFullLifetime % 3600) / 60;

                        lblEstimatedTimeRemainingValue.Text = string.Format("{0}h {1}min", hours, mins);
                    }
                    */
                    break;
                default: // Unknown - Indicates an unknown battery condition.
                    lblEstimatedTimeRemaining.Visible = true;
                    lblEstimatedTimeRemainingValue.Visible = true;
                    lblEstimatedTimeRemaining.Text = "Status:";
                    lblEstimatedTimeRemainingValue.Text = "Unknown";
                    pbBatteryStatus.Image = imageList1.Images["unknown"];
                    break;
            }

            if (Math.Round(estimatedChargeRemaining) >= doubleTrackBar1.ValueRight)
            {
                if (status.PowerLineStatus == PowerLineStatus.Online)
                {
                    if (!toggleSwitch1.Checked)
                        return;

                    //MessageBox.Show("Unplug!");
                    notifyIcon1.Text = "Battery Charge Reminder";
                    notifyIcon1.BalloonTipTitle = "Unplug your laptop";
                    notifyIcon1.BalloonTipText = "Your battery charge level has reached " + doubleTrackBar1.ValueRight + "%.";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }

            if (Math.Round(estimatedChargeRemaining) < doubleTrackBar1.ValueLeft)
            {
                if (status.PowerLineStatus != PowerLineStatus.Online)
                {
                    if (!toggleSwitch1.Checked)
                        return;

                    notifyIcon1.Text = "Battery Charge Reminder";
                    notifyIcon1.BalloonTipTitle = "Connect your laptop to a charger";
                    notifyIcon1.BalloonTipText = "Your battery charge level is below " + doubleTrackBar1.ValueLeft + "%.";
                    notifyIcon1.ShowBalloonTip(5000);
                }
            }

            

            //loader.Visible = false;
        }

        private void SetBatteryStatusImage(float estimatedChargeRemaining, int batteryLifeRemaining)
        {
            if (estimatedChargeRemaining <= 30)
                pbBatteryStatus.Image = imageList1.Images["low"];
            else if (estimatedChargeRemaining >= 31 && estimatedChargeRemaining <= 79)
                pbBatteryStatus.Image = imageList1.Images["medium"];
            else if (estimatedChargeRemaining >= 80 && estimatedChargeRemaining <= 99)
                pbBatteryStatus.Image = imageList1.Images["high"];
            else if (estimatedChargeRemaining == 100)
                pbBatteryStatus.Image = imageList1.Images["full"];
            else
                pbBatteryStatus.Image = imageList1.Images["unknown"];

            if (batteryLifeRemaining == -1)
            {
                lblEstimatedTimeRemaining.Visible = false;
                lblEstimatedTimeRemainingValue.Visible = false;
                //lblEstimatedTimeRemaining.Text = "Battery status: Unknown";
                //lblEstimatedTimeRemainingValue.Text = "Unknown";
                //pbBatteryStatus.Image = imageList1.Images["unknown"];
            }
            else if (batteryLifeRemaining > 0)
            {
                lblEstimatedTimeRemaining.Visible = true;
                lblEstimatedTimeRemainingValue.Visible = true;
                lblEstimatedTimeRemaining.Text = "Estimated time remaining:";

                int hours = batteryLifeRemaining / 3600;
                int mins = (batteryLifeRemaining % 3600) / 60;

                lblEstimatedTimeRemainingValue.Text = string.Format("{0}h {1}min", hours, mins);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // must set first the ValueRight
            Properties.Settings.Default.ValueRight = doubleTrackBar1.ValueRight;
            Properties.Settings.Default.ValueLeft = doubleTrackBar1.ValueLeft;

            Properties.Settings.Default.Enabled = toggleSwitch1.Checked;

            Properties.Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxThreshold = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinThreshold = comboBox2.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void doubleTrackBar1_LeftValueChanged(object sender, EventArgs e)
        {
            lblValueLeft.Text = doubleTrackBar1.ValueLeft.ToString() + "%";
        }

        private void doubleTrackBar1_RightValueChanged(object sender, EventArgs e)
        {
            lblValueRight.Text = doubleTrackBar1.ValueRight.ToString() + "%";
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = toggleSwitch1.Checked;

            lblEnabled.Text = enabled ? "Enabled" : "Disabled";
            
            doubleTrackBar1.Enabled = enabled;

            doubleTrackBar1.LeftThumbColor = enabled ? Color.DodgerBlue : Color.Gainsboro;
            doubleTrackBar1.RightThumbColor = enabled ? Color.DodgerBlue : Color.Gainsboro;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleSwitch1.Checked = !toggleSwitch1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssemblyInfo info = new AssemblyInfo();

            MessageBox.Show(info.Title + "\n" + "v" + info.AssemblyVersion + "\n\n" + info.Company +"\n" + info.Copyright + "\n\nContact: " + info.Trademark, "About");
        }
    }

}
