namespace SoftTh_Config_Tool
{
    partial class ConfigForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.displayRelated = new System.Windows.Forms.TabControl();
            this.primHead = new System.Windows.Forms.TabPage();
            this.primTranspBox = new System.Windows.Forms.ComboBox();
            this.primTranspText = new System.Windows.Forms.Label();
            this.primFPSText = new System.Windows.Forms.TextBox();
            this.primFPS = new System.Windows.Forms.CheckBox();
            this.primBtop = new System.Windows.Forms.TextBox();
            this.primBleft = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primNoSync = new System.Windows.Forms.CheckBox();
            this.checkLocalPrim = new System.Windows.Forms.CheckBox();
            this.checkOnOffPrim = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.primPosY = new System.Windows.Forms.TextBox();
            this.primPosX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.primHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.primWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.globalTabs = new System.Windows.Forms.TabControl();
            this.globalSettings = new System.Windows.Forms.TabPage();
            this.kompoBox = new System.Windows.Forms.CheckBox();
            this.debugMode = new System.Windows.Forms.CheckBox();
            this.screenyFormat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useZclear = new System.Windows.Forms.CheckBox();
            this.smoothFPS = new System.Windows.Forms.CheckBox();
            this.NonlocalTransport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.overrides = new System.Windows.Forms.TabPage();
            this.verFovBox = new System.Windows.Forms.CheckBox();
            this.forceMultiBox = new System.Windows.Forms.CheckBox();
            this.vSyncControl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.horFovBox = new System.Windows.Forms.CheckBox();
            this.forceRes = new System.Windows.Forms.CheckBox();
            this.antiAliasing = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dropCentered = new System.Windows.Forms.ComboBox();
            this.checkCentered = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.compatibleIB = new System.Windows.Forms.CheckBox();
            this.compatibleVB = new System.Windows.Forms.CheckBox();
            this.compatibleTex = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.mainRes = new System.Windows.Forms.Label();
            this.GlobalTip = new System.Windows.Forms.ToolTip(this.components);
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.displayRelated.SuspendLayout();
            this.primHead.SuspendLayout();
            this.globalTabs.SuspendLayout();
            this.globalSettings.SuspendLayout();
            this.overrides.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayRelated
            // 
            this.displayRelated.Controls.Add(this.primHead);
            this.displayRelated.Location = new System.Drawing.Point(547, 256);
            this.displayRelated.Name = "displayRelated";
            this.displayRelated.SelectedIndex = 0;
            this.displayRelated.Size = new System.Drawing.Size(300, 300);
            this.displayRelated.TabIndex = 1;
            // 
            // primHead
            // 
            this.primHead.Controls.Add(this.primTranspBox);
            this.primHead.Controls.Add(this.primTranspText);
            this.primHead.Controls.Add(this.primFPSText);
            this.primHead.Controls.Add(this.primFPS);
            this.primHead.Controls.Add(this.primBtop);
            this.primHead.Controls.Add(this.primBleft);
            this.primHead.Controls.Add(this.label11);
            this.primHead.Controls.Add(this.label10);
            this.primHead.Controls.Add(this.label3);
            this.primHead.Controls.Add(this.primNoSync);
            this.primHead.Controls.Add(this.checkLocalPrim);
            this.primHead.Controls.Add(this.checkOnOffPrim);
            this.primHead.Controls.Add(this.label5);
            this.primHead.Controls.Add(this.primPosY);
            this.primHead.Controls.Add(this.primPosX);
            this.primHead.Controls.Add(this.label4);
            this.primHead.Controls.Add(this.primHeight);
            this.primHead.Controls.Add(this.label2);
            this.primHead.Controls.Add(this.primWidth);
            this.primHead.Controls.Add(this.label1);
            this.primHead.Location = new System.Drawing.Point(4, 22);
            this.primHead.Name = "primHead";
            this.primHead.Padding = new System.Windows.Forms.Padding(3);
            this.primHead.Size = new System.Drawing.Size(292, 274);
            this.primHead.TabIndex = 0;
            this.primHead.Text = "Primary Head";
            this.primHead.UseVisualStyleBackColor = true;
            // 
            // primTranspBox
            // 
            this.primTranspBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primTranspBox.Enabled = false;
            this.primTranspBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.primTranspBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primTranspBox.FormattingEnabled = true;
            this.primTranspBox.Items.AddRange(new object[] {
            "Use global setting",
            "High Quality",
            "Quality",
            "Performance"});
            this.primTranspBox.Location = new System.Drawing.Point(151, 217);
            this.primTranspBox.Name = "primTranspBox";
            this.primTranspBox.Size = new System.Drawing.Size(135, 24);
            this.primTranspBox.TabIndex = 20;
            this.GlobalTip.SetToolTip(this.primTranspBox, "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
        "or most(but reduces color depth to 16bit). ");
            this.primTranspBox.SelectedIndexChanged += new System.EventHandler(this.primTranspBox_SelectedIndexChanged);
            // 
            // primTranspText
            // 
            this.primTranspText.AutoSize = true;
            this.primTranspText.Enabled = false;
            this.primTranspText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primTranspText.Location = new System.Drawing.Point(25, 218);
            this.primTranspText.Name = "primTranspText";
            this.primTranspText.Size = new System.Drawing.Size(123, 16);
            this.primTranspText.TabIndex = 19;
            this.primTranspText.Text = "Nonlocal transport :";
            this.GlobalTip.SetToolTip(this.primTranspText, "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
        "or most(but reduces color depth to 16bit). ");
            // 
            // primFPSText
            // 
            this.primFPSText.Enabled = false;
            this.primFPSText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primFPSText.Location = new System.Drawing.Point(125, 180);
            this.primFPSText.Name = "primFPSText";
            this.primFPSText.Size = new System.Drawing.Size(19, 22);
            this.primFPSText.TabIndex = 18;
            this.primFPSText.Text = "0";
            // 
            // primFPS
            // 
            this.primFPS.AutoSize = true;
            this.primFPS.Enabled = false;
            this.primFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primFPS.Location = new System.Drawing.Point(22, 182);
            this.primFPS.Name = "primFPS";
            this.primFPS.Size = new System.Drawing.Size(97, 20);
            this.primFPS.TabIndex = 17;
            this.primFPS.Text = "Limit FPS to";
            this.GlobalTip.SetToolTip(this.primFPS, "Use this for slow monitors (e.g. USB).");
            this.primFPS.UseVisualStyleBackColor = true;
            // 
            // primBtop
            // 
            this.primBtop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primBtop.Location = new System.Drawing.Point(214, 141);
            this.primBtop.Name = "primBtop";
            this.primBtop.Size = new System.Drawing.Size(38, 22);
            this.primBtop.TabIndex = 16;
            this.primBtop.Text = "0";
            this.GlobalTip.SetToolTip(this.primBtop, "Use this to compensate for monitor bezels.");
            this.primBtop.Leave += new System.EventHandler(this.topBorder_Leave);
            // 
            // primBleft
            // 
            this.primBleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primBleft.Location = new System.Drawing.Point(126, 141);
            this.primBleft.Name = "primBleft";
            this.primBleft.Size = new System.Drawing.Size(38, 22);
            this.primBleft.TabIndex = 15;
            this.primBleft.Text = "0";
            this.GlobalTip.SetToolTip(this.primBleft, "Use this to compensate for monitor bezels.");
            this.primBleft.Leave += new System.EventHandler(this.leftBorder_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(164, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "On top:";
            this.GlobalTip.SetToolTip(this.label11, "Use this to compensate for monitor bezels.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Left :";
            this.GlobalTip.SetToolTip(this.label10, "Use this to compensate for monitor bezels.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Borders :";
            this.GlobalTip.SetToolTip(this.label3, "Use this to compensate for monitor bezels.");
            // 
            // primNoSync
            // 
            this.primNoSync.AutoSize = true;
            this.primNoSync.Enabled = false;
            this.primNoSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primNoSync.Location = new System.Drawing.Point(180, 23);
            this.primNoSync.Name = "primNoSync";
            this.primNoSync.Size = new System.Drawing.Size(118, 20);
            this.primNoSync.TabIndex = 11;
            this.primNoSync.Text = "Don\'t sync FPS";
            this.GlobalTip.SetToolTip(this.primNoSync, "Use this for slow monitors (e.g. USB).");
            this.primNoSync.UseVisualStyleBackColor = true;
            // 
            // checkLocalPrim
            // 
            this.checkLocalPrim.AutoSize = true;
            this.checkLocalPrim.Checked = true;
            this.checkLocalPrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkLocalPrim.Enabled = false;
            this.checkLocalPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLocalPrim.Location = new System.Drawing.Point(80, 23);
            this.checkLocalPrim.Name = "checkLocalPrim";
            this.checkLocalPrim.Size = new System.Drawing.Size(94, 20);
            this.checkLocalPrim.TabIndex = 10;
            this.checkLocalPrim.Text = "Local head";
            this.GlobalTip.SetToolTip(this.checkLocalPrim, "Disable if the corresponding screen is not connected to the primary graphicscard." +
        "");
            this.checkLocalPrim.UseVisualStyleBackColor = true;
            // 
            // checkOnOffPrim
            // 
            this.checkOnOffPrim.AutoSize = true;
            this.checkOnOffPrim.Checked = true;
            this.checkOnOffPrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOnOffPrim.Enabled = false;
            this.checkOnOffPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOnOffPrim.Location = new System.Drawing.Point(22, 23);
            this.checkOnOffPrim.Name = "checkOnOffPrim";
            this.checkOnOffPrim.Size = new System.Drawing.Size(52, 20);
            this.checkOnOffPrim.TabIndex = 9;
            this.checkOnOffPrim.Text = "Use";
            this.checkOnOffPrim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y:";
            // 
            // primPosY
            // 
            this.primPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primPosY.Location = new System.Drawing.Point(170, 95);
            this.primPosY.Name = "primPosY";
            this.primPosY.Size = new System.Drawing.Size(38, 22);
            this.primPosY.TabIndex = 7;
            this.primPosY.Leave += new System.EventHandler(this.primPosY_Leave);
            // 
            // primPosX
            // 
            this.primPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primPosX.Location = new System.Drawing.Point(106, 95);
            this.primPosX.Name = "primPosX";
            this.primPosX.Size = new System.Drawing.Size(38, 22);
            this.primPosX.TabIndex = 5;
            this.primPosX.Leave += new System.EventHandler(this.primPosX_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position :   X:";
            // 
            // primHeight
            // 
            this.primHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primHeight.Location = new System.Drawing.Point(170, 60);
            this.primHeight.Name = "primHeight";
            this.primHeight.Size = new System.Drawing.Size(38, 22);
            this.primHeight.TabIndex = 3;
            this.primHeight.Leave += new System.EventHandler(this.primHeight_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            // 
            // primWidth
            // 
            this.primWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primWidth.Location = new System.Drawing.Point(106, 60);
            this.primWidth.Name = "primWidth";
            this.primWidth.Size = new System.Drawing.Size(38, 22);
            this.primWidth.TabIndex = 1;
            this.primWidth.Leave += new System.EventHandler(this.primWidth_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution :";
            // 
            // globalTabs
            // 
            this.globalTabs.Controls.Add(this.globalSettings);
            this.globalTabs.Controls.Add(this.overrides);
            this.globalTabs.Controls.Add(this.tabPage1);
            this.globalTabs.Location = new System.Drawing.Point(12, 256);
            this.globalTabs.Name = "globalTabs";
            this.globalTabs.SelectedIndex = 0;
            this.globalTabs.Size = new System.Drawing.Size(300, 300);
            this.globalTabs.TabIndex = 2;
            // 
            // globalSettings
            // 
            this.globalSettings.Controls.Add(this.kompoBox);
            this.globalSettings.Controls.Add(this.debugMode);
            this.globalSettings.Controls.Add(this.screenyFormat);
            this.globalSettings.Controls.Add(this.label7);
            this.globalSettings.Controls.Add(this.useZclear);
            this.globalSettings.Controls.Add(this.smoothFPS);
            this.globalSettings.Controls.Add(this.NonlocalTransport);
            this.globalSettings.Controls.Add(this.label6);
            this.globalSettings.Location = new System.Drawing.Point(4, 22);
            this.globalSettings.Name = "globalSettings";
            this.globalSettings.Padding = new System.Windows.Forms.Padding(3);
            this.globalSettings.Size = new System.Drawing.Size(292, 274);
            this.globalSettings.TabIndex = 0;
            this.globalSettings.Text = "Global Settings";
            this.globalSettings.UseVisualStyleBackColor = true;
            // 
            // kompoBox
            // 
            this.kompoBox.AutoSize = true;
            this.kompoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kompoBox.Location = new System.Drawing.Point(33, 98);
            this.kompoBox.Name = "kompoBox";
            this.kompoBox.Size = new System.Drawing.Size(108, 20);
            this.kompoBox.TabIndex = 8;
            this.kompoBox.Text = "Keep aero on";
            this.GlobalTip.SetToolTip(this.kompoBox, "Check to stop SoftTH from forcing the OS  in \"Aero Basic\" mode. \r\nMay change comp" +
        "atibility in some games.");
            this.kompoBox.UseVisualStyleBackColor = true;
            this.kompoBox.CheckedChanged += new System.EventHandler(this.kompoBox_CheckedChanged);
            // 
            // debugMode
            // 
            this.debugMode.AutoSize = true;
            this.debugMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugMode.Location = new System.Drawing.Point(32, 182);
            this.debugMode.Name = "debugMode";
            this.debugMode.Size = new System.Drawing.Size(109, 20);
            this.debugMode.TabIndex = 7;
            this.debugMode.Text = "Debug mode ";
            this.GlobalTip.SetToolTip(this.debugMode, "Enables more logging details. \r\nDo not enable for normal, performance oriented, u" +
        "se.");
            this.debugMode.UseVisualStyleBackColor = true;
            this.debugMode.CheckedChanged += new System.EventHandler(this.debugMode_CheckedChanged);
            // 
            // screenyFormat
            // 
            this.screenyFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenyFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.screenyFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenyFormat.FormattingEnabled = true;
            this.screenyFormat.Items.AddRange(new object[] {
            "JPEG",
            "Bitmap",
            "PNG"});
            this.screenyFormat.Location = new System.Drawing.Point(156, 63);
            this.screenyFormat.Name = "screenyFormat";
            this.screenyFormat.Size = new System.Drawing.Size(101, 24);
            this.screenyFormat.TabIndex = 6;
            this.screenyFormat.SelectedIndexChanged += new System.EventHandler(this.screenyFormat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Screenshot format :";
            // 
            // useZclear
            // 
            this.useZclear.AutoSize = true;
            this.useZclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useZclear.Location = new System.Drawing.Point(32, 150);
            this.useZclear.Name = "useZclear";
            this.useZclear.Size = new System.Drawing.Size(178, 20);
            this.useZclear.TabIndex = 4;
            this.useZclear.Text = "Don\'t render unused area";
            this.GlobalTip.SetToolTip(this.useZclear, "Enables a z-buffer hack which ignores the render area which is not shown on any s" +
        "creen. \r\nThe area will be missing on screenshots, too! It\'s not compatible with " +
        "all games.");
            this.useZclear.UseVisualStyleBackColor = true;
            this.useZclear.CheckedChanged += new System.EventHandler(this.useZclear_CheckedChanged);
            // 
            // smoothFPS
            // 
            this.smoothFPS.AutoSize = true;
            this.smoothFPS.Checked = true;
            this.smoothFPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smoothFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smoothFPS.Location = new System.Drawing.Point(32, 124);
            this.smoothFPS.Name = "smoothFPS";
            this.smoothFPS.Size = new System.Drawing.Size(133, 20);
            this.smoothFPS.TabIndex = 3;
            this.smoothFPS.Text = "Smooth framerate";
            this.GlobalTip.SetToolTip(this.smoothFPS, "Reduces maximum framerate to get smoother average framerate.");
            this.smoothFPS.UseVisualStyleBackColor = true;
            this.smoothFPS.CheckedChanged += new System.EventHandler(this.smoothFPS_CheckedChanged);
            // 
            // NonlocalTransport
            // 
            this.NonlocalTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NonlocalTransport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NonlocalTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonlocalTransport.FormattingEnabled = true;
            this.NonlocalTransport.Items.AddRange(new object[] {
            "High Quality",
            "Quality",
            "Performance"});
            this.NonlocalTransport.Location = new System.Drawing.Point(156, 26);
            this.NonlocalTransport.Name = "NonlocalTransport";
            this.NonlocalTransport.Size = new System.Drawing.Size(101, 24);
            this.NonlocalTransport.TabIndex = 2;
            this.GlobalTip.SetToolTip(this.NonlocalTransport, "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
        "or most(but reduces color depth to 16bit). ");
            this.NonlocalTransport.SelectedIndexChanged += new System.EventHandler(this.NonlocalTransport_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nonlocal transport :";
            this.GlobalTip.SetToolTip(this.label6, "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
        "or most(but reduces color depth to 16bit). ");
            // 
            // overrides
            // 
            this.overrides.Controls.Add(this.verFovBox);
            this.overrides.Controls.Add(this.forceMultiBox);
            this.overrides.Controls.Add(this.vSyncControl);
            this.overrides.Controls.Add(this.label8);
            this.overrides.Controls.Add(this.horFovBox);
            this.overrides.Controls.Add(this.forceRes);
            this.overrides.Controls.Add(this.antiAliasing);
            this.overrides.Controls.Add(this.label9);
            this.overrides.Location = new System.Drawing.Point(4, 22);
            this.overrides.Name = "overrides";
            this.overrides.Padding = new System.Windows.Forms.Padding(3);
            this.overrides.Size = new System.Drawing.Size(292, 274);
            this.overrides.TabIndex = 1;
            this.overrides.Text = "Overrides";
            this.overrides.UseVisualStyleBackColor = true;
            // 
            // verFovBox
            // 
            this.verFovBox.AutoSize = true;
            this.verFovBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verFovBox.Location = new System.Drawing.Point(32, 157);
            this.verFovBox.Name = "verFovBox";
            this.verFovBox.Size = new System.Drawing.Size(180, 20);
            this.verFovBox.TabIndex = 15;
            this.verFovBox.Text = "Force vertical field of view";
            this.verFovBox.UseVisualStyleBackColor = true;
            this.verFovBox.CheckedChanged += new System.EventHandler(this.verFovBox_CheckedChanged);
            // 
            // forceMultiBox
            // 
            this.forceMultiBox.AutoSize = true;
            this.forceMultiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forceMultiBox.Location = new System.Drawing.Point(32, 195);
            this.forceMultiBox.Name = "forceMultiBox";
            this.forceMultiBox.Size = new System.Drawing.Size(160, 20);
            this.forceMultiBox.TabIndex = 14;
            this.forceMultiBox.Text = "Force multicore usage";
            this.forceMultiBox.UseVisualStyleBackColor = true;
            this.forceMultiBox.CheckedChanged += new System.EventHandler(this.forceMultiBox_CheckedChanged);
            // 
            // vSyncControl
            // 
            this.vSyncControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vSyncControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vSyncControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vSyncControl.FormattingEnabled = true;
            this.vSyncControl.Items.AddRange(new object[] {
            "Off",
            "On",
            "On+Buffer"});
            this.vSyncControl.Location = new System.Drawing.Point(155, 63);
            this.vSyncControl.Name = "vSyncControl";
            this.vSyncControl.Size = new System.Drawing.Size(101, 24);
            this.vSyncControl.TabIndex = 13;
            this.vSyncControl.SelectedIndexChanged += new System.EventHandler(this.vSyncControl_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vertical sync :";
            // 
            // horFovBox
            // 
            this.horFovBox.AutoSize = true;
            this.horFovBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horFovBox.Location = new System.Drawing.Point(32, 131);
            this.horFovBox.Name = "horFovBox";
            this.horFovBox.Size = new System.Drawing.Size(194, 20);
            this.horFovBox.TabIndex = 11;
            this.horFovBox.Text = "Force horizontal field of view";
            this.horFovBox.UseVisualStyleBackColor = true;
            this.horFovBox.CheckedChanged += new System.EventHandler(this.horFovBox_CheckedChanged);
            // 
            // forceRes
            // 
            this.forceRes.AutoSize = true;
            this.forceRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forceRes.Location = new System.Drawing.Point(32, 105);
            this.forceRes.Name = "forceRes";
            this.forceRes.Size = new System.Drawing.Size(165, 20);
            this.forceRes.TabIndex = 10;
            this.forceRes.Text = "Force render resolution";
            this.forceRes.UseVisualStyleBackColor = true;
            this.forceRes.CheckedChanged += new System.EventHandler(this.forceRes_CheckedChanged);
            // 
            // antiAliasing
            // 
            this.antiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.antiAliasing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.antiAliasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiAliasing.FormattingEnabled = true;
            this.antiAliasing.Items.AddRange(new object[] {
            "Application",
            "2x",
            "4x",
            "8x"});
            this.antiAliasing.Location = new System.Drawing.Point(155, 26);
            this.antiAliasing.Name = "antiAliasing";
            this.antiAliasing.Size = new System.Drawing.Size(101, 24);
            this.antiAliasing.TabIndex = 9;
            this.antiAliasing.SelectedIndexChanged += new System.EventHandler(this.antiAliasing_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Anti-Aliasing :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dropCentered);
            this.tabPage1.Controls.Add(this.checkCentered);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.compatibleIB);
            this.tabPage1.Controls.Add(this.compatibleVB);
            this.tabPage1.Controls.Add(this.compatibleTex);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(292, 274);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Additional Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dropCentered
            // 
            this.dropCentered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCentered.Enabled = false;
            this.dropCentered.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dropCentered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropCentered.FormattingEnabled = true;
            this.dropCentered.Items.AddRange(new object[] {
            "Primary"});
            this.dropCentered.Location = new System.Drawing.Point(154, 141);
            this.dropCentered.Name = "dropCentered";
            this.dropCentered.Size = new System.Drawing.Size(71, 24);
            this.dropCentered.TabIndex = 18;
            this.dropCentered.SelectedIndexChanged += new System.EventHandler(this.dropCentered_SelectedIndexChanged);
            // 
            // checkCentered
            // 
            this.checkCentered.AutoSize = true;
            this.checkCentered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCentered.Location = new System.Drawing.Point(24, 143);
            this.checkCentered.Name = "checkCentered";
            this.checkCentered.Size = new System.Drawing.Size(121, 20);
            this.checkCentered.TabIndex = 17;
            this.checkCentered.Text = "Center on head:";
            this.GlobalTip.SetToolTip(this.checkCentered, "Centeres the image to the selected head.\r\nUse \"Don\'t render unused area\" to compe" +
        "nsate performance hits.");
            this.checkCentered.UseVisualStyleBackColor = true;
            this.checkCentered.CheckedChanged += new System.EventHandler(this.checkCentered_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Special arrangements:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Compatibility:";
            // 
            // compatibleIB
            // 
            this.compatibleIB.AutoSize = true;
            this.compatibleIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatibleIB.Location = new System.Drawing.Point(24, 34);
            this.compatibleIB.Name = "compatibleIB";
            this.compatibleIB.Size = new System.Drawing.Size(139, 20);
            this.compatibleIB.TabIndex = 14;
            this.compatibleIB.Text = "Debug index buffer";
            this.GlobalTip.SetToolTip(this.compatibleIB, "May solve issues in specific games, but degrades performance.");
            this.compatibleIB.UseVisualStyleBackColor = true;
            this.compatibleIB.CheckedChanged += new System.EventHandler(this.compatibleIB_CheckedChanged);
            // 
            // compatibleVB
            // 
            this.compatibleVB.AutoSize = true;
            this.compatibleVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatibleVB.Location = new System.Drawing.Point(25, 86);
            this.compatibleVB.Name = "compatibleVB";
            this.compatibleVB.Size = new System.Drawing.Size(143, 20);
            this.compatibleVB.TabIndex = 13;
            this.compatibleVB.Text = "Debug vertex buffer";
            this.GlobalTip.SetToolTip(this.compatibleVB, "May solve issues in specific games, but degrades performance.");
            this.compatibleVB.UseVisualStyleBackColor = true;
            this.compatibleVB.CheckedChanged += new System.EventHandler(this.compatibleVB_CheckedChanged);
            // 
            // compatibleTex
            // 
            this.compatibleTex.AutoSize = true;
            this.compatibleTex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatibleTex.Location = new System.Drawing.Point(24, 60);
            this.compatibleTex.Name = "compatibleTex";
            this.compatibleTex.Size = new System.Drawing.Size(120, 20);
            this.compatibleTex.TabIndex = 12;
            this.compatibleTex.Text = "Debug texturing";
            this.GlobalTip.SetToolTip(this.compatibleTex, "May solve issues in specific games, but degrades performance.");
            this.compatibleTex.UseVisualStyleBackColor = true;
            this.compatibleTex.CheckedChanged += new System.EventHandler(this.compatibleTex_CheckedChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(462, 527);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(79, 25);
            this.save.TabIndex = 3;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // mainRes
            // 
            this.mainRes.AutoSize = true;
            this.mainRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRes.Location = new System.Drawing.Point(360, 278);
            this.mainRes.Name = "mainRes";
            this.mainRes.Size = new System.Drawing.Size(141, 32);
            this.mainRes.TabIndex = 4;
            this.mainRes.Text = "Your total resolution is:\r\n1000x1000";
            this.mainRes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainRes.UseWaitCursor = true;
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(318, 527);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(79, 25);
            this.load.TabIndex = 5;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 568);
            this.Controls.Add(this.load);
            this.Controls.Add(this.mainRes);
            this.Controls.Add(this.save);
            this.Controls.Add(this.globalTabs);
            this.Controls.Add(this.displayRelated);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SoftTH Config Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.displayRelated.ResumeLayout(false);
            this.primHead.ResumeLayout(false);
            this.primHead.PerformLayout();
            this.globalTabs.ResumeLayout(false);
            this.globalSettings.ResumeLayout(false);
            this.globalSettings.PerformLayout();
            this.overrides.ResumeLayout(false);
            this.overrides.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl displayRelated;
        private System.Windows.Forms.TabPage primHead;
        private System.Windows.Forms.TabPage globalSettings;
        private System.Windows.Forms.TabPage overrides;
        private System.Windows.Forms.TabControl globalTabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox primPosY;
        private System.Windows.Forms.TextBox primPosX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox primHeight;
        private System.Windows.Forms.TextBox primWidth;
        private System.Windows.Forms.ComboBox NonlocalTransport;
        private System.Windows.Forms.ComboBox screenyFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox useZclear;
        private System.Windows.Forms.CheckBox smoothFPS;
        private System.Windows.Forms.CheckBox debugMode;
        private System.Windows.Forms.CheckBox verFovBox;
        private System.Windows.Forms.CheckBox forceMultiBox;
        private System.Windows.Forms.ComboBox vSyncControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox horFovBox;
        private System.Windows.Forms.CheckBox forceRes;
        private System.Windows.Forms.ComboBox antiAliasing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox checkLocalPrim;
        private System.Windows.Forms.CheckBox checkOnOffPrim;
        private System.Windows.Forms.CheckBox kompoBox;
        private System.Windows.Forms.CheckBox primNoSync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox primBtop;
        private System.Windows.Forms.TextBox primBleft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox primFPSText;
        private System.Windows.Forms.CheckBox primFPS;
        private System.Windows.Forms.Label mainRes;
        private System.Windows.Forms.ToolTip GlobalTip;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox compatibleIB;
        private System.Windows.Forms.CheckBox compatibleVB;
        private System.Windows.Forms.CheckBox compatibleTex;
        private System.Windows.Forms.ComboBox dropCentered;
        private System.Windows.Forms.CheckBox checkCentered;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox primTranspBox;
        private System.Windows.Forms.Label primTranspText;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

