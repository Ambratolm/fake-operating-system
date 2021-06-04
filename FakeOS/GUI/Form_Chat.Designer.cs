namespace FakeOS
{
    partial class Form_Chat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taskbar = new System.Windows.Forms.ToolStrip();
            this.button_close = new System.Windows.Forms.ToolStripButton();
            this.button_menu = new System.Windows.Forms.ToolStripButton();
            this.richTextBox_chat = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_mask = new System.Windows.Forms.TextBox();
            this.timerKeyboardTypingSound = new System.Windows.Forms.Timer(this.components);
            this.taskbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.SystemColors.Control;
            this.taskbar.Font = new System.Drawing.Font("Free Pixel", 20F);
            this.taskbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.taskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_close,
            this.button_menu});
            this.taskbar.Location = new System.Drawing.Point(0, 0);
            this.taskbar.Name = "taskbar";
            this.taskbar.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.taskbar.Size = new System.Drawing.Size(560, 39);
            this.taskbar.TabIndex = 2;
            this.taskbar.Text = "toolStrip1";
            // 
            // button_close
            // 
            this.button_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_close.Image = global::FakeOS.Properties.Resources.cross;
            this.button_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(23, 36);
            this.button_close.Text = "X";
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_menu
            // 
            this.button_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_menu.Image = global::FakeOS.Properties.Resources.user_devil;
            this.button_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.button_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(190, 36);
            this.button_menu.Text = "Smurfina •";
            // 
            // richTextBox_chat
            // 
            this.richTextBox_chat.BackColor = System.Drawing.Color.White;
            this.richTextBox_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_chat.Location = new System.Drawing.Point(0, 45);
            this.richTextBox_chat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.richTextBox_chat.Name = "richTextBox_chat";
            this.richTextBox_chat.ReadOnly = true;
            this.richTextBox_chat.Size = new System.Drawing.Size(560, 210);
            this.richTextBox_chat.TabIndex = 3;
            this.richTextBox_chat.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_message.Location = new System.Drawing.Point(13, 267);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(421, 33);
            this.textBox_message.TabIndex = 0;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            this.textBox_message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_message_KeyUp);
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_send.Location = new System.Drawing.Point(441, 267);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(107, 33);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send ►";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_mask
            // 
            this.textBox_mask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_mask.Location = new System.Drawing.Point(13, 267);
            this.textBox_mask.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_mask.Name = "textBox_mask";
            this.textBox_mask.Size = new System.Drawing.Size(421, 33);
            this.textBox_mask.TabIndex = 4;
            this.textBox_mask.Enter += new System.EventHandler(this.textBox_mask_Enter);
            // 
            // timerKeyboardTypingSound
            // 
            this.timerKeyboardTypingSound.Tick += new System.EventHandler(this.timerKeyboardTypingSound_Tick);
            // 
            // Form_Chat
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.textBox_mask);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.richTextBox_chat);
            this.Controls.Add(this.taskbar);
            this.Font = new System.Drawing.Font("Free Pixel", 17F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form_Chat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Chat";
            this.Load += new System.EventHandler(this.Form_Chat_Load);
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton button_menu;
        private System.Windows.Forms.ToolStripButton button_close;
        private System.Windows.Forms.ToolStrip taskbar;
        private System.Windows.Forms.RichTextBox richTextBox_chat;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_mask;
        private System.Windows.Forms.Timer timerKeyboardTypingSound;

    }
}