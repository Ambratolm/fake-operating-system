namespace FakeOS
{
    partial class Form_Desktop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Desktop));
            this.taskbar = new System.Windows.Forms.ToolStrip();
            this.empty_area_1 = new System.Windows.Forms.ToolStripButton();
            this.empty_area_2 = new System.Windows.Forms.ToolStripButton();
            this.button_menu = new System.Windows.Forms.ToolStripButton();
            this.button_time = new System.Windows.Forms.ToolStripButton();
            this.button_sound = new System.Windows.Forms.ToolStripButton();
            this.button_network = new System.Windows.Forms.ToolStripButton();
            this.separator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_light = new System.Windows.Forms.ToolStripButton();
            this.button_more = new System.Windows.Forms.ToolStripButton();
            this.button_program = new System.Windows.Forms.ToolStripButton();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.notificationZone = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button_trash = new System.Windows.Forms.Button();
            this.button_messages = new System.Windows.Forms.Button();
            this.button_lol = new System.Windows.Forms.Button();
            this.button_library = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_computer = new System.Windows.Forms.Button();
            this.taskbar.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.notificationZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.LightGray;
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskbar.Font = new System.Drawing.Font("Free Pixel", 20F);
            this.taskbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.taskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empty_area_1,
            this.empty_area_2,
            this.button_menu,
            this.button_time,
            this.button_sound,
            this.button_network,
            this.separator_1,
            this.button_light,
            this.button_more,
            this.button_program});
            this.taskbar.Location = new System.Drawing.Point(0, 413);
            this.taskbar.Name = "taskbar";
            this.taskbar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.taskbar.Size = new System.Drawing.Size(634, 39);
            this.taskbar.TabIndex = 3;
            this.taskbar.Text = "toolStrip1";
            // 
            // empty_area_1
            // 
            this.empty_area_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empty_area_1.Enabled = false;
            this.empty_area_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.empty_area_1.Name = "empty_area_1";
            this.empty_area_1.Size = new System.Drawing.Size(23, 36);
            // 
            // empty_area_2
            // 
            this.empty_area_2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.empty_area_2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empty_area_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.empty_area_2.Name = "empty_area_2";
            this.empty_area_2.Size = new System.Drawing.Size(23, 36);
            this.empty_area_2.Text = "Display Desktop";
            // 
            // button_menu
            // 
            this.button_menu.Image = global::FakeOS.Properties.Resources.house;
            this.button_menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.button_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(106, 36);
            this.button_menu.Text = "Menu";
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_time
            // 
            this.button_time.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_time.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_time.Image = ((System.Drawing.Image)(resources.GetObject("button_time.Image")));
            this.button_time.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_time.Name = "button_time";
            this.button_time.Size = new System.Drawing.Size(88, 36);
            this.button_time.Text = "00:00";
            // 
            // button_sound
            // 
            this.button_sound.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_sound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_sound.Image = global::FakeOS.Properties.Resources.sound;
            this.button_sound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_sound.Name = "button_sound";
            this.button_sound.Size = new System.Drawing.Size(23, 36);
            this.button_sound.Text = "Sound";
            // 
            // button_network
            // 
            this.button_network.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_network.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_network.Image = global::FakeOS.Properties.Resources.network_wireless;
            this.button_network.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_network.Name = "button_network";
            this.button_network.Size = new System.Drawing.Size(23, 36);
            this.button_network.Text = "Network";
            // 
            // separator_1
            // 
            this.separator_1.Name = "separator_1";
            this.separator_1.Size = new System.Drawing.Size(6, 39);
            // 
            // button_light
            // 
            this.button_light.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_light.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_light.Image = global::FakeOS.Properties.Resources.lightbulb;
            this.button_light.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_light.Name = "button_light";
            this.button_light.Size = new System.Drawing.Size(23, 36);
            this.button_light.Text = "Full charge (100%)";
            // 
            // button_more
            // 
            this.button_more.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_more.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_more.Image = global::FakeOS.Properties.Resources.bullet_arrow_up;
            this.button_more.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_more.Name = "button_more";
            this.button_more.Size = new System.Drawing.Size(23, 36);
            this.button_more.Text = "Show More";
            this.button_more.Click += new System.EventHandler(this.button_more_Click);
            // 
            // button_program
            // 
            this.button_program.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_program.Image = ((System.Drawing.Image)(resources.GetObject("button_program.Image")));
            this.button_program.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_program.Name = "button_program";
            this.button_program.Size = new System.Drawing.Size(23, 36);
            // 
            // timer_1
            // 
            this.timer_1.Interval = 1000;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.button5);
            this.menu.Controls.Add(this.button4);
            this.menu.Controls.Add(this.button3);
            this.menu.Controls.Add(this.button2);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.pictureBox_profile);
            this.menu.Location = new System.Drawing.Point(313, 15);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(241, 296);
            this.menu.TabIndex = 4;
            this.menu.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(81, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ambratolm\r\n(Admin)";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::FakeOS.Properties.Resources.setting_tools;
            this.button4.Location = new System.Drawing.Point(10, 233);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Settings";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::FakeOS.Properties.Resources.robot;
            this.button3.Location = new System.Drawing.Point(10, 183);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Devices";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::FakeOS.Properties.Resources.computer;
            this.button2.Location = new System.Drawing.Point(10, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Computer";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::FakeOS.Properties.Resources.application_cascade;
            this.button1.Location = new System.Drawing.Point(10, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "All Programs";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.BackColor = System.Drawing.Color.White;
            this.pictureBox_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_profile.Image = global::FakeOS.Properties.Resources.kutu;
            this.pictureBox_profile.Location = new System.Drawing.Point(10, 12);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 0;
            this.pictureBox_profile.TabStop = false;
            // 
            // notificationZone
            // 
            this.notificationZone.BackColor = System.Drawing.SystemColors.Control;
            this.notificationZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationZone.Controls.Add(this.button10);
            this.notificationZone.Controls.Add(this.button9);
            this.notificationZone.Controls.Add(this.button8);
            this.notificationZone.Controls.Add(this.button7);
            this.notificationZone.Location = new System.Drawing.Point(269, 357);
            this.notificationZone.Name = "notificationZone";
            this.notificationZone.Size = new System.Drawing.Size(184, 53);
            this.notificationZone.TabIndex = 5;
            this.notificationZone.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = global::FakeOS.Properties.Resources.system_monitor;
            this.button10.Location = new System.Drawing.Point(135, 9);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 32);
            this.button10.TabIndex = 3;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = global::FakeOS.Properties.Resources.update;
            this.button9.Location = new System.Drawing.Point(95, 9);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 3;
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::FakeOS.Properties.Resources.tick_shield;
            this.button8.Location = new System.Drawing.Point(55, 9);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 3;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::FakeOS.Properties.Resources.bluetooth;
            this.button7.Location = new System.Drawing.Point(15, 9);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 3;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button_trash
            // 
            this.button_trash.BackColor = System.Drawing.Color.Transparent;
            this.button_trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_trash.FlatAppearance.BorderSize = 0;
            this.button_trash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_trash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trash.ForeColor = System.Drawing.Color.Black;
            this.button_trash.Image = global::FakeOS.Properties.Resources.bin_recycle;
            this.button_trash.Location = new System.Drawing.Point(501, 318);
            this.button_trash.Margin = new System.Windows.Forms.Padding(4);
            this.button_trash.Name = "button_trash";
            this.button_trash.Size = new System.Drawing.Size(120, 80);
            this.button_trash.TabIndex = 2;
            this.button_trash.Text = "Trash";
            this.button_trash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_trash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_trash.UseVisualStyleBackColor = false;
            // 
            // button_messages
            // 
            this.button_messages.BackColor = System.Drawing.Color.Transparent;
            this.button_messages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_messages.FlatAppearance.BorderSize = 0;
            this.button_messages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_messages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_messages.ForeColor = System.Drawing.Color.Black;
            this.button_messages.Image = global::FakeOS.Properties.Resources.msn_messenger;
            this.button_messages.Location = new System.Drawing.Point(13, 189);
            this.button_messages.Margin = new System.Windows.Forms.Padding(4);
            this.button_messages.Name = "button_messages";
            this.button_messages.Size = new System.Drawing.Size(120, 80);
            this.button_messages.TabIndex = 2;
            this.button_messages.Text = "Messages";
            this.button_messages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_messages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_messages.UseVisualStyleBackColor = false;
            this.button_messages.Click += new System.EventHandler(this.button_messages_Click);
            // 
            // button_lol
            // 
            this.button_lol.BackColor = System.Drawing.Color.Transparent;
            this.button_lol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_lol.FlatAppearance.BorderSize = 0;
            this.button_lol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_lol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_lol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lol.ForeColor = System.Drawing.Color.Black;
            this.button_lol.Image = global::FakeOS.Properties.Resources.lol_client_icon1;
            this.button_lol.Location = new System.Drawing.Point(141, 15);
            this.button_lol.Margin = new System.Windows.Forms.Padding(4);
            this.button_lol.Name = "button_lol";
            this.button_lol.Size = new System.Drawing.Size(120, 80);
            this.button_lol.TabIndex = 2;
            this.button_lol.Text = "LoL";
            this.button_lol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_lol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_lol.UseVisualStyleBackColor = false;
            // 
            // button_library
            // 
            this.button_library.BackColor = System.Drawing.Color.Transparent;
            this.button_library.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_library.FlatAppearance.BorderSize = 0;
            this.button_library.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_library.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_library.ForeColor = System.Drawing.Color.Black;
            this.button_library.Image = global::FakeOS.Properties.Resources.folder_stand;
            this.button_library.Location = new System.Drawing.Point(13, 101);
            this.button_library.Margin = new System.Windows.Forms.Padding(4);
            this.button_library.Name = "button_library";
            this.button_library.Size = new System.Drawing.Size(120, 80);
            this.button_library.TabIndex = 2;
            this.button_library.Text = "Library";
            this.button_library.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_library.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::FakeOS.Properties.Resources.globe_africa;
            this.button6.Location = new System.Drawing.Point(13, 277);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 80);
            this.button6.TabIndex = 2;
            this.button6.Text = "Browser";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button_computer
            // 
            this.button_computer.BackColor = System.Drawing.Color.Transparent;
            this.button_computer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_computer.FlatAppearance.BorderSize = 0;
            this.button_computer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_computer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button_computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_computer.ForeColor = System.Drawing.Color.Black;
            this.button_computer.Image = global::FakeOS.Properties.Resources.computer;
            this.button_computer.Location = new System.Drawing.Point(13, 13);
            this.button_computer.Margin = new System.Windows.Forms.Padding(4);
            this.button_computer.Name = "button_computer";
            this.button_computer.Size = new System.Drawing.Size(120, 80);
            this.button_computer.TabIndex = 2;
            this.button_computer.Text = "Computer";
            this.button_computer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_computer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_computer.UseVisualStyleBackColor = false;
            // 
            // Form_Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.notificationZone);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.button_trash);
            this.Controls.Add(this.button_messages);
            this.Controls.Add(this.button_lol);
            this.Controls.Add(this.button_library);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_computer);
            this.Font = new System.Drawing.Font("Free Pixel", 17F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operating System";
            this.taskbar.ResumeLayout(false);
            this.taskbar.PerformLayout();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.notificationZone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_computer;
        private System.Windows.Forms.Button button_library;
        private System.Windows.Forms.Button button_lol;
        private System.Windows.Forms.Button button_trash;
        private System.Windows.Forms.Button button_messages;
        private System.Windows.Forms.ToolStrip taskbar;
        private System.Windows.Forms.ToolStripButton button_menu;
        private System.Windows.Forms.ToolStripButton button_sound;
        private System.Windows.Forms.ToolStripButton button_more;
        private System.Windows.Forms.ToolStripButton button_network;
        private System.Windows.Forms.ToolStripButton button_light;
        private System.Windows.Forms.ToolStripButton empty_area_1;
        private System.Windows.Forms.ToolStripButton empty_area_2;
        private System.Windows.Forms.ToolStripSeparator separator_1;
        private System.Windows.Forms.ToolStripButton button_time;
        private System.Windows.Forms.Timer timer_1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Panel notificationZone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripButton button_program;
    }
}

