using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FakeOS
{
    public partial class Form_Desktop : Form
    {
        public Form_Desktop()
        {
            InitializeComponent();
            timer_1.Start();
        }

        private void Form_Desktop_Load(object sender, EventArgs e)
        {
            timer_1.Start();
        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            button_time.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            menu.Location = new Point(taskbar.Location.X, taskbar.Location.Y - menu.Size.Height);
            menu.Show();
        }

        private void button_more_Click(object sender, EventArgs e)
        {
            notificationZone.Location = new Point(
                    taskbar.Location.X, 
                    taskbar.Location.Y
                );
            notificationZone.Show();
        }

        private const int WM_PARENTNOTIFY = 0x210;
        private const int WM_LBUTTONDOWN = 0x201;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY && (int)m.WParam == WM_LBUTTONDOWN))
            {
                if (!menu.ClientRectangle.Contains(menu.PointToClient(Cursor.Position)))
                {
                    menu.Hide();
                }
                if (!notificationZone.ClientRectangle.Contains(notificationZone.PointToClient(Cursor.Position)))
                {
                    notificationZone.Hide();
                }
            }
            base.WndProc(ref m);
        }

        private void button_messages_Click(object sender, EventArgs e)
        {
            Form_Messages messages = new Form_Messages();
            button_program.Text = "Messages (7)";
            messages.ShowDialog();
            button_program.Text = "";
        }
    }
}
