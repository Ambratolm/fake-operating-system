using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using CSCore.SoundOut;
using CSCore.CoreAudioAPI;
using System.Reflection;
using FakeOS.Properties;
using System.IO;

namespace FakeOS
{
    public partial class Form_Chat : Form
    {
        bool smurfinaMode = false;
        SoundPlayer msnOnlineSound = new SoundPlayer(Resources.msn_online);
        SoundPlayer msnAlertSound = new SoundPlayer(Resources.msn_alert);
        SoundPlayer mouseClickSound = new SoundPlayer(Resources.mouse_click);
        AudioPlayer keyboardTypingSound = new AudioPlayer();

        public Form_Chat()
        {
            InitializeComponent();
            OpenKeyboardTypingSound();
        }

        private void OpenKeyboardTypingSound()
        {
            using (MMDeviceEnumerator mmdeviceEnumerator = new MMDeviceEnumerator())
            {
                MMDevice defaultMMDevice = mmdeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                keyboardTypingSound.Open(Directory.GetCurrentDirectory() + @"\Resources\keyboard-typing.wav", defaultMMDevice);
            }
        }

        private void Form_Chat_Load(object sender, EventArgs e)
        {
            textBox_mask.Hide();
            textBox_message.Focus();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text.Trim();
            if (message != "")
            {
                string username = string.Empty;
                textBox_message.Clear();
                richTextBox_chat.SelectionStart = richTextBox_chat.TextLength;
                richTextBox_chat.SelectionLength = 0;
                richTextBox_chat.SelectionIndent = 50;
                if (smurfinaMode)
                {
                    msnAlertSound.Play();
                    username = "Smurfina : ";
                    richTextBox_chat.SelectionColor = Color.Red;
                }
                else
                {
                    mouseClickSound.Play();
                    username = "Ambratolm : ";
                    richTextBox_chat.SelectionColor = Color.Blue;
                    //richTextBox_chat.SelectionFont = new Font(richTextBox_chat.Font, FontStyle.Bold);
                }
                richTextBox_chat.AppendText(username + message + Environment.NewLine);
                richTextBox_chat.SelectionColor = richTextBox_chat.ForeColor;
                richTextBox_chat.SelectionBackColor = richTextBox_chat.BackColor;
            }
            richTextBox_chat.ScrollToCaret();
            textBox_message.Focus();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_message_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                if (smurfinaMode)
                {
                    smurfinaMode = false;
                    button_menu.Text = "Smurfina •";
                    textBox_message.ForeColor = Color.Black;
                    textBox_mask.Hide();
                }
                else
                {
                    msnOnlineSound.Play();
                    smurfinaMode = true;
                    button_menu.Text = "Smurfina (Typing...) •";
                    textBox_message.ForeColor = Color.White;
                    textBox_mask.Show();
                }
            }
        }

        private void textBox_mask_Enter(object sender, EventArgs e)
        {
            textBox_message.Focus();
        }

        private void textBox_message_TextChanged(object sender, EventArgs e)
        {
            if (!smurfinaMode) 
            {
        		if (!timerKeyboardTypingSound.Enabled &&
                	keyboardTypingSound.PlaybackState != PlaybackState.Playing)
                {
                	keyboardTypingSound.Play();
                	timerKeyboardTypingSound.Start();
                }
            	else
            	{
                	OpenKeyboardTypingSound();
                	keyboardTypingSound.Play();
                	timerKeyboardTypingSound.Start();
            	}
            }
        }

        private void timerKeyboardTypingSound_Tick(object sender, EventArgs e)
        {
            if (keyboardTypingSound.PlaybackState == PlaybackState.Playing)
            {
                keyboardTypingSound.Pause();
            }
            timerKeyboardTypingSound.Stop();
        }
    }
}
