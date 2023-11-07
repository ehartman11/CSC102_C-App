using Moonbase.Properties;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Moonbase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GroupboxLocInfo = new System.Windows.Forms.GroupBox();
            this.TextboxRoomDescription = new System.Windows.Forms.TextBox();
            this.TextboxRoomName = new System.Windows.Forms.TextBox();
            this.LabelRoomDescription = new System.Windows.Forms.Label();
            this.LabelRoomName = new System.Windows.Forms.Label();
            this.groupBoxNavDev = new System.Windows.Forms.GroupBox();
            this.ButtonMap = new System.Windows.Forms.Button();
            this.ButtonBedroom = new System.Windows.Forms.Button();
            this.ButtonHallway = new System.Windows.Forms.Button();
            this.ButtonKitchen = new System.Windows.Forms.Button();
            this.ButtonHorticultureRm = new System.Windows.Forms.Button();
            this.ButtonBaseCtrlRm = new System.Windows.Forms.Button();
            this.ButtonLivingRm = new System.Windows.Forms.Button();
            this.ButtonRxCtrlRm = new System.Windows.Forms.Button();
            this.BaseMapPanel = new System.Windows.Forms.Panel();
            this.bsCtrlRmLbl = new System.Windows.Forms.Label();
            this.ktnLbl = new System.Windows.Forms.Label();
            this.lvgRmLbl = new System.Windows.Forms.Label();
            this.bdRmLbl = new System.Windows.Forms.Label();
            this.hrtRmLbl = new System.Windows.Forms.Label();
            this.hlwyLbl = new System.Windows.Forms.Label();
            this.rxCtrlRmLbl = new System.Windows.Forms.Label();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.closeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horticultureRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactorControlRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallwayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.GroupboxLocInfo.SuspendLayout();
            this.groupBoxNavDev.SuspendLayout();
            this.BaseMapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupboxLocInfo
            // 
            this.GroupboxLocInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupboxLocInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GroupboxLocInfo.Controls.Add(this.TextboxRoomDescription);
            this.GroupboxLocInfo.Controls.Add(this.TextboxRoomName);
            this.GroupboxLocInfo.Controls.Add(this.LabelRoomDescription);
            this.GroupboxLocInfo.Controls.Add(this.LabelRoomName);
            this.GroupboxLocInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxLocInfo.Location = new System.Drawing.Point(574, 408);
            this.GroupboxLocInfo.Name = "GroupboxLocInfo";
            this.GroupboxLocInfo.Size = new System.Drawing.Size(595, 214);
            this.GroupboxLocInfo.TabIndex = 0;
            this.GroupboxLocInfo.TabStop = false;
            this.GroupboxLocInfo.Text = "Location Information";
            // 
            // TextboxRoomDescription
            // 
            this.TextboxRoomDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextboxRoomDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxRoomDescription.Location = new System.Drawing.Point(22, 65);
            this.TextboxRoomDescription.Multiline = true;
            this.TextboxRoomDescription.Name = "TextboxRoomDescription";
            this.TextboxRoomDescription.ReadOnly = true;
            this.TextboxRoomDescription.Size = new System.Drawing.Size(553, 127);
            this.TextboxRoomDescription.TabIndex = 3;
            this.TextboxRoomDescription.Text = resources.GetString("TextboxRoomDescription.Text");
            // 
            // TextboxRoomName
            // 
            this.TextboxRoomName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextboxRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxRoomName.Location = new System.Drawing.Point(140, 22);
            this.TextboxRoomName.Name = "TextboxRoomName";
            this.TextboxRoomName.ReadOnly = true;
            this.TextboxRoomName.Size = new System.Drawing.Size(435, 22);
            this.TextboxRoomName.TabIndex = 2;
            this.TextboxRoomName.Text = "Reactor Control Room";
            // 
            // LabelRoomDescription
            // 
            this.LabelRoomDescription.AutoSize = true;
            this.LabelRoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomDescription.Location = new System.Drawing.Point(19, 46);
            this.LabelRoomDescription.Name = "LabelRoomDescription";
            this.LabelRoomDescription.Size = new System.Drawing.Size(115, 16);
            this.LabelRoomDescription.TabIndex = 1;
            this.LabelRoomDescription.Text = "Room Description";
            // 
            // LabelRoomName
            // 
            this.LabelRoomName.AutoSize = true;
            this.LabelRoomName.Location = new System.Drawing.Point(47, 21);
            this.LabelRoomName.Name = "LabelRoomName";
            this.LabelRoomName.Size = new System.Drawing.Size(87, 16);
            this.LabelRoomName.TabIndex = 0;
            this.LabelRoomName.Text = "Room Name:";
            // 
            // groupBoxNavDev
            // 
            this.groupBoxNavDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxNavDev.BackgroundImage = global::Moonbase.Properties.Resources.Navigation_device;
            this.groupBoxNavDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxNavDev.Controls.Add(this.ButtonTest);
            this.groupBoxNavDev.Controls.Add(this.ButtonMap);
            this.groupBoxNavDev.Controls.Add(this.ButtonBedroom);
            this.groupBoxNavDev.Controls.Add(this.ButtonHallway);
            this.groupBoxNavDev.Controls.Add(this.ButtonKitchen);
            this.groupBoxNavDev.Controls.Add(this.ButtonHorticultureRm);
            this.groupBoxNavDev.Controls.Add(this.ButtonBaseCtrlRm);
            this.groupBoxNavDev.Controls.Add(this.ButtonLivingRm);
            this.groupBoxNavDev.Controls.Add(this.ButtonRxCtrlRm);
            this.groupBoxNavDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNavDev.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxNavDev.Location = new System.Drawing.Point(12, 371);
            this.groupBoxNavDev.Name = "groupBoxNavDev";
            this.groupBoxNavDev.Size = new System.Drawing.Size(412, 248);
            this.groupBoxNavDev.TabIndex = 5;
            this.groupBoxNavDev.TabStop = false;
            this.groupBoxNavDev.Text = "Navigation Device";
            // 
            // ButtonMap
            // 
            this.ButtonMap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonMap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMap.Location = new System.Drawing.Point(65, 94);
            this.ButtonMap.Name = "ButtonMap";
            this.ButtonMap.Size = new System.Drawing.Size(87, 36);
            this.ButtonMap.TabIndex = 7;
            this.ButtonMap.Text = "Base Map";
            this.ButtonMap.UseVisualStyleBackColor = false;
            this.ButtonMap.Click += new System.EventHandler(this.ButtonMap_Click);
            // 
            // ButtonBedroom
            // 
            this.ButtonBedroom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonBedroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonBedroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBedroom.Location = new System.Drawing.Point(65, 145);
            this.ButtonBedroom.Name = "ButtonBedroom";
            this.ButtonBedroom.Size = new System.Drawing.Size(87, 36);
            this.ButtonBedroom.TabIndex = 6;
            this.ButtonBedroom.Text = "Bedroom";
            this.ButtonBedroom.UseVisualStyleBackColor = false;
            this.ButtonBedroom.Click += new System.EventHandler(this.ButtonBedroom_Click);
            // 
            // ButtonHallway
            // 
            this.ButtonHallway.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonHallway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonHallway.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHallway.Location = new System.Drawing.Point(172, 145);
            this.ButtonHallway.Name = "ButtonHallway";
            this.ButtonHallway.Size = new System.Drawing.Size(87, 36);
            this.ButtonHallway.TabIndex = 5;
            this.ButtonHallway.Text = "Hallway";
            this.ButtonHallway.UseVisualStyleBackColor = false;
            this.ButtonHallway.Click += new System.EventHandler(this.ButtonHallway_Click);
            // 
            // ButtonKitchen
            // 
            this.ButtonKitchen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonKitchen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonKitchen.Location = new System.Drawing.Point(280, 144);
            this.ButtonKitchen.Name = "ButtonKitchen";
            this.ButtonKitchen.Size = new System.Drawing.Size(87, 37);
            this.ButtonKitchen.TabIndex = 4;
            this.ButtonKitchen.Text = "Kitchen";
            this.ButtonKitchen.UseVisualStyleBackColor = false;
            this.ButtonKitchen.Click += new System.EventHandler(this.ButtonKitchen_Click);
            // 
            // ButtonHorticultureRm
            // 
            this.ButtonHorticultureRm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonHorticultureRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHorticultureRm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHorticultureRm.Location = new System.Drawing.Point(280, 45);
            this.ButtonHorticultureRm.Name = "ButtonHorticultureRm";
            this.ButtonHorticultureRm.Size = new System.Drawing.Size(87, 36);
            this.ButtonHorticultureRm.TabIndex = 3;
            this.ButtonHorticultureRm.Text = "Horticulture Room";
            this.ButtonHorticultureRm.UseVisualStyleBackColor = false;
            this.ButtonHorticultureRm.Click += new System.EventHandler(this.ButtonHorticultureRm_Click);
            // 
            // ButtonBaseCtrlRm
            // 
            this.ButtonBaseCtrlRm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonBaseCtrlRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBaseCtrlRm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBaseCtrlRm.Location = new System.Drawing.Point(172, 94);
            this.ButtonBaseCtrlRm.Name = "ButtonBaseCtrlRm";
            this.ButtonBaseCtrlRm.Size = new System.Drawing.Size(87, 36);
            this.ButtonBaseCtrlRm.TabIndex = 2;
            this.ButtonBaseCtrlRm.Text = "Base Control Room";
            this.ButtonBaseCtrlRm.UseVisualStyleBackColor = false;
            this.ButtonBaseCtrlRm.Click += new System.EventHandler(this.ButtonBaseCtrlRm_Click);
            // 
            // ButtonLivingRm
            // 
            this.ButtonLivingRm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonLivingRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLivingRm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonLivingRm.Location = new System.Drawing.Point(280, 94);
            this.ButtonLivingRm.Name = "ButtonLivingRm";
            this.ButtonLivingRm.Size = new System.Drawing.Size(87, 36);
            this.ButtonLivingRm.TabIndex = 1;
            this.ButtonLivingRm.Text = "Living Room";
            this.ButtonLivingRm.UseVisualStyleBackColor = false;
            this.ButtonLivingRm.Click += new System.EventHandler(this.ButtonLivingRm_Click);
            // 
            // ButtonRxCtrlRm
            // 
            this.ButtonRxCtrlRm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonRxCtrlRm.Enabled = false;
            this.ButtonRxCtrlRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRxCtrlRm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonRxCtrlRm.Location = new System.Drawing.Point(172, 45);
            this.ButtonRxCtrlRm.Name = "ButtonRxCtrlRm";
            this.ButtonRxCtrlRm.Size = new System.Drawing.Size(87, 36);
            this.ButtonRxCtrlRm.TabIndex = 0;
            this.ButtonRxCtrlRm.Text = "Reactor Control Room";
            this.ButtonRxCtrlRm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonRxCtrlRm.UseVisualStyleBackColor = false;
            this.ButtonRxCtrlRm.Click += new System.EventHandler(this.ButtonRxCtrlRm_Click);
            // 
            // BaseMapPanel
            // 
            this.BaseMapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseMapPanel.AutoSize = true;
            this.BaseMapPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BaseMapPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BaseMapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BaseMapPanel.Controls.Add(this.bsCtrlRmLbl);
            this.BaseMapPanel.Controls.Add(this.ktnLbl);
            this.BaseMapPanel.Controls.Add(this.lvgRmLbl);
            this.BaseMapPanel.Controls.Add(this.bdRmLbl);
            this.BaseMapPanel.Controls.Add(this.hrtRmLbl);
            this.BaseMapPanel.Controls.Add(this.hlwyLbl);
            this.BaseMapPanel.Controls.Add(this.rxCtrlRmLbl);
            this.BaseMapPanel.Controls.Add(this.mapPictureBox);
            this.BaseMapPanel.Controls.Add(this.menuStrip2);
            this.BaseMapPanel.Location = new System.Drawing.Point(540, 2);
            this.BaseMapPanel.MaximumSize = new System.Drawing.Size(1128, 633);
            this.BaseMapPanel.MinimumSize = new System.Drawing.Size(629, 410);
            this.BaseMapPanel.Name = "BaseMapPanel";
            this.BaseMapPanel.Size = new System.Drawing.Size(629, 410);
            this.BaseMapPanel.TabIndex = 6;
            this.BaseMapPanel.Visible = false;
            // 
            // bsCtrlRmLbl
            // 
            this.bsCtrlRmLbl.AutoSize = true;
            this.bsCtrlRmLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bsCtrlRmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bsCtrlRmLbl.Location = new System.Drawing.Point(424, 224);
            this.bsCtrlRmLbl.Name = "bsCtrlRmLbl";
            this.bsCtrlRmLbl.Size = new System.Drawing.Size(114, 15);
            this.bsCtrlRmLbl.TabIndex = 9;
            this.bsCtrlRmLbl.Text = "Base Control Room";
            // 
            // ktnLbl
            // 
            this.ktnLbl.AutoSize = true;
            this.ktnLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ktnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ktnLbl.Location = new System.Drawing.Point(541, 189);
            this.ktnLbl.Name = "ktnLbl";
            this.ktnLbl.Size = new System.Drawing.Size(48, 15);
            this.ktnLbl.TabIndex = 8;
            this.ktnLbl.Text = "Kitchen";
            // 
            // lvgRmLbl
            // 
            this.lvgRmLbl.AutoSize = true;
            this.lvgRmLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lvgRmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvgRmLbl.Location = new System.Drawing.Point(315, 124);
            this.lvgRmLbl.Name = "lvgRmLbl";
            this.lvgRmLbl.Size = new System.Drawing.Size(76, 15);
            this.lvgRmLbl.TabIndex = 7;
            this.lvgRmLbl.Text = "Living Room";
            // 
            // bdRmLbl
            // 
            this.bdRmLbl.AutoSize = true;
            this.bdRmLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bdRmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bdRmLbl.Location = new System.Drawing.Point(18, 95);
            this.bdRmLbl.Name = "bdRmLbl";
            this.bdRmLbl.Size = new System.Drawing.Size(58, 15);
            this.bdRmLbl.TabIndex = 6;
            this.bdRmLbl.Text = "Bedroom";
            // 
            // hrtRmLbl
            // 
            this.hrtRmLbl.AutoSize = true;
            this.hrtRmLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hrtRmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.hrtRmLbl.Location = new System.Drawing.Point(3, 140);
            this.hrtRmLbl.Name = "hrtRmLbl";
            this.hrtRmLbl.Size = new System.Drawing.Size(107, 15);
            this.hrtRmLbl.TabIndex = 5;
            this.hrtRmLbl.Text = "Horticulture Room";
            // 
            // hlwyLbl
            // 
            this.hlwyLbl.AutoSize = true;
            this.hlwyLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hlwyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.hlwyLbl.Location = new System.Drawing.Point(275, 172);
            this.hlwyLbl.Name = "hlwyLbl";
            this.hlwyLbl.Size = new System.Drawing.Size(50, 15);
            this.hlwyLbl.TabIndex = 4;
            this.hlwyLbl.Text = "Hallway";
            // 
            // rxCtrlRmLbl
            // 
            this.rxCtrlRmLbl.AutoSize = true;
            this.rxCtrlRmLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rxCtrlRmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rxCtrlRmLbl.Location = new System.Drawing.Point(3, 214);
            this.rxCtrlRmLbl.Name = "rxCtrlRmLbl";
            this.rxCtrlRmLbl.Size = new System.Drawing.Size(129, 15);
            this.rxCtrlRmLbl.TabIndex = 3;
            this.rxCtrlRmLbl.Text = "Reactor Control Room";
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPictureBox.BackgroundImage = global::Moonbase.Properties.Resources.navMap;
            this.mapPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapPictureBox.ErrorImage = null;
            this.mapPictureBox.InitialImage = null;
            this.mapPictureBox.Location = new System.Drawing.Point(0, 27);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(637, 373);
            this.mapPictureBox.TabIndex = 2;
            this.mapPictureBox.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMapToolStripMenuItem,
            this.goToRoomToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(629, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // closeMapToolStripMenuItem
            // 
            this.closeMapToolStripMenuItem.Name = "closeMapToolStripMenuItem";
            this.closeMapToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.closeMapToolStripMenuItem.Text = "Close Map";
            this.closeMapToolStripMenuItem.Click += new System.EventHandler(this.closeMapToolStripMenuItem_Click);
            // 
            // goToRoomToolStripMenuItem
            // 
            this.goToRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedroomToolStripMenuItem,
            this.livingRoomToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.horticultureRoomToolStripMenuItem,
            this.reactorControlRoomToolStripMenuItem,
            this.controlRoomToolStripMenuItem,
            this.hallwayToolStripMenuItem});
            this.goToRoomToolStripMenuItem.Name = "goToRoomToolStripMenuItem";
            this.goToRoomToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.goToRoomToolStripMenuItem.Text = "Go to room";
            // 
            // bedroomToolStripMenuItem
            // 
            this.bedroomToolStripMenuItem.Name = "bedroomToolStripMenuItem";
            this.bedroomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.bedroomToolStripMenuItem.Text = "Bedroom";
            this.bedroomToolStripMenuItem.Click += new System.EventHandler(this.bedroomToolStripMenuItem_Click);
            // 
            // livingRoomToolStripMenuItem
            // 
            this.livingRoomToolStripMenuItem.Name = "livingRoomToolStripMenuItem";
            this.livingRoomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.livingRoomToolStripMenuItem.Text = "Living Room";
            this.livingRoomToolStripMenuItem.Click += new System.EventHandler(this.livingRoomToolStripMenuItem_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // horticultureRoomToolStripMenuItem
            // 
            this.horticultureRoomToolStripMenuItem.Name = "horticultureRoomToolStripMenuItem";
            this.horticultureRoomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.horticultureRoomToolStripMenuItem.Text = "Horticulture Room";
            this.horticultureRoomToolStripMenuItem.Click += new System.EventHandler(this.horticultureRoomToolStripMenuItem_Click);
            // 
            // reactorControlRoomToolStripMenuItem
            // 
            this.reactorControlRoomToolStripMenuItem.Name = "reactorControlRoomToolStripMenuItem";
            this.reactorControlRoomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reactorControlRoomToolStripMenuItem.Text = "Reactor Control Room";
            this.reactorControlRoomToolStripMenuItem.Click += new System.EventHandler(this.reactorControlRoomToolStripMenuItem_Click);
            // 
            // controlRoomToolStripMenuItem
            // 
            this.controlRoomToolStripMenuItem.Name = "controlRoomToolStripMenuItem";
            this.controlRoomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.controlRoomToolStripMenuItem.Text = "Control Room";
            this.controlRoomToolStripMenuItem.Click += new System.EventHandler(this.controlRoomToolStripMenuItem_Click);
            // 
            // hallwayToolStripMenuItem
            // 
            this.hallwayToolStripMenuItem.Name = "hallwayToolStripMenuItem";
            this.hallwayToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hallwayToolStripMenuItem.Text = "Hallway";
            this.hallwayToolStripMenuItem.Click += new System.EventHandler(this.hallwayToolStripMenuItem_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonTest.Location = new System.Drawing.Point(100, 45);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(52, 36);
            this.ButtonTest.TabIndex = 7;
            this.ButtonTest.Text = "Test";
            this.ButtonTest.UseVisualStyleBackColor = false;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Reactor_Control_Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 631);
            this.Controls.Add(this.BaseMapPanel);
            this.Controls.Add(this.groupBoxNavDev);
            this.Controls.Add(this.GroupboxLocInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MoonBase-Leviathan";
            this.GroupboxLocInfo.ResumeLayout(false);
            this.GroupboxLocInfo.PerformLayout();
            this.groupBoxNavDev.ResumeLayout(false);
            this.BaseMapPanel.ResumeLayout(false);
            this.BaseMapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox GroupboxLocInfo;
        private System.Windows.Forms.TextBox TextboxRoomDescription;
        private System.Windows.Forms.TextBox TextboxRoomName;
        private System.Windows.Forms.Label LabelRoomDescription;
        private System.Windows.Forms.Label LabelRoomName;
        private System.Windows.Forms.GroupBox groupBoxNavDev;
        private System.Windows.Forms.Button ButtonHorticultureRm;
        private System.Windows.Forms.Button ButtonBaseCtrlRm;
        private System.Windows.Forms.Button ButtonLivingRm;
        private System.Windows.Forms.Button ButtonRxCtrlRm;
        private Button ButtonBedroom;
        private Button ButtonHallway;
        private Button ButtonKitchen;
        private Panel BaseMapPanel;
        private Button ButtonMap;
        private PictureBox mapPictureBox;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem closeMapToolStripMenuItem;
        private ToolStripMenuItem goToRoomToolStripMenuItem;
        private ToolStripMenuItem bedroomToolStripMenuItem;
        private ToolStripMenuItem livingRoomToolStripMenuItem;
        private ToolStripMenuItem kitchenToolStripMenuItem;
        private ToolStripMenuItem horticultureRoomToolStripMenuItem;
        private ToolStripMenuItem reactorControlRoomToolStripMenuItem;
        private ToolStripMenuItem controlRoomToolStripMenuItem;
        private ToolStripMenuItem hallwayToolStripMenuItem;
        private Label bsCtrlRmLbl;
        private Label ktnLbl;
        private Label lvgRmLbl;
        private Label bdRmLbl;
        private Label hrtRmLbl;
        private Label hlwyLbl;
        private Label rxCtrlRmLbl;
        private Button ButtonTest;
    }
}

